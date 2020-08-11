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
//Functions for R2D2 schema
//--------------------------------------------------------------------------------
    public void BuildDailyStockStats_R2D2()
    {
        ParamList pl = new ParamList();
        data.RunProc("R2D2.BuildDailyStockStats",pl);
        
        data.Close();        
    }
    
    public void ClearComletedUpdateDiamondTaskRequests_old_R2D2()
    {
        ParamList pl = new ParamList();
        data.RunProc("R2D2.ClearComletedUpdateDiamondTaskRequests_old",pl);
        
        data.Close();        
    }
    
    public void ClearCompletedUpdateDiamondTaskRequests_R2D2()
    {
        ParamList pl = new ParamList();
        data.RunProc("R2D2.ClearCompletedUpdateDiamondTaskRequests",pl);
        
        data.Close();        
    }
    
    public void DeleteTaskRequest_R2D2( Object TaskRequestID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TaskRequestID", SqlDbType.Int, 0, TaskRequestID);
        data.RunProc("R2D2.DeleteTaskRequest",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetAuthenticateUser_R2D2SDR( Object UserName, Object Password, Object SoftwareName)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.NVarChar, 50, UserName);
		pl.Add("@Password", SqlDbType.NVarChar, 50, Password);
		pl.Add("@SoftwareName", SqlDbType.NVarChar, 50, SoftwareName);
        SqlDataReader reader;
        data.RunProc("R2D2.GetAuthenticateUser",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAuthenticateUser_R2D2Ds( Object UserName, Object Password, Object SoftwareName)
    {
            SqlDataReader reader = GetAuthenticateUser_R2D2SDR(  UserName,  Password,  SoftwareName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondsByBranchID_R2D2SDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("R2D2.GetDiamondsByBranchID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsByBranchID_R2D2Ds()
    {
            SqlDataReader reader = GetDiamondsByBranchID_R2D2SDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetGemstonesBySupplier_R2D2SDR( Object SupplierBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierBranchID", SqlDbType.Int, 0, SupplierBranchID);
        SqlDataReader reader;
        data.RunProc("R2D2.GetGemstonesBySupplier",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGemstonesBySupplier_R2D2Ds( Object SupplierBranchID)
    {
            SqlDataReader reader = GetGemstonesBySupplier_R2D2SDR(  SupplierBranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetNewTaskRequest_R2D2SDR( Object TaskID, Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TaskID", SqlDbType.Int, 0, TaskID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("R2D2.GetNewTaskRequest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetNewTaskRequest_R2D2Ds( Object TaskID, Object BranchID)
    {
            SqlDataReader reader = GetNewTaskRequest_R2D2SDR(  TaskID,  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetProductTaskRequest_R2D2SDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("R2D2.GetProductTaskRequest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetProductTaskRequest_R2D2Ds( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetProductTaskRequest_R2D2SDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetR2D2ErrorLog_R2D2SDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("R2D2.GetR2D2ErrorLog",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetR2D2ErrorLog_R2D2Ds( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetR2D2ErrorLog_R2D2SDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetR2D2TaskRequest_R2D2SDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("R2D2.GetR2D2TaskRequest",pl, out reader, 60);
        
        return reader;
    }
    
    public DataSet GetR2D2TaskRequest_R2D2Ds( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetR2D2TaskRequest_R2D2SDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTask_R2D2SDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("R2D2.GetTask",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTask_R2D2Ds()
    {
            SqlDataReader reader = GetTask_R2D2SDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTaskChartDatasource_R2D2SDR( Object FromDate, Object ToDate, Object Tasks, Object Interval)
    {
        ParamList pl = new ParamList();
		pl.Add("@FromDate", SqlDbType.Date, 0, FromDate);
		pl.Add("@ToDate", SqlDbType.Date, 0, ToDate);
		pl.Add("@Tasks", SqlDbType.NVarChar, 50, Tasks);
		pl.Add("@Interval", SqlDbType.Char, 1, Interval);
        SqlDataReader reader;
        data.RunProc("R2D2.GetTaskChartDatasource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTaskChartDatasource_R2D2Ds( Object FromDate, Object ToDate, Object Tasks, Object Interval)
    {
            SqlDataReader reader = GetTaskChartDatasource_R2D2SDR(  FromDate,  ToDate,  Tasks,  Interval);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUpdatelotTaskRequest_R2D2SDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("R2D2.GetUpdatelotTaskRequest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUpdatelotTaskRequest_R2D2Ds( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetUpdatelotTaskRequest_R2D2SDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string InsertErrorLogMessage_R2D2( Object BranchID, Object RequestID, Object ErrorMessage, Object ErrorSource, Object ErrorStackTrace, Object InnerException, Object Software, Object SoftwareVersion, Object MoreInfo)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@RequestID", SqlDbType.Int, 0, RequestID);
		pl.Add("@ErrorMessage", SqlDbType.NVarChar, 4000, ErrorMessage);
		pl.Add("@ErrorSource", SqlDbType.NVarChar, 4000, ErrorSource);
		pl.Add("@ErrorStackTrace", SqlDbType.NVarChar, 4000, ErrorStackTrace);
		pl.Add("@InnerException", SqlDbType.NVarChar, 4000, InnerException);
		pl.Add("@Software", SqlDbType.NVarChar, 50, Software);
		pl.Add("@SoftwareVersion", SqlDbType.NVarChar, 50, SoftwareVersion);
		pl.Add("@MoreInfo", SqlDbType.NVarChar, 500, MoreInfo);
        
        string id = data.ExecuteScalar("R2D2.InsertErrorLogMessage",pl);
        
        data.Close();
        return id;
    }
    
    public void RemoveDiamondsFromStock_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.RemoveDiamondsFromStock",pl);
        
        data.Close();        
    }
    
    public void RemoveGemstonesFromStock_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.RemoveGemstonesFromStock",pl);
        
        data.Close();        
    }
    
    public void RemovePresetJewelryFromStock_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.RemovePresetJewelryFromStock",pl);
        
        data.Close();        
    }
    
    public void SyncRemovedDiamonds_R2D2( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("R2D2.SyncRemovedDiamonds",pl);
        
        data.Close();        
    }
    
    public void SyncRemovedPresetJewelry_R2D2( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("R2D2.SyncRemovedPresetJewelry",pl);
        
        data.Close();        
    }
    
    public void UpdateCountersForBranch_R2D2( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("R2D2.UpdateCountersForBranch",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondByKeyToOdiroProject_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UpdateDiamondByKeyToOdiroProject",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondsByKeyToR2Net_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UpdateDiamondsByKeyToR2Net",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondToOdiroProject_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UpdateDiamondToOdiroProject",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondToR2Net_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UpdateDiamondToR2Net",pl);
        
        data.Close();        
    }
    
    public void UpdateGemstonesByKeyToOdiroProject_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        data.RunProc("R2D2.UpdateGemstonesByKeyToOdiroProject",pl);
        
        data.Close();        
    }
    
    public void UpdateGemstonesByKeyToR2Net_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UpdateGemstonesByKeyToR2Net",pl);
        
        data.Close();        
    }
    
    public void UpdateR2NetMissingSterlingPrices_R2D2( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("R2D2.UpdateR2NetMissingSterlingPrices",pl);
        
        data.Close();        
    }
    
    public void UpdateR2NetPrices_R2D2( Object DiamondsDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondsDataTable", DiamondsDataTable);
        data.RunProc("R2D2.UpdateR2NetPrices",pl);
        
        data.Close();        
    }
    
    public void UpdateTaskRequest_R2D2( Object RequestID, Object Status, Object Description, Object DataXML, Object TotalElapseTime)
    {
        ParamList pl = new ParamList();
		pl.Add("@RequestID", SqlDbType.Int, 0, RequestID);
		pl.Add("@Status", SqlDbType.NVarChar, 50, Status);
		pl.Add("@Description", SqlDbType.NVarChar, 400, Description);
		pl.Add("@DataXML", SqlDbType.Xml, 0, DataXML);
		pl.Add("@TotalElapseTime", SqlDbType.NVarChar, 50, TotalElapseTime);
        data.RunProc("R2D2.UpdateTaskRequest",pl);
        
        data.Close();        
    }
    
    public void UploadDiamondsToOdiroProject_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UploadDiamondsToOdiroProject",pl);
        
        data.Close();        
    }
    
    public void UploadDiamondsToR2Net_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UploadDiamondsToR2Net",pl);
        
        data.Close();        
    }
    
    public void UploadGemstonesToOdiroProject_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        data.RunProc("R2D2.UploadGemstonesToOdiroProject",pl);
        
        data.Close();        
    }
    
    public void UploadGemstonesToR2Net_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UploadGemstonesToR2Net",pl);
        
        data.Close();        
    }
    
    public void UploadPresetJewelryToR2Net_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UploadPresetJewelryToR2Net",pl);
        
        data.Close();        
    }
    
    public void UploadPresetJewelryToR2Net_oldjf_20170904_R2D2( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("R2D2.UploadPresetJewelryToR2Net_oldjf_20170904",pl);
        
        data.Close();        
    }
    
}
