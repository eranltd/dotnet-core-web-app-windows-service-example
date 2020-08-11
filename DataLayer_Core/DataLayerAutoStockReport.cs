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
//Functions for StockReport schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetSterlingStockReport_StockReportSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockReport.GetSterlingStockReport",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSterlingStockReport_StockReportDs()
    {
            SqlDataReader reader = GetSterlingStockReport_StockReportSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierStockReport_StockReportSDR( Object SupplierBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierBranchID", SqlDbType.Int, 0, SupplierBranchID);
        SqlDataReader reader;
        data.RunProc("StockReport.GetSupplierStockReport",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierStockReport_StockReportDs( Object SupplierBranchID)
    {
            SqlDataReader reader = GetSupplierStockReport_StockReportSDR(  SupplierBranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierStockReportXML_old_StockReportSDR( Object SupplierBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierBranchID", SqlDbType.Int, 0, SupplierBranchID);
        SqlDataReader reader;
        data.RunProc("StockReport.GetSupplierStockReportXML_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierStockReportXML_old_StockReportDs( Object SupplierBranchID)
    {
            SqlDataReader reader = GetSupplierStockReportXML_old_StockReportSDR(  SupplierBranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
}
