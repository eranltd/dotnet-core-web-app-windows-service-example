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
//Functions for Monitor schema
//--------------------------------------------------------------------------------
    public void CorrectDiamondCustomers_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectDiamondCustomers",pl);
        
        data.Close();        
    }
    
    public void CorrectDiamondImages_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectDiamondImages",pl);
        
        data.Close();        
    }
    
    public void CorrectDiamondPrices_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectDiamondPrices",pl);
        
        data.Close();        
    }
    
    public void CorrectDiamondStatusID_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectDiamondStatusID",pl);
        
        data.Close();        
    }
    
    public void CorrectDiamondSupplier_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectDiamondSupplier",pl);
        
        data.Close();        
    }
    
    public void CorrectJewelryCustomers_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectJewelryCustomers",pl);
        
        data.Close();        
    }
    
    public void CorrectJewelryFields_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectJewelryFields",pl);
        
        data.Close();        
    }
    
    public void CorrectJewelrySupplier_Monitor( Object ValidationResultXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ValidationResultXML", SqlDbType.Xml, 0, ValidationResultXML);
        data.RunProc("Monitor.CorrectJewelrySupplier",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetMonitorServices_MonitorSDR( Object GetAllServices)
    {
        ParamList pl = new ParamList();
		pl.Add("@GetAllServices", SqlDbType.Bit, 0, GetAllServices);
        SqlDataReader reader;
        data.RunProc("Monitor.GetMonitorServices",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMonitorServices_MonitorDs( Object GetAllServices)
    {
            SqlDataReader reader = GetMonitorServices_MonitorSDR(  GetAllServices);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMonitorServiceStatusDataSource_MonitorSDR( Object NumberOfReports, Object MonitorServiceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@NumberOfReports", SqlDbType.Int, 0, NumberOfReports);
		pl.Add("@MonitorServiceID", SqlDbType.Int, 0, MonitorServiceID);
        SqlDataReader reader;
        data.RunProc("Monitor.GetMonitorServiceStatusDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMonitorServiceStatusDataSource_MonitorDs( Object NumberOfReports, Object MonitorServiceID)
    {
            SqlDataReader reader = GetMonitorServiceStatusDataSource_MonitorSDR(  NumberOfReports,  MonitorServiceID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetReports_MonitorSDR( Object NumberOfReports)
    {
        ParamList pl = new ParamList();
		pl.Add("@NumberOfReports", SqlDbType.Int, 0, NumberOfReports);
        SqlDataReader reader;
        data.RunProc("Monitor.GetReports",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetReports_MonitorDs( Object NumberOfReports)
    {
            SqlDataReader reader = GetReports_MonitorSDR(  NumberOfReports);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetWatchDogData_MonitorSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Monitor.GetWatchDogData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWatchDogData_MonitorDs()
    {
            SqlDataReader reader = GetWatchDogData_MonitorSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string InsertReport_Monitor( Object ResultXML, Object ResultDataXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@ResultXML", SqlDbType.Xml, 0, ResultXML);
		pl.Add("@ResultDataXML", SqlDbType.Xml, 0, ResultDataXML);
        
        string id = data.ExecuteScalar("Monitor.InsertReport",pl);
        
        data.Close();
        return id;
    }
    
    public void RemoveOldReports_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.RemoveOldReports",pl);
        
        data.Close();        
    }
    
    public void SendMissingNewRenders_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.SendMissingNewRenders",pl);
        
        data.Close();        
    }
    
    public void UpdateMonitorService_Monitor( Object MonitorServiceID, Object EmailReportXSL)
    {
        ParamList pl = new ParamList();
		pl.Add("@MonitorServiceID", SqlDbType.Int, 0, MonitorServiceID);
		pl.Add("@EmailReportXSL", SqlDbType.Xml, 0, EmailReportXSL);
        data.RunProc("Monitor.UpdateMonitorService",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondCustomers_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondCustomers",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondFieldsR2NetOdiroProject_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondFieldsR2NetOdiroProject",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondFieldsR2NetOdiroProject_test_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondFieldsR2NetOdiroProject_test",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondImages_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondImages",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondPrices_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondPrices",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondPrices_New_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondPrices_New",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondPrices_OLD_20140218_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondPrices_OLD_20140218",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondStatusID_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondStatusID",pl);
        
        data.Close();        
    }
    
    public void ValidateDiamondSuppliers_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateDiamondSuppliers",pl);
        
        data.Close();        
    }
    
    public void ValidateJamesAllenDiamondAlert_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateJamesAllenDiamondAlert",pl);
        
        data.Close();        
    }
    
    public void ValidateJewelryCustomers_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateJewelryCustomers",pl);
        
        data.Close();        
    }
    
    public void ValidateJewelryFields_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateJewelryFields",pl);
        
        data.Close();        
    }
    
    public void ValidateJewelrySuppliers_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateJewelrySuppliers",pl);
        
        data.Close();        
    }
    
    public void ValidateKayDiamondsStockAmount_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateKayDiamondsStockAmount",pl);
        
        data.Close();        
    }
    
    public void ValidateKayFeed_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateKayFeed",pl);
        
        data.Close();        
    }
    
    public void ValidateKayR2SearchSEDiamond_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateKayR2SearchSEDiamond",pl);
        
        data.Close();        
    }
    
    public void ValidateKayRecommendedInventory_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateKayRecommendedInventory",pl);
        
        data.Close();        
    }
    
    public void ValidateR2NetJewelryStockAmount_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateR2NetJewelryStockAmount",pl);
        
        data.Close();        
    }
    
    public void ValidateSqlServer_Monitor()
    {
        ParamList pl = new ParamList();
        data.RunProc("Monitor.ValidateSqlServer",pl);
        
        data.Close();        
    }
    
}
