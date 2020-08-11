using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataLayerLibrary
{
    public class SyncData
    {

        private static SyncData instance;

        string xmlPath;

        public SyncData()
        {
            //xmlPath = HttpContext.Current.Server.MapPath("~/SyncData.xml");
            //if (File.Exists(xmlPath))
            //{
            //    data.ReadXml(xmlPath);
            //    Sync();
            //}
            //else
            //{

            using (DataLayer dl = new DataLayer())
            {
                data = dl.GetSyncData_CoreUIDs(null);
                //data.SetTableNames();
                data.ExtendedProperties.Add("LastSync", data.Tables[0].Rows[0]["LastSync"].ToString());
            }

                
                //data.WriteXml(xmlPath, XmlWriteMode.WriteSchema);
            //}
        }

        private DataSet data = new DataSet();
        public DataSet Data
        {
            get
            {
                return data;
            }
        }



        public DataTable GetTable(string name)
        {
            return Data.Tables[name];
        }

        public static SyncData Instance
        {
            get
            {
                if (instance == null)
                    instance = new SyncData();
                return instance;
            }
        }

        public string ToJson()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("var SyncData = { ");

            for (int i = 1; i < data.Tables.Count; i++)
            {
                if (i > 1)
                    sb.Append(",");
                sb.Append("\"" + data.Tables[i].TableName + "\":[");
                DataTable dt = data.Tables[i];
                sb.Append("{\"id\":\"\",\"Name\":\"\" }");
                for (int r = 0; r < dt.Rows.Count; r++)
                {

                    sb.Append(",");
                    sb.Append("{");
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        if (c == 0)
                            sb.Append("\"id\":\"" + dt.Rows[r][c].ToString() + "\"");
                        else
                            sb.Append(",\"" + dt.Columns[c].ColumnName + "\":\"" + dt.Rows[r][c].ToString() + "\"");
                    }
                    sb.Append("}");
                }
                sb.Append("]");
            }
            sb.Append("};");
            return sb.ToString();
        }

        public void Sync()
        {
            string lastSync = data.ExtendedProperties["LastSync"].ToString();

            DataSet changes = null;

            using (DataLayer dl = new DataLayer())
            {
                changes = dl.GetSyncData_CoreUIDs(lastSync);
            }

            //changes.DataSetName("");
            if (changes.Tables[0].Rows.Count > 0)
                data.ExtendedProperties["LastSync"] = changes.Tables[0].Rows[0]["LastSync"].ToString();
            for (int i = 1; i < changes.Tables.Count; i++)
            {
                if (data.Tables.Contains(changes.Tables[i].TableName))
                {
                    data.Tables[changes.Tables[i].TableName].Rows.Clear();
                    data.Tables[changes.Tables[i].TableName].Merge(changes.Tables[i], false);
                }
                else
                {
                    data.Tables.Add(changes.Tables[i].Copy());
                }
            }
            data.WriteXml(xmlPath, XmlWriteMode.WriteSchema);

        }


    }
}
