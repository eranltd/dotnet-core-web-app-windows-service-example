using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Text;



namespace DataBaseService
{

    /// <summary>
    /// ADO.NET data access using the SQL Server Managed Provider.
    /// </summary>
    public class Database : IDisposable
    {
        protected string ConnectionString;
        // connection to data source
        private SqlConnection con;


        public Database()
        {
            try
            {
                //ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"].ToString();
                ConnectionString = Helper.ReadSetting("ConnectionString");
            }
            catch { }
        }
        public Database(string connectionString)
        {
            ConnectionString = connectionString;
        }
        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <returns>Stored procedure return value.</returns>
        public void RunProc(string ProcName)
        {
            SqlCommand cmd = CreateCommand(ProcName, null);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        public int RunNonQuery(string sql)
        {
            SqlCommand cmd = CreateTextCommand(sql, null);
            //System.Data.SqlClient.SqlClientMetaDataCollectionNames.Procedures p = 
            //con.GetSchema(
            cmd.ExecuteNonQuery();
            this.Close();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <param name="CommandTimeout">The time in seconds to wait for the command to execute. The default is 30 seconds.</param>
        /// <returns>Stored procedure return value.</returns>
        public void RunProc(string ProcName, ParamList Prams, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, Prams);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            cmd.ExecuteNonQuery();
            this.Close();
        }

        /// <summary>
        /// Run stored procedure.5
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string ProcName, ParamList Prams, out SqlDataReader Reader, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, Prams);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            Reader = cmd.ExecuteReader();
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string ProcName, out SqlDataReader Reader)
        {
            SqlCommand cmd = CreateCommand(ProcName, null);
            Reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Run stored procedure.5
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string ProcName, ParamList Prams, out SqlDataReader Reader)
        {
            SqlCommand cmd = CreateCommand(ProcName, Prams);
            Reader = cmd.ExecuteReader();
        }

