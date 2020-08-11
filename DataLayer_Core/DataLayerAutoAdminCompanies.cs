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
//Functions for AdminCompanies schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetBrachTemplate_AdminCompaniesSDR( Object BranchTemplateID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
        SqlDataReader reader;
        data.RunProc("AdminCompanies.GetBrachTemplate",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBrachTemplate_AdminCompaniesDs( Object BranchTemplateID)
    {
            SqlDataReader reader = GetBrachTemplate_AdminCompaniesSDR(  BranchTemplateID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchCard_AdminCompaniesSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("AdminCompanies.GetBranchCard",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchCard_AdminCompaniesDs( Object BranchID)
    {
            SqlDataReader reader = GetBranchCard_AdminCompaniesSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchContacts_AdminCompaniesSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("AdminCompanies.GetBranchContacts",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchContacts_AdminCompaniesDs( Object BranchID)
    {
            SqlDataReader reader = GetBranchContacts_AdminCompaniesSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchData_AdminCompaniesSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("AdminCompanies.GetBranchData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchData_AdminCompaniesDs( Object BranchID)
    {
            SqlDataReader reader = GetBranchData_AdminCompaniesSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetContact_AdminCompaniesSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("AdminCompanies.GetContact",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetContact_AdminCompaniesDs( Object ContactID)
    {
            SqlDataReader reader = GetContact_AdminCompaniesSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJAUsers_AdminCompaniesSDR( Object PageSize, Object PageNumber, Object OrderBy, Object Text, Object Username)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@Text", SqlDbType.NVarChar, 50, Text);
		pl.Add("@Username", SqlDbType.NVarChar, 50, Username);
        SqlDataReader reader;
        data.RunProc("AdminCompanies.GetJAUsers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJAUsers_AdminCompaniesDs( Object PageSize, Object PageNumber, Object OrderBy, Object Text, Object Username)
    {
            SqlDataReader reader = GetJAUsers_AdminCompaniesSDR(  PageSize,  PageNumber,  OrderBy,  Text,  Username);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
   
    
    
    
    public string SaveB2BReference_AdminCompanies( Object BranchID, Object ReferToBranchID, Object AsB2BReferenceTypeID, Object HasData, Object Terms, Object Discount, Object Credit, Object MarkUp, Object PriceTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@ReferToBranchID", SqlDbType.Int, 0, ReferToBranchID);
		pl.Add("@AsB2BReferenceTypeID", SqlDbType.Int, 0, AsB2BReferenceTypeID);
		pl.Add("@HasData", SqlDbType.Bit, 0, HasData);
		pl.Add("@Terms", SqlDbType.Int, 0, Terms);
		pl.Add("@Discount", SqlDbType.Float, 0, Discount);
		pl.Add("@Credit", SqlDbType.Int, 0, Credit);
		pl.Add("@MarkUp", SqlDbType.Float, 0, MarkUp);
		pl.Add("@PriceTypeID", SqlDbType.Int, 0, PriceTypeID);
        
        string id = data.ExecuteScalar("AdminCompanies.SaveB2BReference",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveBrachTemplate_AdminCompanies( Object BranchTemplateID, Object TemplateID, Object Name, Object FileName)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
		pl.Add("@TemplateID", SqlDbType.Int, 0, TemplateID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@FileName", SqlDbType.NVarChar, 50, FileName);
        
        string id = data.ExecuteScalar("AdminCompanies.SaveBrachTemplate",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveBranchCard_AdminCompanies( Object BranchID, Object CompanyID, Object CompanyName, Object BranchName, Object ClientTypeID, Object Phone, Object Fax, Object Notes, Object AddressID, Object Street, Object City, Object StateProvinceID, Object CountryRegionCode, Object ZipCode, Object IsDiamondSupplier, Object IsJewelSupplier, Object SupplierTerms, Object SupplierDiscount, Object SupplierCredit, Object SupplierMarkUp, Object BranchTemplateID, Object TemplateID, Object IsCustomer, Object CastomerTerms, Object CastomerDiscount, Object CastomerCredit, Object CastomerMarkUp, Object PriceTypeID, Object OldBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@CompanyName", SqlDbType.NVarChar, 50, CompanyName);
		pl.Add("@BranchName", SqlDbType.NVarChar, 50, BranchName);
		pl.Add("@ClientTypeID", SqlDbType.Int, 0, ClientTypeID);
		pl.Add("@Phone", SqlDbType.NVarChar, 25, Phone);
		pl.Add("@Fax", SqlDbType.NVarChar, 25, Fax);
		pl.Add("@Notes", SqlDbType.NVarChar, 0, Notes);
		pl.Add("@AddressID", SqlDbType.Int, 0, AddressID);
		pl.Add("@Street", SqlDbType.NVarChar, 120, Street);
		pl.Add("@City", SqlDbType.NVarChar, 30, City);
		pl.Add("@StateProvinceID", SqlDbType.Int, 0, StateProvinceID);
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 3, CountryRegionCode);
		pl.Add("@ZipCode", SqlDbType.NVarChar, 15, ZipCode);
		pl.Add("@IsDiamondSupplier", SqlDbType.Bit, 0, IsDiamondSupplier);
		pl.Add("@IsJewelSupplier", SqlDbType.Bit, 0, IsJewelSupplier);
		pl.Add("@SupplierTerms", SqlDbType.Int, 0, SupplierTerms);
		pl.Add("@SupplierDiscount", SqlDbType.Float, 0, SupplierDiscount);
		pl.Add("@SupplierCredit", SqlDbType.Int, 0, SupplierCredit);
		pl.Add("@SupplierMarkUp", SqlDbType.Float, 0, SupplierMarkUp);
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
		pl.Add("@TemplateID", SqlDbType.Int, 0, TemplateID);
		pl.Add("@IsCustomer", SqlDbType.Bit, 0, IsCustomer);
		pl.Add("@CastomerTerms", SqlDbType.Int, 0, CastomerTerms);
		pl.Add("@CastomerDiscount", SqlDbType.Float, 0, CastomerDiscount);
		pl.Add("@CastomerCredit", SqlDbType.Int, 0, CastomerCredit);
		pl.Add("@CastomerMarkUp", SqlDbType.Float, 0, CastomerMarkUp);
		pl.Add("@PriceTypeID", SqlDbType.Int, 0, PriceTypeID);
		pl.Add("@OldBranchID", SqlDbType.Int, 0, OldBranchID);
        
        string id = data.ExecuteScalar("AdminCompanies.SaveBranchCard",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveContact_AdminCompanies( Object ContactID, Object FirstName, Object MiddleName, Object LastName, Object EmailAddress, Object Phone, Object Mobile, Object Fax, Object Notes, Object Username, Object HashPassword, Object BranchID, Object ContactTypeID, Object OldContacID, Object Roles)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@MiddleName", SqlDbType.NVarChar, 50, MiddleName);
		pl.Add("@LastName", SqlDbType.NVarChar, 50, LastName);
		pl.Add("@EmailAddress", SqlDbType.NVarChar, 256, EmailAddress);
		pl.Add("@Phone", SqlDbType.NVarChar, 25, Phone);
		pl.Add("@Mobile", SqlDbType.NVarChar, 25, Mobile);
		pl.Add("@Fax", SqlDbType.NVarChar, 25, Fax);
		pl.Add("@Notes", SqlDbType.NVarChar, 0, Notes);
		pl.Add("@Username", SqlDbType.NVarChar, 50, Username);
		pl.Add("@HashPassword", SqlDbType.NVarChar, 256, HashPassword);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@ContactTypeID", SqlDbType.Int, 0, ContactTypeID);
		pl.Add("@OldContacID", SqlDbType.Int, 0, OldContacID);
		pl.Add("@Roles", SqlDbType.Xml, 0, Roles);
        
        string id = data.ExecuteScalar("AdminCompanies.SaveContact",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveSupplierCard_AdminCompanies( Object BranchTemplateID, Object IsOnJamesAllen, Object IsOnJared, Object IsOnKay)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
		pl.Add("@IsOnJamesAllen", SqlDbType.Bit, 0, IsOnJamesAllen);
		pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
		pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
        
        string id = data.ExecuteScalar("AdminCompanies.SaveSupplierCard",pl);
        
        data.Close();
        return id;
    }
    
}
