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
//Functions for BrioConnect schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetAssociateBrioVariation_BrioConnectSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("BrioConnect.GetAssociateBrioVariation",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAssociateBrioVariation_BrioConnectDs( Object JewelID)
    {
            SqlDataReader reader = GetAssociateBrioVariation_BrioConnectSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetBrioFeedXML_BrioConnect( Object LastUpdate)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastUpdate", SqlDbType.NVarChar, 50, LastUpdate);
        XmlReader reader;
        data.RunProc("BrioConnect.GetBrioFeedXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetBrioFolderTreeXML_BrioConnect( Object brioSKU)
    {
        ParamList pl = new ParamList();
		pl.Add("@brioSKU", SqlDbType.VarChar, 50, brioSKU);
        XmlReader reader;
        data.RunProc("BrioConnect.GetBrioFolderTreeXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetBrioModelsXML_BrioConnect()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("BrioConnect.GetBrioModelsXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetCategoryFeedXML_BrioConnect( Object LastUpdate)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastUpdate", SqlDbType.NVarChar, 50, LastUpdate);
        XmlReader reader;
        data.RunProc("BrioConnect.GetCategoryFeedXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetUpdatesForBrio_BrioConnectSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("BrioConnect.GetUpdatesForBrio",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUpdatesForBrio_BrioConnectDs()
    {
            SqlDataReader reader = GetUpdatesForBrio_BrioConnectSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
}