        ///// <summary>
        ///// Run stored procedure.
        ///// </summary>
        ///// <param name="procName">Name of stored procedure.</param>
        ///// <param name="dataReader">Return result of procedure.</param>
        //public void RunProc(string ProcName, out XmlReader Reader)
        //{
        //    RunProc(ProcName, out Reader, 30);
        //}

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string ProcName, out XmlReader Reader, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, null);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            Reader = cmd.ExecuteXmlReader();
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string ProcName, ParamList Prams, out XmlReader Reader, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, Prams);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            Reader = cmd.ExecuteXmlReader();
        }

        public string ExecuteScalar(string ProcName, ParamList Prams, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, Prams);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            object result = cmd.ExecuteScalar();
            string s = null;
            if (result != null)
                s = result.ToString();
            return s;
        }

        /// <summary>
        /// Retrive DataView from DataBase with the Sql query.
        /// </summary>
        /// <param name="Sql">Sql query.</param>
        /// <param name="prms">Query Parameters.</param>
        /// <returns>New DataView with the retrived data.</returns>
        public DataView GetDataView(string ProcName, ParamList prms)
        {
            SqlCommand cmd = CreateCommand(ProcName, prms);
            DataSet ds = new DataSet();
            Open();
            cmd.Connection = con;
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
                //ErrorHendler er = new ErrorHendler();
                //er.ReportError(ex);
            }
            finally
            {
                Close();
            }
            return ds.Tables[0].DefaultView;
        }

        public DataSet GetDataSet(string ProcName, ParamList prms)
        {
            return GetDataSet(ProcName, prms, 30);
        }

        public DataSet GetDataSet(string ProcName, ParamList prms, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, prms);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            DataSet ds = new DataSet();
            Open();
            cmd.Connection = con;
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
                //ErrorHendler er = new ErrorHendler();
                //er.ReportError(ex);
            }
            finally
            {
                Close();
            }
            return ds;
        }

        /// <summary>
        /// Run Query.
        /// </summary>
        /// <param name="Query">The Query String</param>
        /// <param name="prams">Query params.</param>
        /// <param name="Reader">Return result of Query.</param>
        public void RunQuery(string Query, ParamList Prams, out XmlReader Reader)
        {
            SqlCommand cmd = CreateTextCommand(Query, Prams);
            Reader = cmd.ExecuteXmlReader();
        }


        /// <summary>
        /// Retrive one field from Text Query
        /// </summary>
        /// <param name="Query">Text Query</param>
        /// <param name="Prams">Query params.</param>
        /// <returns>Return result of Query</returns>
        public Object GetQueryScalar(string Query, ParamList Prams)
        {
            SqlCommand cmd = CreateTextCommand(Query, Prams);
            return cmd.ExecuteScalar();
        }

        /// <summary>
        /// Retrive one field from stored procedure.
        /// </summary>
        /// <param name="Query">The Name of stored procedure.</param>
        /// <param name="Prams">Query params.</param>
        /// <returns>Return result of Query</returns>
        public Object GetProcScalar(string ProcName, ParamList Prams, int CommandTimeout = 30)
        {
            SqlCommand cmd = CreateCommand(ProcName, Prams);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            return cmd.ExecuteScalar();
        }

        public string GetJSON(string ProcName, ParamList Prams, int CommandTimeout = 30)
        {
            string result;

            SqlCommand cmd = CreateCommand(ProcName, Prams);

            if (CommandTimeout != 0)
                cmd.CommandTimeout = CommandTimeout;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                var jsonResult = new StringBuilder();

                if (!reader.HasRows)
                {
                    jsonResult.Append("[]");
                }
                else
                {
                    while (reader.Read())
                    {
                        jsonResult.Append(reader.GetValue(0).ToString());
                    }
                }

                result = jsonResult.ToString();
            }

            return result;
        }

        /// <summary>
        /// Run Query.
        /// </summary>
        /// <param name="Query">The Query String</param>
        /// <param name="prams">Query params.</param>
        /// <param name="Reader">Return result of procedure.</param>
        public void RunQuery(string Query, ParamList Prams, out SqlDataReader Reader)
        {
            SqlCommand cmd = CreateTextCommand(Query, Prams);
            Reader = cmd.ExecuteReader();
        }

        /// <summary>
        /// Create command object used to call stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Params to stored procedure.</param>
        /// <returns>Command object.</returns>
        protected SqlCommand CreateCommand(string ProcName, ParamList Prams)
        {
            // make sure connection is open
            Open();

            //command = new SqlCommand( sprocName, new SqlConnection( ConfigManager.DALConnectionString ) );
            SqlCommand cmd = new SqlCommand(ProcName, con);
            cmd.CommandType = CommandType.StoredProcedure;

            // add proc parameters
            if (Prams != null)
            {
                SqlParameter[] prams = Prams.ToArray();
                foreach (SqlParameter parameter in prams)
                {
                    if (parameter != null)
                        cmd.Parameters.Add(parameter);
                }
            }
            return cmd;
        }

        /// <summary>
        /// Create command object used to run table direct command.
        /// </summary>
        /// <param name="procName">Query string.</param>
        /// <param name="prams">Params to Query.</param>
        /// <returns>Command object.</returns>
        private SqlCommand CreateTextCommand(string Query, ParamList Prams)
        {
            // make sure connection is open
            Open();

            //command = new SqlCommand( sprocName, new SqlConnection( ConfigManager.DALConnectionString ) );
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.CommandType = CommandType.Text;

            // add proc parameters
            if (Prams != null)
            {
                SqlParameter[] prams = Prams.ToArray();
                foreach (SqlParameter parameter in prams)
                {
                    if (parameter != null)
                        cmd.Parameters.Add(parameter);
                }
            }
            return cmd;
        }


        /// <summary>
        /// Open the connection.
        /// </summary>
        private void Open()
        {
            // open connection
            if (con == null || con.State == ConnectionState.Closed)
            {
                string sqlConnStr = ConnectionString;
                con = new SqlConnection(sqlConnStr);
                con.Open();
            }
        }

        /// <summary>
        /// Close the connection.
        /// </summary>
        public void Close()
        {
            if (con != null)
                con.Close();
        }

        /// <summary>
        /// Release resources.
        /// </summary>
        public void Dispose()
        {
            // make sure connection is closed
            if (con != null)
            {
                con.Dispose();
                con = null;
            }
        }



        internal SqlConnection GetDBConnection()
        {
            Open();

            return con;
        }
    }

}