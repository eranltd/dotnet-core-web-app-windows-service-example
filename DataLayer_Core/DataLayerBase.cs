using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using DataBaseService;
using System.Xml;

/// <summary>
/// abstract class for databese menipulations
/// </summary>
public abstract class DataLayerBase
{
    protected Database data = new Database();

    public DataLayerBase()
    {

    }

    /// <summary>
    /// Get XmlReader from db by text query
    /// </summary>
    /// <param name="Query">Text Query</param>
    /// <param name="prams">SqlParameter list</param>
    /// <returns>XmlReader with the results</returns>
    public XmlReader GetXmlReader(string Query, ParamList prams)
    {
        XmlReader xmlReader = null;

        // run the stored procedure
        data.RunQuery(Query, prams, out xmlReader);

        return xmlReader;
    }
    public SqlDataReader GetSqlDataReader(string Query, ParamList prams)
    {
        SqlDataReader reader;
        data.RunQuery(Query, prams, out reader);
        return reader;
    }

    protected DataSet GetDataSet(IDataReader reader)
    {
        DataSet ds = new DataSet();
        while (!reader.IsClosed)
        {
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
        } 
        return ds;
    }

    public static SqlDataReader GetSproc(string sprocName, ParamList pl, int CommandTimeout = 30)
    {
        return GetSprocSDR(sprocName, pl, CommandTimeout);
    }

    public static SqlDataReader GetSprocSDR(string sprocName, ParamList pl, int CommandTimeout = 30)
    {
        DataBaseService.Database data = new DataBaseService.Database();
        
        SqlDataReader reader;
        data.RunProc(sprocName,pl, out reader, CommandTimeout);
        return reader;
    }

    public static DataSet GetSprocDs(string sprocName, ParamList pl)
    {
        DataBaseService.Database data = new DataBaseService.Database();

        return data.GetDataSet(sprocName, pl);
    }

    public static XmlReader GetSprocXml(string sprocName, ParamList pl)
    {
        DataBaseService.Database data = new DataBaseService.Database();

        XmlReader reader;
        data.RunProc(sprocName, pl, out reader);
        return reader;
    }

    public string GetScalar(string sproc, ParamList pl)
    {
        string result = data.ExecuteScalar(sproc, pl);
        Close();
        return result;
    }

    public void Close()
    {
        data.Close();
    }
}
