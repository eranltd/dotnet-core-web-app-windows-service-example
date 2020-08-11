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
//Functions for Xnet schema
//--------------------------------------------------------------------------------
    public void DeleteOperatingHour_Xnet( Object OperatingHourID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OperatingHourID", SqlDbType.Int, 0, OperatingHourID);
        data.RunProc("Xnet.DeleteOperatingHour",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetDiamond_XnetSDR( Object DocumentID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DocumentID", SqlDbType.Int, 0, DocumentID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetDiamond",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond_XnetDs( Object DocumentID)
    {
            SqlDataReader reader = GetDiamond_XnetSDR(  DocumentID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondByID_XnetSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetDiamondByID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondByID_XnetDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondByID_XnetSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetInitData_XnetSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Xnet.GetInitData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInitData_XnetDs()
    {
            SqlDataReader reader = GetInitData_XnetSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetInProcess_XnetSDR( Object ContactID, Object reloadAll)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@reloadAll", SqlDbType.Bit, 0, reloadAll);
        SqlDataReader reader;
        data.RunProc("Xnet.GetInProcess",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInProcess_XnetDs( Object ContactID, Object reloadAll)
    {
            SqlDataReader reader = GetInProcess_XnetSDR(  ContactID,  reloadAll);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetInventory_XnetSDR( Object ContactID, Object StoneStatus, Object LotID, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorFrom, Object ColorTo, Object ClarityFrom, Object ClarityTo, Object Exclusive, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@StoneStatus", SqlDbType.NVarChar, 50, StoneStatus);
		pl.Add("@LotID", SqlDbType.NVarChar, 50, LotID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@CaratFrom", SqlDbType.Decimal, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Decimal, 0, CaratTo);
		pl.Add("@ColorFrom", SqlDbType.Int, 0, ColorFrom);
		pl.Add("@ColorTo", SqlDbType.Int, 0, ColorTo);
		pl.Add("@ClarityFrom", SqlDbType.Int, 0, ClarityFrom);
		pl.Add("@ClarityTo", SqlDbType.Int, 0, ClarityTo);
		pl.Add("@Exclusive", SqlDbType.Bit, 0, Exclusive);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("Xnet.GetInventory",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInventory_XnetDs( Object ContactID, Object StoneStatus, Object LotID, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorFrom, Object ColorTo, Object ClarityFrom, Object ClarityTo, Object Exclusive, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetInventory_XnetSDR(  ContactID,  StoneStatus,  LotID,  ShapeID,  CaratFrom,  CaratTo,  ColorFrom,  ColorTo,  ClarityFrom,  ClarityTo,  Exclusive,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetLastOperatingDay_XnetSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetLastOperatingDay",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetLastOperatingDay_XnetDs( Object BranchID)
    {
            SqlDataReader reader = GetLastOperatingDay_XnetSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetLastUploadTime_XnetSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetLastUploadTime",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetLastUploadTime_XnetDs( Object BranchID)
    {
            SqlDataReader reader = GetLastUploadTime_XnetSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOperatingHours_XnetSDR( Object BranchID, Object OperatingHourID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@OperatingHourID", SqlDbType.Int, 0, OperatingHourID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetOperatingHours",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOperatingHours_XnetDs( Object BranchID, Object OperatingHourID)
    {
            SqlDataReader reader = GetOperatingHours_XnetSDR(  BranchID,  OperatingHourID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRequests_XnetSDR( Object ContactID, Object reloadAll)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@reloadAll", SqlDbType.Bit, 0, reloadAll);
        SqlDataReader reader;
        data.RunProc("Xnet.GetRequests",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRequests_XnetDs( Object ContactID, Object reloadAll)
    {
            SqlDataReader reader = GetRequests_XnetSDR(  ContactID,  reloadAll);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSales_XnetSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetSales",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSales_XnetDs( Object ContactID)
    {
            SqlDataReader reader = GetSales_XnetSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSalesStatistics_XnetSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("Xnet.GetSalesStatistics",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSalesStatistics_XnetDs( Object ContactID)
    {
            SqlDataReader reader = GetSalesStatistics_XnetSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShapeColorClarity_XnetSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Xnet.GetShapeColorClarity",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShapeColorClarity_XnetDs()
    {
            SqlDataReader reader = GetShapeColorClarity_XnetSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetSupplierOrderDetailsXML_Xnet( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        XmlReader reader;
        data.RunProc("Xnet.GetSupplierOrderDetailsXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetUserInfo_XnetSDR( Object UserName, Object HashPassword)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.VarChar, 50, UserName);
		pl.Add("@HashPassword", SqlDbType.VarChar, 256, HashPassword);
        SqlDataReader reader;
        data.RunProc("Xnet.GetUserInfo",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserInfo_XnetDs( Object UserName, Object HashPassword)
    {
            SqlDataReader reader = GetUserInfo_XnetSDR(  UserName,  HashPassword);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string SaveOperatingHour_Xnet( Object BranchID, Object Date, Object StartTime, Object EndTime, Object OperatingHourID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Date", SqlDbType.SmallDateTime, 0, Date);
		pl.Add("@StartTime", SqlDbType.Int, 0, StartTime);
		pl.Add("@EndTime", SqlDbType.Int, 0, EndTime);
		pl.Add("@OperatingHourID", SqlDbType.Int, 0, OperatingHourID);
        
        string id = data.ExecuteScalar("Xnet.SaveOperatingHour",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveOperatingHours_Xnet( Object BranchID, Object Date, Object StartTime, Object EndTime, Object OperatingHourID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Date", SqlDbType.SmallDateTime, 0, Date);
		pl.Add("@StartTime", SqlDbType.Int, 0, StartTime);
		pl.Add("@EndTime", SqlDbType.Int, 0, EndTime);
		pl.Add("@OperatingHourID", SqlDbType.Int, 0, OperatingHourID);
        
        string id = data.ExecuteScalar("Xnet.SaveOperatingHours",pl);
        
        data.Close();
        return id;
    }
    
}
