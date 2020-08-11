using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;


/// <summary>
/// DataLayerAuto auto Generated code.
/// Provide DAL Function coresponding to sql stored procedures.
/// </summary>
public partial class DataLayerAuto : DataLayerBase
{
    
//--------------------------------------------------------------------------------
//Functions for AdminCoreUI schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetSProcPrams_AdminCoreUISDR( Object SprocName)
    {
        ParamList pl = new ParamList();
		pl.Add("@SprocName", SqlDbType.NVarChar, 128, SprocName);
        SqlDataReader reader;
        data.RunProc("AdminCoreUI.GetSProcPrams",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSProcPrams_AdminCoreUIDs( Object SprocName)
    {
            SqlDataReader reader = GetSProcPrams_AdminCoreUISDR(  SprocName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
}
