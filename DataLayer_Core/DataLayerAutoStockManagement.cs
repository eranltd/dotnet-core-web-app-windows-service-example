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
//Functions for StockManagement schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetActiveSuppliers_StockManagementSDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetActiveSuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetActiveSuppliers_StockManagementDs( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetActiveSuppliers_StockManagementSDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAddNewActiveSupplier_StockManagementSDR( Object OldBranchID, Object TemplateTypeID, Object SegomaBranchID, Object CreateTemplate, Object APIEnabled, Object FTPEnabled)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldBranchID", SqlDbType.Int, 0, OldBranchID);
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
		pl.Add("@SegomaBranchID", SqlDbType.NVarChar, 50, SegomaBranchID);
		pl.Add("@CreateTemplate", SqlDbType.Bit, 0, CreateTemplate);
		pl.Add("@APIEnabled", SqlDbType.Bit, 0, APIEnabled);
		pl.Add("@FTPEnabled", SqlDbType.Bit, 0, FTPEnabled);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetAddNewActiveSupplier",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAddNewActiveSupplier_StockManagementDs( Object OldBranchID, Object TemplateTypeID, Object SegomaBranchID, Object CreateTemplate, Object APIEnabled, Object FTPEnabled)
    {
            SqlDataReader reader = GetAddNewActiveSupplier_StockManagementSDR(  OldBranchID,  TemplateTypeID,  SegomaBranchID,  CreateTemplate,  APIEnabled,  FTPEnabled);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchTemplate_StockManagementSDR( Object BranchTemplateID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetBranchTemplate",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchTemplate_StockManagementDs( Object BranchTemplateID)
    {
            SqlDataReader reader = GetBranchTemplate_StockManagementSDR(  BranchTemplateID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchTemplates_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetBranchTemplates",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchTemplates_StockManagementDs()
    {
            SqlDataReader reader = GetBranchTemplates_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDataParserDataSource_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetDataParserDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDataParserDataSource_StockManagementDs()
    {
            SqlDataReader reader = GetDataParserDataSource_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDefaultTemplateByType_StockManagementSDR( Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetDefaultTemplateByType",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDefaultTemplateByType_StockManagementDs( Object TemplateTypeID)
    {
            SqlDataReader reader = GetDefaultTemplateByType_StockManagementSDR(  TemplateTypeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFTPRootDir_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetFTPRootDir",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFTPRootDir_StockManagementDs()
    {
            SqlDataReader reader = GetFTPRootDir_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetIndiaSuppliers_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetIndiaSuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetIndiaSuppliers_StockManagementDs()
    {
            SqlDataReader reader = GetIndiaSuppliers_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetStockUploadServiceDataSource_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetStockUploadServiceDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStockUploadServiceDataSource_StockManagementDs()
    {
            SqlDataReader reader = GetStockUploadServiceDataSource_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierCard_StockManagementSDR( Object BranchTemplateID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetSupplierCard",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierCard_StockManagementDs( Object BranchTemplateID)
    {
            SqlDataReader reader = GetSupplierCard_StockManagementSDR(  BranchTemplateID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSuppliers_StockManagementSDR( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName, Object ShowInhouse, Object DEBUG, Object ItemsCountSanpshot)
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
		pl.Add("@DEBUG", SqlDbType.Int, 0, DEBUG);
		pl.Add("@ItemsCountSanpshot", SqlDbType.Bit, 0, ItemsCountSanpshot);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetSuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSuppliers_StockManagementDs( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName, Object ShowInhouse, Object DEBUG, Object ItemsCountSanpshot)
    {
            SqlDataReader reader = GetSuppliers_StockManagementSDR(  PageSize,  PageNumber,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName,  ShowInhouse,  DEBUG,  ItemsCountSanpshot);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierTargetDir_StockManagementSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetSupplierTargetDir",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierTargetDir_StockManagementDs( Object BranchID)
    {
            SqlDataReader reader = GetSupplierTargetDir_StockManagementSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetTemplateByIDXML_StockManagement( Object TemplateID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateID", SqlDbType.Int, 0, TemplateID);
        XmlReader reader;
        data.RunProc("StockManagement.GetTemplateByIDXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetTemplateFields_StockManagementSDR( Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        SqlDataReader reader;
        data.RunProc("StockManagement.GetTemplateFields",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTemplateFields_StockManagementDs( Object TemplateTypeID)
    {
            SqlDataReader reader = GetTemplateFields_StockManagementSDR(  TemplateTypeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTemplateList_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetTemplateList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTemplateList_StockManagementDs()
    {
            SqlDataReader reader = GetTemplateList_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTemplates_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetTemplates",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTemplates_StockManagementDs()
    {
            SqlDataReader reader = GetTemplates_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTemplateTypes_StockManagementSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockManagement.GetTemplateTypes",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTemplateTypes_StockManagementDs()
    {
            SqlDataReader reader = GetTemplateTypes_StockManagementSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string InsertNewDiamondSupplier_StockManagement( Object OldBranchID, Object BranchID, Object LotPrefix, Object IsExclusive, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldBranchID", SqlDbType.Int, 0, OldBranchID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@LotPrefix", SqlDbType.NVarChar, 50, LotPrefix);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        
        string id = data.ExecuteScalar("StockManagement.InsertNewDiamondSupplier",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertReport_StockManagement( Object ReportTypeID, Object Report)
    {
        ParamList pl = new ParamList();
		pl.Add("@ReportTypeID", SqlDbType.Int, 0, ReportTypeID);
		pl.Add("@Report", SqlDbType.NVarChar, 500, Report);
        
        string id = data.ExecuteScalar("StockManagement.InsertReport",pl);
        
        data.Close();
        return id;
    }
    
    public void RefreshFeed_StockManagement( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("StockManagement.RefreshFeed",pl);
        
        data.Close();        
    }
    
    public void RemoveUploadDiamondDataOldVersion_StockManagement()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockManagement.RemoveUploadDiamondDataOldVersion",pl);
        
        data.Close();        
    }
    
    public string SaveBranchTemplate_StockManagement( Object BranchTemplateID, Object TemplateID, Object Name, Object FileName)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
		pl.Add("@TemplateID", SqlDbType.Int, 0, TemplateID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@FileName", SqlDbType.NVarChar, 50, FileName);
        
        string id = data.ExecuteScalar("StockManagement.SaveBranchTemplate",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveBranchTemplateType_StockManagement( Object BranchTemplateID, Object TemplateTypeID, Object Name, Object FileName)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@FileName", SqlDbType.NVarChar, 50, FileName);
        
        string id = data.ExecuteScalar("StockManagement.SaveBranchTemplateType",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveSupplierCard_StockManagement( Object BranchTemplateID, Object IsOnJamesAllen, Object IsOnJared, Object IsOnKay, Object SegomaBranchID, Object Notes, Object Enabled, Object APIEnabled, Object FTPEnabled, Object Username, Object Password, Object TrueHeartAuthorized)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
		pl.Add("@IsOnJamesAllen", SqlDbType.Bit, 0, IsOnJamesAllen);
		pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
		pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
		pl.Add("@SegomaBranchID", SqlDbType.NVarChar, 50, SegomaBranchID);
		pl.Add("@Notes", SqlDbType.NVarChar, 1000, Notes);
		pl.Add("@Enabled", SqlDbType.Bit, 0, Enabled);
		pl.Add("@APIEnabled", SqlDbType.Bit, 0, APIEnabled);
		pl.Add("@FTPEnabled", SqlDbType.Bit, 0, FTPEnabled);
		pl.Add("@Username", SqlDbType.NVarChar, 50, Username);
		pl.Add("@Password", SqlDbType.NVarChar, 50, Password);
		pl.Add("@TrueHeartAuthorized", SqlDbType.Bit, 0, TrueHeartAuthorized);
        
        string id = data.ExecuteScalar("StockManagement.SaveSupplierCard",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveTemplate_StockManagement( Object TemplateID, Object Data)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateID", SqlDbType.NVarChar, 50, TemplateID);
		pl.Add("@Data", SqlDbType.Xml, 0, Data);
        
        string id = data.ExecuteScalar("StockManagement.SaveTemplate",pl);
        
        data.Close();
        return id;
    }
    
    public void UpdateItemCount3DHoldOrderSold_StockManagement( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("StockManagement.UpdateItemCount3DHoldOrderSold",pl);
        
        data.Close();        
    }
    
    public void UpdateItemCount3DHoldOrderSoldCommit_StockManagement( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("StockManagement.UpdateItemCount3DHoldOrderSoldCommit",pl);
        
        data.Close();        
    }
    
    public void UpdateItemCounterCertificates_StockManagement()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockManagement.UpdateItemCounterCertificates",pl);
        
        data.Close();        
    }
    
    public void UpdateItemCountOnJAJaredKay_StockManagement( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("StockManagement.UpdateItemCountOnJAJaredKay",pl);
        
        data.Close();        
    }
    
    public void UpdateItemCountOnJAJaredKayCommit_StockManagement( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("StockManagement.UpdateItemCountOnJAJaredKayCommit",pl);
        
        data.Close();        
    }
    
    public void UpdateRapaportPrices_StockManagement()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockManagement.UpdateRapaportPrices",pl);
        
        data.Close();        
    }
    
    public void UpdateStockDataFileDate_StockManagement( Object BranchID, Object LastUploadTime)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@LastUploadTime", SqlDbType.NVarChar, 50, LastUploadTime);
        data.RunProc("StockManagement.UpdateStockDataFileDate",pl);
        
        data.Close();        
    }
    
}
