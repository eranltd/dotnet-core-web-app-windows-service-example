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
//Functions for Helper schema
//--------------------------------------------------------------------------------
    public void ChangeJewelCategory( Object NewCategoryID, Object OldCategoryID, Object WithChildren)
    {
        ParamList pl = new ParamList();
		pl.Add("@NewCategoryID", SqlDbType.Int, 0, NewCategoryID);
		pl.Add("@OldCategoryID", SqlDbType.Int, 0, OldCategoryID);
		pl.Add("@WithChildren", SqlDbType.Bit, 0, WithChildren);
        data.RunProc("Helper.ChangeJewelCategory",pl);
        
        data.Close();        
    }
    
    public void CopyCategory2Page( Object CategoryID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
        data.RunProc("Helper.CopyCategory2Page",pl);
        
        data.Close();        
    }
    
    public void DeleteBranch( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("Helper.DeleteBranch",pl);
        
        data.Close();        
    }
    
    public void DeleteJABetaCustomer( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        data.RunProc("Helper.DeleteJABetaCustomer",pl);
        
        data.Close();        
    }
    
    public void DeleteJewel( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        data.RunProc("Helper.DeleteJewel",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetColorClarityShapeTableSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Helper.GetColorClarityShapeTable",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetColorClarityShapeTableDs()
    {
            SqlDataReader reader = GetColorClarityShapeTableSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetEmailNetworkCredentialSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Helper.GetEmailNetworkCredential",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetEmailNetworkCredentialDs()
    {
            SqlDataReader reader = GetEmailNetworkCredentialSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelImagesToConvertSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Helper.GetJewelImagesToConvert",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelImagesToConvertDs()
    {
            SqlDataReader reader = GetJewelImagesToConvertSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShapeColorClarietCaratFromToTableSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Helper.GetShapeColorClarietCaratFromToTable",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShapeColorClarietCaratFromToTableDs()
    {
            SqlDataReader reader = GetShapeColorClarietCaratFromToTableSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetStoreSuppliersSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Helper.GetStoreSuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStoreSuppliersDs()
    {
            SqlDataReader reader = GetStoreSuppliersSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUserParametersSDR( Object ContactID,out Object BranchID,out Object CompanyID,out Object FullName)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.AddOut("@BranchID", SqlDbType.Int, 0);
		pl.AddOut("@CompanyID", SqlDbType.Int, 0);
		pl.AddOut("@FullName", SqlDbType.NVarChar, 100);
        SqlDataReader reader;
        data.RunProc("Helper.GetUserParameters",pl, out reader);
        
		BranchID= pl.GetParamValue("@BranchID");
		CompanyID= pl.GetParamValue("@CompanyID");
		FullName= pl.GetParamValue("@FullName");
        return reader;
    }
    
    public DataSet GetUserParametersDs( Object ContactID,out Object BranchID,out Object CompanyID,out Object FullName)
    {
            SqlDataReader reader = GetUserParametersSDR(  ContactID,out  BranchID,out  CompanyID,out  FullName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void KillConnectionsHost( Object hostname)
    {
        ParamList pl = new ParamList();
		pl.Add("@hostname", SqlDbType.VarChar, 0, hostname);
        data.RunProc("Helper.KillConnectionsHost",pl);
        
        data.Close();        
    }
    
    public void MatchingPair()
    {
        ParamList pl = new ParamList();
        data.RunProc("Helper.MatchingPair",pl);
        
        data.Close();        
    }
    
    public void RemoveJACustomers()
    {
        ParamList pl = new ParamList();
        data.RunProc("Helper.RemoveJACustomers",pl);
        
        data.Close();        
    }
    
    public void RemoveSupplierFromUploadService( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("Helper.RemoveSupplierFromUploadService",pl);
        
        data.Close();        
    }
    
    public void TruncateBranch( Object Confirm)
    {
        ParamList pl = new ParamList();
		pl.Add("@Confirm", SqlDbType.Bit, 0, Confirm);
        data.RunProc("Helper.TruncateBranch",pl);
        
        data.Close();        
    }
    
    public void TruncateDatabaseDynamicData( Object Confirmation)
    {
        ParamList pl = new ParamList();
		pl.Add("@Confirmation", SqlDbType.Bit, 0, Confirmation);
        data.RunProc("Helper.TruncateDatabaseDynamicData",pl);
        
        data.Close();        
    }
    
    public void TruncateDiamonds( Object Confirm)
    {
        ParamList pl = new ParamList();
		pl.Add("@Confirm", SqlDbType.Bit, 0, Confirm);
        data.RunProc("Helper.TruncateDiamonds",pl);
        
        data.Close();        
    }
    
    public void TruncateJewelry( Object Confirm)
    {
        ParamList pl = new ParamList();
		pl.Add("@Confirm", SqlDbType.Bit, 0, Confirm);
        data.RunProc("Helper.TruncateJewelry",pl);
        
        data.Close();        
    }
    
    public void TruncateProducts( Object Confirm)
    {
        ParamList pl = new ParamList();
		pl.Add("@Confirm", SqlDbType.Bit, 0, Confirm);
        data.RunProc("Helper.TruncateProducts",pl);
        
        data.Close();        
    }
    
}
