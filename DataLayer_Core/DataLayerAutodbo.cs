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
//Functions for dbo schema
//--------------------------------------------------------------------------------
    public void DBA_USP_UpdateJSON_dbo()
    {
        ParamList pl = new ParamList();
        data.RunProc("dbo.DBA_USP_UpdateJSON",pl);
        
        data.Close();        
    }
    
    public void GET_SP_INSERT_TRACKING_JA_dbo( Object tAffiliateID, Object tBannerID, Object CategoryID, Object tPage, Object tReferrer, Object tIP, Object sID)
    {
        ParamList pl = new ParamList();
		pl.Add("@tAffiliateID", SqlDbType.Int, 0, tAffiliateID);
		pl.Add("@tBannerID", SqlDbType.Int, 0, tBannerID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@tPage", SqlDbType.VarChar, 1000, tPage);
		pl.Add("@tReferrer", SqlDbType.VarChar, 1000, tReferrer);
		pl.Add("@tIP", SqlDbType.VarChar, 100, tIP);
		pl.Add("@sID", SqlDbType.VarChar, 500, sID);
        data.RunProc("dbo.GET_SP_INSERT_TRACKING_JA",pl);
        
        data.Close();        
    }
    
    public string SaveEventLog_dbo( Object EventLogID, Object ServiceID, Object Event, Object Status, Object Date, Object Notes)
    {
        ParamList pl = new ParamList();
		pl.Add("@EventLogID", SqlDbType.Int, 0, EventLogID);
		pl.Add("@ServiceID", SqlDbType.Int, 0, ServiceID);
		pl.Add("@Event", SqlDbType.NVarChar, 50, Event);
		pl.Add("@Status", SqlDbType.NVarChar, 50, Status);
		pl.Add("@Date", SqlDbType.DateTime, 0, Date);
		pl.Add("@Notes", SqlDbType.NVarChar, 0, Notes);
        
        string id = data.ExecuteScalar("dbo.SaveEventLog",pl);
        
        data.Close();
        return id;
    }
    
    public void TestKayView_dbo()
    {
        ParamList pl = new ParamList();
        data.RunProc("dbo.TestKayView",pl);
        
        data.Close();        
    }
    
}
