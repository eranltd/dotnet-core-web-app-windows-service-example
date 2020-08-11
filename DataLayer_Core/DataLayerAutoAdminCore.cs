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
//Functions for AdminCore schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetAccountingModule_AdminCoreSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("AdminCore.GetAccountingModule",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAccountingModule_AdminCoreDs()
    {
            SqlDataReader reader = GetAccountingModule_AdminCoreSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAllBranches_AdminCoreSDR( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@BranchIDList", SqlDbType.NVarChar, 1024, BranchIDList);
		pl.Add("@BranchName", SqlDbType.NVarChar, 50, BranchName);
		pl.Add("@CompanyIDList", SqlDbType.NVarChar, 1024, CompanyIDList);
		pl.Add("@CompanyName", SqlDbType.NVarChar, 50, CompanyName);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetAllBranches",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAllBranches_AdminCoreDs( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
            SqlDataReader reader = GetAllBranches_AdminCoreSDR(  PageSize,  PageNumber,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCustomers_AdminCoreSDR( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@BranchIDList", SqlDbType.NVarChar, 1024, BranchIDList);
		pl.Add("@BranchName", SqlDbType.NVarChar, 50, BranchName);
		pl.Add("@CompanyIDList", SqlDbType.NVarChar, 1024, CompanyIDList);
		pl.Add("@CompanyName", SqlDbType.NVarChar, 50, CompanyName);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetCustomers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCustomers_AdminCoreDs( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
            SqlDataReader reader = GetCustomers_AdminCoreSDR(  PageSize,  PageNumber,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamodListedOn_AdminCoreSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetDiamodListedOn",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamodListedOn_AdminCoreDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamodListedOn_AdminCoreSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondCard_AdminCoreSDR( Object DiamondID, Object ProductID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@ProductID", SqlDbType.Int, 0, ProductID);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetDiamondCard",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondCard_AdminCoreDs( Object DiamondID, Object ProductID)
    {
            SqlDataReader reader = GetDiamondCard_AdminCoreSDR(  DiamondID,  ProductID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondXnetCredentials_AdminCoreSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetDiamondXnetCredentials",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondXnetCredentials_AdminCoreDs( Object BranchID)
    {
            SqlDataReader reader = GetDiamondXnetCredentials_AdminCoreSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetEventLog_AdminCoreSDR( Object Event, Object Status, Object FromDate, Object ToDate)
    {
        ParamList pl = new ParamList();
		pl.Add("@Event", SqlDbType.NVarChar, 50, Event);
		pl.Add("@Status", SqlDbType.NVarChar, 50, Status);
		pl.Add("@FromDate", SqlDbType.DateTime, 0, FromDate);
		pl.Add("@ToDate", SqlDbType.DateTime, 0, ToDate);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetEventLog",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetEventLog_AdminCoreDs( Object Event, Object Status, Object FromDate, Object ToDate)
    {
            SqlDataReader reader = GetEventLog_AdminCoreSDR(  Event,  Status,  FromDate,  ToDate);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetIntegrationLog_AdminCoreSDR( Object Lot, Object DocumentIDList)
    {
        ParamList pl = new ParamList();
		pl.Add("@Lot", SqlDbType.NVarChar, 50, Lot);
		pl.Add("@DocumentIDList", SqlDbType.NVarChar, 1024, DocumentIDList);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetIntegrationLog",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetIntegrationLog_AdminCoreDs( Object Lot, Object DocumentIDList)
    {
            SqlDataReader reader = GetIntegrationLog_AdminCoreSDR(  Lot,  DocumentIDList);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrders_AdminCoreSDR( Object PageSize, Object PageNumber, Object OrderBy, Object Lot, Object OrderID, Object OldOrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@Lot", SqlDbType.NVarChar, 50, Lot);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
		pl.Add("@OldOrderID", SqlDbType.Int, 0, OldOrderID);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetOrders",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrders_AdminCoreDs( Object PageSize, Object PageNumber, Object OrderBy, Object Lot, Object OrderID, Object OldOrderID)
    {
            SqlDataReader reader = GetOrders_AdminCoreSDR(  PageSize,  PageNumber,  OrderBy,  Lot,  OrderID,  OldOrderID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSalesReport_AdminCoreSDR( Object PageSize, Object lot)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@lot", SqlDbType.VarChar, 50, lot);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetSalesReport",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSalesReport_AdminCoreDs( Object PageSize, Object lot)
    {
            SqlDataReader reader = GetSalesReport_AdminCoreSDR(  PageSize,  lot);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void getSampleData_AdminCore( Object PageSize, Object PageNumber, Object OrderBy, Object ProductIDList, Object SupplierBranchID, Object LotList, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorIDFrom, Object ColorIDTo, Object HasPic)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@ProductIDList", SqlDbType.NVarChar, 1024, ProductIDList);
		pl.Add("@SupplierBranchID", SqlDbType.NVarChar, 1024, SupplierBranchID);
		pl.Add("@LotList", SqlDbType.NVarChar, 1024, LotList);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@CaratFrom", SqlDbType.Float, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Float, 0, CaratTo);
		pl.Add("@ColorIDFrom", SqlDbType.Int, 0, ColorIDFrom);
		pl.Add("@ColorIDTo", SqlDbType.Int, 0, ColorIDTo);
		pl.Add("@HasPic", SqlDbType.Bit, 0, HasPic);
        data.RunProc("AdminCore.getSampleData",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetStock_AdminCoreSDR( Object PageSize, Object PageNumber, Object OrderBy, Object ProductIDList, Object DiamondIDList, Object SupplierBranchID, Object LotList, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorIDFrom, Object ColorIDTo, Object HasPic)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@ProductIDList", SqlDbType.NVarChar, 1024, ProductIDList);
		pl.Add("@DiamondIDList", SqlDbType.NVarChar, 1024, DiamondIDList);
		pl.Add("@SupplierBranchID", SqlDbType.NVarChar, 1024, SupplierBranchID);
		pl.Add("@LotList", SqlDbType.NVarChar, 1024, LotList);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@CaratFrom", SqlDbType.Float, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Float, 0, CaratTo);
		pl.Add("@ColorIDFrom", SqlDbType.Int, 0, ColorIDFrom);
		pl.Add("@ColorIDTo", SqlDbType.Int, 0, ColorIDTo);
		pl.Add("@HasPic", SqlDbType.Bit, 0, HasPic);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetStock",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStock_AdminCoreDs( Object PageSize, Object PageNumber, Object OrderBy, Object ProductIDList, Object DiamondIDList, Object SupplierBranchID, Object LotList, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorIDFrom, Object ColorIDTo, Object HasPic)
    {
            SqlDataReader reader = GetStock_AdminCoreSDR(  PageSize,  PageNumber,  OrderBy,  ProductIDList,  DiamondIDList,  SupplierBranchID,  LotList,  ShapeID,  CaratFrom,  CaratTo,  ColorIDFrom,  ColorIDTo,  HasPic);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSuppliers_AdminCoreSDR( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName, Object ShowInhouse)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@BranchIDList", SqlDbType.NVarChar, 1024, BranchIDList);
		pl.Add("@BranchName", SqlDbType.NVarChar, 50, BranchName);
		pl.Add("@CompanyIDList", SqlDbType.NVarChar, 1024, CompanyIDList);
		pl.Add("@CompanyName", SqlDbType.NVarChar, 50, CompanyName);
		pl.Add("@ShowInhouse", SqlDbType.Bit, 0, ShowInhouse);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetSuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSuppliers_AdminCoreDs( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName, Object ShowInhouse)
    {
            SqlDataReader reader = GetSuppliers_AdminCoreSDR(  PageSize,  PageNumber,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName,  ShowInhouse);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTestsResults_AdminCoreSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("AdminCore.GetTestsResults",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTestsResults_AdminCoreDs()
    {
            SqlDataReader reader = GetTestsResults_AdminCoreSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUser_AdminCoreSDR( Object UserName, Object HashPassword, Object IpAddress, Object SessionKey)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.VarChar, 50, UserName);
		pl.Add("@HashPassword", SqlDbType.VarChar, 256, HashPassword);
		pl.Add("@IpAddress", SqlDbType.NVarChar, 15, IpAddress);
		pl.Add("@SessionKey", SqlDbType.UniqueIdentifier, 0, SessionKey);
        SqlDataReader reader;
        data.RunProc("AdminCore.GetUser",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUser_AdminCoreDs( Object UserName, Object HashPassword, Object IpAddress, Object SessionKey)
    {
            SqlDataReader reader = GetUser_AdminCoreSDR(  UserName,  HashPassword,  IpAddress,  SessionKey);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string SaveDiamondListedOn_AdminCore( Object DiamondID, Object IsOnJamesallen, Object IsOnJared, Object IsOnKay)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@IsOnJamesallen", SqlDbType.Bit, 0, IsOnJamesallen);
		pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
		pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
        
        string id = data.ExecuteScalar("AdminCore.SaveDiamondListedOn",pl);
        
        data.Close();
        return id;
    }
    
}
