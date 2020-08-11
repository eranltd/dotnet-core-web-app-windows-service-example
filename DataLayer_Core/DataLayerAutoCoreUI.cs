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
//Functions for CoreUI schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetSProcPrams_CoreUISDR( Object SprocName, Object Schema)
    {
        ParamList pl = new ParamList();
		pl.Add("@SprocName", SqlDbType.NVarChar, 128, SprocName);
		pl.Add("@Schema", SqlDbType.NVarChar, 128, Schema);
        SqlDataReader reader;
        data.RunProc("CoreUI.GetSProcPrams",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSProcPrams_CoreUIDs( Object SprocName, Object Schema)
    {
            SqlDataReader reader = GetSProcPrams_CoreUISDR(  SprocName,  Schema);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierVisuals_CoreUISDR( Object SupplierBrunchID, Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierBrunchID", SqlDbType.Int, 0, SupplierBrunchID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("CoreUI.GetSupplierVisuals",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierVisuals_CoreUIDs( Object SupplierBrunchID, Object DiamondID)
    {
            SqlDataReader reader = GetSupplierVisuals_CoreUISDR(  SupplierBrunchID,  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSyncData_CoreUISDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("CoreUI.GetSyncData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSyncData_CoreUIDs( Object LastModify)
    {
            SqlDataReader reader = GetSyncData_CoreUISDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void SetPictureNotExist_CoreUI( Object PictureID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PictureID", SqlDbType.Int, 0, PictureID);
        data.RunProc("CoreUI.SetPictureNotExist",pl);
        
        data.Close();        
    }
    
}
