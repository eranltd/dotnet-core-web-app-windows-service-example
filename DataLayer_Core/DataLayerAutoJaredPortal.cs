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
//Functions for JaredPortal schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetAddServiceNote_JaredPortalSDR( Object StoreID, Object InvoiceID, Object Note)
    {
        ParamList pl = new ParamList();
		pl.Add("@StoreID", SqlDbType.Int, 0, StoreID);
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
		pl.Add("@Note", SqlDbType.NVarChar, 1000, Note);
        SqlDataReader reader;
        data.RunProc("JaredPortal.GetAddServiceNote",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAddServiceNote_JaredPortalDs( Object StoreID, Object InvoiceID, Object Note)
    {
            SqlDataReader reader = GetAddServiceNote_JaredPortalSDR(  StoreID,  InvoiceID,  Note);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAuthenticateUser_JaredPortalSDR( Object UserName, Object Pass)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.NVarChar, 50, UserName);
		pl.Add("@Pass", SqlDbType.NVarChar, 50, Pass);
        SqlDataReader reader;
        data.RunProc("JaredPortal.GetAuthenticateUser",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAuthenticateUser_JaredPortalDs( Object UserName, Object Pass)
    {
            SqlDataReader reader = GetAuthenticateUser_JaredPortalSDR(  UserName,  Pass);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    public String GetAuthenticateUser_JaredPortalJSON(Object UserName, Object Pass)
    {
        ParamList pl = new ParamList();
        pl.Add("@UserName", SqlDbType.NVarChar, 50, UserName);
        pl.Add("@Pass", SqlDbType.NVarChar, 50, Pass);

        return data.GetJSON("JaredPortal.GetAuthenticateUser", pl);
    }

    public SqlDataReader GetInvoiceDetails_JaredPortalSDR( Object InvoiceID, Object LastName)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
		pl.Add("@LastName", SqlDbType.NVarChar, 50, LastName);
        SqlDataReader reader;
        data.RunProc("JaredPortal.GetInvoiceDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInvoiceDetails_JaredPortalDs( Object InvoiceID, Object LastName)
    {
            SqlDataReader reader = GetInvoiceDetails_JaredPortalSDR(  InvoiceID,  LastName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public String GetNotesForInvoiceJSON_JaredPortalJSON( Object InvoiceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
        
        return data.GetJSON("JaredPortal.GetNotesForInvoiceJSON",pl);        
    }
    
    public SqlDataReader GetUpdateServiceNote_JaredPortalSDR( Object ServiceNoteID, Object StoreID, Object Note)
    {
        ParamList pl = new ParamList();
		pl.Add("@ServiceNoteID", SqlDbType.Int, 0, ServiceNoteID);
		pl.Add("@StoreID", SqlDbType.Int, 0, StoreID);
		pl.Add("@Note", SqlDbType.NVarChar, 1000, Note);
        SqlDataReader reader;
        data.RunProc("JaredPortal.GetUpdateServiceNote",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUpdateServiceNote_JaredPortalDs( Object ServiceNoteID, Object StoreID, Object Note)
    {
            SqlDataReader reader = GetUpdateServiceNote_JaredPortalSDR(  ServiceNoteID,  StoreID,  Note);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public String GetUpdateServiceNoteJSON_JaredPortalJSON( Object ServiceNoteID, Object StoreID, Object Note)
    {
        ParamList pl = new ParamList();
		pl.Add("@ServiceNoteID", SqlDbType.Int, 0, ServiceNoteID);
		pl.Add("@StoreID", SqlDbType.Int, 0, StoreID);
		pl.Add("@Note", SqlDbType.NVarChar, 1000, Note);
        
        return data.GetJSON("JaredPortal.GetUpdateServiceNoteJSON",pl);        
    }
    public String GetInvoiceDetails_JaredPortalJSON(Object InvoiceID, Object LastName)
    {
        ParamList pl = new ParamList();
        pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
        pl.Add("@LastName", SqlDbType.NVarChar, 50, LastName);

        return data.GetJSON("JaredPortal.GetInvoiceDetails", pl);
    }
}
