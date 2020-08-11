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
//Functions for R2D2Dashboard schema
//--------------------------------------------------------------------------------
    public void FillTaskStatisticsTable_R2D2Dashboard( Object TaskID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@TaskID", SqlDbType.Int, 0, TaskID);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        data.RunProc("R2D2Dashboard.FillTaskStatisticsTable",pl);
        
        data.Close();        
    }
    
    public String GetErrorDetailsJSON_R2D2DashboardJSON( Object ErrorMessage)
    {
        ParamList pl = new ParamList();
		pl.Add("@ErrorMessage", SqlDbType.NVarChar, 4000, ErrorMessage);
        
        return data.GetJSON("R2D2Dashboard.GetErrorDetailsJSON",pl);        
    }
    
    public String GetErrorLogDetailByIDJSON_R2D2DashboardJSON( Object ErrorLogID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ErrorLogID", SqlDbType.Int, 0, ErrorLogID);
        
        return data.GetJSON("R2D2Dashboard.GetErrorLogDetailByIDJSON",pl);        
    }
    
    public String GetRecentErrorsByTaskDataSourceJSON_R2D2DashboardJSON( Object TaskID, Object Date)
    {
        ParamList pl = new ParamList();
		pl.Add("@TaskID", SqlDbType.Int, 0, TaskID);
		pl.Add("@Date", SqlDbType.NVarChar, 50, Date);
        
        return data.GetJSON("R2D2Dashboard.GetRecentErrorsByTaskDataSourceJSON",pl);        
    }
    
    public String GetRecentErrorsTableDataSourceJSON_R2D2DashboardJSON()
    {
        ParamList pl = new ParamList();
        
        return data.GetJSON("R2D2Dashboard.GetRecentErrorsTableDataSourceJSON",pl);        
    }
    
    public String GetTaskChartDatasourceJSON_R2D2DashboardJSON( Object TaskIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@TaskIDs", SqlDbType.NVarChar, 50, TaskIDs);
        
        return data.GetJSON("R2D2Dashboard.GetTaskChartDatasourceJSON",pl);        
    }
    
    public String GetTaskListDataSourceJSON_R2D2DashboardJSON()
    {
        ParamList pl = new ParamList();
        
        return data.GetJSON("R2D2Dashboard.GetTaskListDataSourceJSON",pl);        
    }
    
    public String GetTaskStatisticsJSON_R2D2DashboardJSON( Object FromDate, Object ToDate, Object TaskID, Object Interval)
    {
        ParamList pl = new ParamList();
		pl.Add("@FromDate", SqlDbType.Date, 0, FromDate);
		pl.Add("@ToDate", SqlDbType.Date, 0, ToDate);
		pl.Add("@TaskID", SqlDbType.Int, 0, TaskID);
		pl.Add("@Interval", SqlDbType.Int, 0, Interval);
        
        return data.GetJSON("R2D2Dashboard.GetTaskStatisticsJSON",pl);        
    }
    
    public String GetTopBranchErrorsTableDataSourceJSON_R2D2DashboardJSON( Object IntervalID)
    {
        ParamList pl = new ParamList();
		pl.Add("@IntervalID", SqlDbType.Int, 0, IntervalID);
        
        return data.GetJSON("R2D2Dashboard.GetTopBranchErrorsTableDataSourceJSON",pl);        
    }
    
    public String GetTopErrorsTableDataSourceJSON_R2D2DashboardJSON( Object IntervalID)
    {
        ParamList pl = new ParamList();
		pl.Add("@IntervalID", SqlDbType.Int, 0, IntervalID);
        
        return data.GetJSON("R2D2Dashboard.GetTopErrorsTableDataSourceJSON",pl);        
    }
    
}
