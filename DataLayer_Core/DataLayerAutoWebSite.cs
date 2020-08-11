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
//Functions for WebSite schema
//--------------------------------------------------------------------------------
    public void AccountActivation_WebSite( Object contactID, Object email)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
		pl.Add("@email", SqlDbType.NVarChar, 50, email);
        data.RunProc("WebSite.AccountActivation",pl);
        
        data.Close();        
    }
    
    public void AddNewFeedback_WebSite( Object DiamondID, Object Name, Object Comments, Object Email, Object Phone, Object Type)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.BigInt, 0, DiamondID);
		pl.Add("@Name", SqlDbType.VarChar, 200, Name);
		pl.Add("@Comments", SqlDbType.VarChar, 0, Comments);
		pl.Add("@Email", SqlDbType.VarChar, 200, Email);
		pl.Add("@Phone", SqlDbType.VarChar, 50, Phone);
		pl.Add("@Type", SqlDbType.Int, 0, Type);
        data.RunProc("WebSite.AddNewFeedback",pl);
        
        data.Close();        
    }
    
    public void AddUserLoginActivity_WebSite( Object ContactID, Object StoreID, Object SaleRepID, Object IsAddblock)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@StoreID", SqlDbType.Int, 0, StoreID);
		pl.Add("@SaleRepID", SqlDbType.Int, 0, SaleRepID);
		pl.Add("@IsAddblock", SqlDbType.Bit, 0, IsAddblock);
        data.RunProc("WebSite.AddUserLoginActivity",pl);
        
        data.Close();        
    }
    
    public void ChangePassword_WebSite( Object HashNewPassword, Object ID)
    {
        ParamList pl = new ParamList();
		pl.Add("@HashNewPassword", SqlDbType.NVarChar, 256, HashNewPassword);
		pl.Add("@ID", SqlDbType.Int, 0, ID);
        data.RunProc("WebSite.ChangePassword",pl);
        
        data.Close();        
    }
    
    public void CommitOrderAndSendEmail_WebSite()
    {
        ParamList pl = new ParamList();
        data.RunProc("WebSite.CommitOrderAndSendEmail",pl);
        
        data.Close();        
    }
    
    public void ConfimOrderViaMail_WebSite( Object param, Object ip)
    {
        ParamList pl = new ParamList();
		pl.Add("@param", SqlDbType.BigInt, 0, param);
		pl.Add("@ip", SqlDbType.VarChar, 100, ip);
        data.RunProc("WebSite.ConfimOrderViaMail",pl);
        
        data.Close();        
    }
    
    public void CreateSiteMap_WebSite( Object name)
    {
        ParamList pl = new ParamList();
		pl.Add("@name", SqlDbType.VarChar, 100, name);
        data.RunProc("WebSite.CreateSiteMap",pl);
        
        data.Close();        
    }
    
    public void DeleteEngagementMomentsImg_WebSite( Object ImgPath)
    {
        ParamList pl = new ParamList();
		pl.Add("@ImgPath", SqlDbType.VarChar, 100, ImgPath);
        data.RunProc("WebSite.DeleteEngagementMomentsImg",pl);
        
        data.Close();        
    }
    
    public SqlDataReader Get_R2Net_CreateNewOrderForCustomer_WebSiteSDR( Object InvoiceID, Object FirstName, Object LastName, Object Company, Object Address2, Object Country, Object City, Object State, Object ZipCode, Object Phone, Object PhoneExt)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.BigInt, 0, InvoiceID);
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@LastName", SqlDbType.NVarChar, 50, LastName);
		pl.Add("@Company", SqlDbType.NVarChar, 100, Company);
		pl.Add("@Address2", SqlDbType.NVarChar, 100, Address2);
		pl.Add("@Country", SqlDbType.Int, 0, Country);
		pl.Add("@City", SqlDbType.NVarChar, 100, City);
		pl.Add("@State", SqlDbType.NVarChar, 50, State);
		pl.Add("@ZipCode", SqlDbType.NVarChar, 10, ZipCode);
		pl.Add("@Phone", SqlDbType.NVarChar, 50, Phone);
		pl.Add("@PhoneExt", SqlDbType.NVarChar, 5, PhoneExt);
        SqlDataReader reader;
        data.RunProc("WebSite.Get_R2Net_CreateNewOrderForCustomer",pl, out reader);
        
        return reader;
    }
    
    public DataSet Get_R2Net_CreateNewOrderForCustomer_WebSiteDs( Object InvoiceID, Object FirstName, Object LastName, Object Company, Object Address2, Object Country, Object City, Object State, Object ZipCode, Object Phone, Object PhoneExt)
    {
            SqlDataReader reader = Get_R2Net_CreateNewOrderForCustomer_WebSiteSDR(  InvoiceID,  FirstName,  LastName,  Company,  Address2,  Country,  City,  State,  ZipCode,  Phone,  PhoneExt);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAccessCodeAndContactByCode_WebSiteSDR( Object Code)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
        SqlDataReader reader;
        data.RunProc("WebSite.GetAccessCodeAndContactByCode",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAccessCodeAndContactByCode_WebSiteDs( Object Code)
    {
            SqlDataReader reader = GetAccessCodeAndContactByCode_WebSiteSDR(  Code);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAccessCodeByCode_WebSiteSDR( Object Code)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
        SqlDataReader reader;
        data.RunProc("WebSite.GetAccessCodeByCode",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAccessCodeByCode_WebSiteDs( Object Code)
    {
            SqlDataReader reader = GetAccessCodeByCode_WebSiteSDR(  Code);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetAccountSettingXml_WebSite( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        XmlReader reader;
        data.RunProc("WebSite.GetAccountSettingXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetAllCountriesXml_WebSite( Object NewTaxEnabled)
    {
        ParamList pl = new ParamList();
		pl.Add("@NewTaxEnabled", SqlDbType.NVarChar, 10, NewTaxEnabled);
        XmlReader reader;
        data.RunProc("WebSite.GetAllCountriesXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetAmazonOrderDetails_WebSiteSDR( Object OrderReferenceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderReferenceID", SqlDbType.NVarChar, 50, OrderReferenceID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetAmazonOrderDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAmazonOrderDetails_WebSiteDs( Object OrderReferenceID)
    {
            SqlDataReader reader = GetAmazonOrderDetails_WebSiteSDR(  OrderReferenceID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndSaveStoreUser_WebSiteSDR( Object FirstName, Object LastNamne, Object Email, Object IP, Object Gender, Object Phone, Object StoreID, Object SaleRepID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@LastNamne", SqlDbType.NVarChar, 50, LastNamne);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@IP", SqlDbType.NVarChar, 20, IP);
		pl.Add("@Gender", SqlDbType.NVarChar, 50, Gender);
		pl.Add("@Phone", SqlDbType.NVarChar, 50, Phone);
		pl.Add("@StoreID", SqlDbType.Int, 0, StoreID);
		pl.Add("@SaleRepID", SqlDbType.Int, 0, SaleRepID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetAndSaveStoreUser",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndSaveStoreUser_WebSiteDs( Object FirstName, Object LastNamne, Object Email, Object IP, Object Gender, Object Phone, Object StoreID, Object SaleRepID)
    {
            SqlDataReader reader = GetAndSaveStoreUser_WebSiteSDR(  FirstName,  LastNamne,  Email,  IP,  Gender,  Phone,  StoreID,  SaleRepID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAsetOrIdealscopeByDiamondID_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetAsetOrIdealscopeByDiamondID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAsetOrIdealscopeByDiamondID_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetAsetOrIdealscopeByDiamondID_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAuthenticateUser_WebSiteSDR( Object UserName, Object Password)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.NVarChar, 50, UserName);
		pl.Add("@Password", SqlDbType.NVarChar, 50, Password);
        SqlDataReader reader;
        data.RunProc("WebSite.GetAuthenticateUser",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAuthenticateUser_WebSiteDs( Object UserName, Object Password)
    {
            SqlDataReader reader = GetAuthenticateUser_WebSiteSDR(  UserName,  Password);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetCanadianProvinceForCalcHtmlXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetCanadianProvinceForCalcHtmlXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetCategoryDescription_WebSiteSDR( Object CategoryID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCategoryDescription",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCategoryDescription_WebSiteDs( Object CategoryID)
    {
            SqlDataReader reader = GetCategoryDescription_WebSiteSDR(  CategoryID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetCategorySiteMapXML_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetCategorySiteMapXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetCertificateRedirect_WebSiteSDR( Object JASourceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JASourceID", SqlDbType.Int, 0, JASourceID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCertificateRedirect",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCertificateRedirect_WebSiteDs( Object JASourceID)
    {
            SqlDataReader reader = GetCertificateRedirect_WebSiteSDR(  JASourceID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCheckOutItemData_WebSiteSDR( Object ItemID, Object ItemType, Object CurrencyRate)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@ItemType", SqlDbType.VarChar, 20, ItemType);
		pl.Add("@CurrencyRate", SqlDbType.Decimal, 0, CurrencyRate);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCheckOutItemData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCheckOutItemData_WebSiteDs( Object ItemID, Object ItemType, Object CurrencyRate)
    {
            SqlDataReader reader = GetCheckOutItemData_WebSiteSDR(  ItemID,  ItemType,  CurrencyRate);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCommitOrderToInvoiceAsyc_WebSiteSDR( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
		pl.Add("@DD", SqlDbType.VarChar, 10, DD);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCommitOrderToInvoiceAsyc",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCommitOrderToInvoiceAsyc_WebSiteDs( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
            SqlDataReader reader = GetCommitOrderToInvoiceAsyc_WebSiteSDR(  DataXml,  UserID,  R2NetContactID,  DD,  DEBUG);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCommitOrderToInvoiceAsyc_bkp_WebSiteSDR( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
		pl.Add("@DD", SqlDbType.VarChar, 10, DD);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCommitOrderToInvoiceAsyc_bkp",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCommitOrderToInvoiceAsyc_bkp_WebSiteDs( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
            SqlDataReader reader = GetCommitOrderToInvoiceAsyc_bkp_WebSiteSDR(  DataXml,  UserID,  R2NetContactID,  DD,  DEBUG);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCommitOrderToInvoiceAsyc_TOKEN_WebSiteSDR( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
		pl.Add("@DD", SqlDbType.VarChar, 10, DD);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCommitOrderToInvoiceAsyc_TOKEN",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCommitOrderToInvoiceAsyc_TOKEN_WebSiteDs( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
            SqlDataReader reader = GetCommitOrderToInvoiceAsyc_TOKEN_WebSiteSDR(  DataXml,  UserID,  R2NetContactID,  DD,  DEBUG);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCommitOrderToInvoiceAsycXML_old_WebSiteSDR( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
		pl.Add("@DD", SqlDbType.VarChar, 10, DD);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCommitOrderToInvoiceAsycXML_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCommitOrderToInvoiceAsycXML_old_WebSiteDs( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
            SqlDataReader reader = GetCommitOrderToInvoiceAsycXML_old_WebSiteSDR(  DataXml,  UserID,  R2NetContactID,  DD,  DEBUG);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCommitOrderToInvoiceAsync_Tax_WebSiteSDR( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
		pl.Add("@DD", SqlDbType.VarChar, 10, DD);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCommitOrderToInvoiceAsync_Tax",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCommitOrderToInvoiceAsync_Tax_WebSiteDs( Object DataXml, Object UserID, Object R2NetContactID, Object DD, Object DEBUG)
    {
            SqlDataReader reader = GetCommitOrderToInvoiceAsync_Tax_WebSiteSDR(  DataXml,  UserID,  R2NetContactID,  DD,  DEBUG);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCommitOrderToInvoiceXML_old_WebSiteSDR( Object DataXml, Object UserID, Object R2NetContactID, Object DD)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
		pl.Add("@DD", SqlDbType.VarChar, 10, DD);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCommitOrderToInvoiceXML_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCommitOrderToInvoiceXML_old_WebSiteDs( Object DataXml, Object UserID, Object R2NetContactID, Object DD)
    {
            SqlDataReader reader = GetCommitOrderToInvoiceXML_old_WebSiteSDR(  DataXml,  UserID,  R2NetContactID,  DD);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCompleteItemPage_WebSiteSDR( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QJewelID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@EarringID", SqlDbType.Int, 0, EarringID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Gemstones", SqlDbType.Int, 0, Gemstones);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QJewelID", SqlDbType.Int, 0, QJewelID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@FunnelType", SqlDbType.VarChar, 20, FunnelType);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
		pl.Add("@debug", SqlDbType.Int, 0, debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCompleteItemPage",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCompleteItemPage_WebSiteDs( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QJewelID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
            SqlDataReader reader = GetCompleteItemPage_WebSiteSDR(  RingID,  EarringID,  DiamondID,  GemstoneID,  Gemstones,  Diamonds,  QRingID,  QJewelID,  QDiamondID,  QGemstoneID,  FunnelType,  ReadAsMail,  debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetCountriesForCalcHtmlXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetCountriesForCalcHtmlXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetCountriesXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetCountriesXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetCountryStateIDFromCode_WebSiteSDR( Object country, Object state)
    {
        ParamList pl = new ParamList();
		pl.Add("@country", SqlDbType.VarChar, 20, country);
		pl.Add("@state", SqlDbType.VarChar, 20, state);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCountryStateIDFromCode",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCountryStateIDFromCode_WebSiteDs( Object country, Object state)
    {
            SqlDataReader reader = GetCountryStateIDFromCode_WebSiteSDR(  country,  state);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetCouponDiscountXML_WebSite( Object Coupon, Object ItemID, Object IsJewel, Object MatchStone, Object SubTotal, Object Currency)
    {
        ParamList pl = new ParamList();
		pl.Add("@Coupon", SqlDbType.NVarChar, 15, Coupon);
		pl.Add("@ItemID", SqlDbType.NVarChar, 15, ItemID);
		pl.Add("@IsJewel", SqlDbType.Bit, 0, IsJewel);
		pl.Add("@MatchStone", SqlDbType.NVarChar, 15, MatchStone);
		pl.Add("@SubTotal", SqlDbType.Float, 0, SubTotal);
		pl.Add("@Currency", SqlDbType.VarChar, 10, Currency);
        XmlReader reader;
        data.RunProc("WebSite.GetCouponDiscountXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetCouponFriendDiscountXML_WebSite( Object Coupon, Object total, Object Currency)
    {
        ParamList pl = new ParamList();
		pl.Add("@Coupon", SqlDbType.NVarChar, 15, Coupon);
		pl.Add("@total", SqlDbType.Decimal, 0, total);
		pl.Add("@Currency", SqlDbType.VarChar, 10, Currency);
        XmlReader reader;
        data.RunProc("WebSite.GetCouponFriendDiscountXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetCouponsStatisticsXml_WebSite( Object CustomerId, Object Code)
    {
        ParamList pl = new ParamList();
		pl.Add("@CustomerId", SqlDbType.Int, 0, CustomerId);
		pl.Add("@Code", SqlDbType.Int, 0, Code);
        XmlReader reader;
        data.RunProc("WebSite.GetCouponsStatisticsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetCurrencyRate_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetCurrencyRate",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCurrencyRate_WebSiteDs()
    {
            SqlDataReader reader = GetCurrencyRate_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetCustomerCouponXML_WebSite( Object Coupon)
    {
        ParamList pl = new ParamList();
		pl.Add("@Coupon", SqlDbType.NVarChar, 15, Coupon);
        XmlReader reader;
        data.RunProc("WebSite.GetCustomerCouponXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetCustomerIdOfSoldRingPage_WebSiteSDR( Object Code)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
        SqlDataReader reader;
        data.RunProc("WebSite.GetCustomerIdOfSoldRingPage",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCustomerIdOfSoldRingPage_WebSiteDs( Object Code)
    {
            SqlDataReader reader = GetCustomerIdOfSoldRingPage_WebSiteSDR(  Code);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetCustomerInvoiceXml_WebSite( Object OrderID, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        XmlReader reader;
        data.RunProc("WebSite.GetCustomerInvoiceXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamond_WebSiteSDR( Object DiamondID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamond",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond_WebSiteDs( Object DiamondID, Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetDiamond_WebSiteSDR(  DiamondID,  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamond_Origin_WebSiteSDR( Object DiamondID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamond_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond_Origin_WebSiteDs( Object DiamondID, Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetDiamond_Origin_WebSiteSDR(  DiamondID,  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamond4Cache_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamond4Cache",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond4Cache_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamond4Cache_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamond4Cache_20140121_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamond4Cache_20140121",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond4Cache_20140121_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamond4Cache_20140121_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamond4Cache_Origin_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamond4Cache_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond4Cache_Origin_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamond4Cache_Origin_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondByIDorLot_WebSiteSDR( Object SearchText)
    {
        ParamList pl = new ParamList();
		pl.Add("@SearchText", SqlDbType.NVarChar, 50, SearchText);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondByIDorLot",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondByIDorLot_WebSiteDs( Object SearchText)
    {
            SqlDataReader reader = GetDiamondByIDorLot_WebSiteSDR(  SearchText);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondByIDorLotXml_WebSite( Object SearchText)
    {
        ParamList pl = new ParamList();
		pl.Add("@SearchText", SqlDbType.NVarChar, 50, SearchText);
        XmlReader reader;
        data.RunProc("WebSite.GetDiamondByIDorLotXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondChanges_WebSiteSDR( Object DiamondChangeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondChangeID", SqlDbType.Int, 0, DiamondChangeID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondChanges",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondChanges_WebSiteDs( Object DiamondChangeID)
    {
            SqlDataReader reader = GetDiamondChanges_WebSiteSDR(  DiamondChangeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondGallery_RF_WebSiteSDR( Object LastModifyDate)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModifyDate", SqlDbType.DateTime, 0, LastModifyDate);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondGallery_RF",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondGallery_RF_WebSiteDs( Object LastModifyDate)
    {
            SqlDataReader reader = GetDiamondGallery_RF_WebSiteSDR(  LastModifyDate);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondItemXml_WebSite( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        XmlReader reader;
        data.RunProc("WebSite.GetDiamondItemXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondItemXml_Origin_WebSiteSDR( Object DiamondID, Object AppName)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@AppName", SqlDbType.VarChar, 20, AppName);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondItemXml_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondItemXml_Origin_WebSiteDs( Object DiamondID, Object AppName)
    {
            SqlDataReader reader = GetDiamondItemXml_Origin_WebSiteSDR(  DiamondID,  AppName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondItemXml_Temp_WebSiteSDR( Object DiamondID, Object AppName)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@AppName", SqlDbType.VarChar, 20, AppName);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondItemXml_Temp",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondItemXml_Temp_WebSiteDs( Object DiamondID, Object AppName)
    {
            SqlDataReader reader = GetDiamondItemXml_Temp_WebSiteSDR(  DiamondID,  AppName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondRange_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondRange",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondRange_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetDiamondRange_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondSaleInfo_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondSaleInfo",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondSaleInfo_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondSaleInfo_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondSaleInfoXml_WebSite( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        XmlReader reader;
        data.RunProc("WebSite.GetDiamondSaleInfoXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondsByShape_WebSiteSDR( Object PageID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageID", SqlDbType.Int, 0, PageID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondsByShape",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsByShape_WebSiteDs( Object PageID)
    {
            SqlDataReader reader = GetDiamondsByShape_WebSiteSDR(  PageID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondsForCache_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondsForCache",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsForCache_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondsForCache_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondsForGOXml_WebSite( Object Shape, Object Color, Object Clarity, Object Cut)
    {
        ParamList pl = new ParamList();
		pl.Add("@Shape", SqlDbType.NVarChar, 50, Shape);
		pl.Add("@Color", SqlDbType.NVarChar, 50, Color);
		pl.Add("@Clarity", SqlDbType.NVarChar, 50, Clarity);
		pl.Add("@Cut", SqlDbType.NVarChar, 50, Cut);
        XmlReader reader;
        data.RunProc("WebSite.GetDiamondsForGOXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondsPair_WebSiteSDR( Object FirstDiamondID, Object SecondDiamondID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@FirstDiamondID", SqlDbType.Int, 0, FirstDiamondID);
		pl.Add("@SecondDiamondID", SqlDbType.Int, 0, SecondDiamondID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondsPair",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsPair_WebSiteDs( Object FirstDiamondID, Object SecondDiamondID, Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetDiamondsPair_WebSiteSDR(  FirstDiamondID,  SecondDiamondID,  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondsPairsXml_WebSite( Object ps, Object PageNumber, Object CaratFrom, Object CaratTo, Object Shape, Object Cut, Object Color, Object Clarity, Object Polish, Object Symmetry, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object Flour, Object Lab, Object Sort, Object ShowAdvanced, Object advancedParameter, Object TabSelected, Object ViewsOptions, Object CenterDiamondID, Object StudsMatchID, Object FancyColor, Object FancyIntensity, Object sliderChanged)
    {
        ParamList pl = new ParamList();
		pl.Add("@ps", SqlDbType.Int, 0, ps);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@CaratFrom", SqlDbType.Float, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Float, 0, CaratTo);
		pl.Add("@Shape", SqlDbType.NVarChar, 50, Shape);
		pl.Add("@Cut", SqlDbType.NVarChar, 50, Cut);
		pl.Add("@Color", SqlDbType.NVarChar, 50, Color);
		pl.Add("@Clarity", SqlDbType.NVarChar, 50, Clarity);
		pl.Add("@Polish", SqlDbType.NVarChar, 50, Polish);
		pl.Add("@Symmetry", SqlDbType.NVarChar, 50, Symmetry);
		pl.Add("@PriceFrom", SqlDbType.Int, 0, PriceFrom);
		pl.Add("@PriceTo", SqlDbType.Int, 0, PriceTo);
		pl.Add("@DepthFrom", SqlDbType.Float, 0, DepthFrom);
		pl.Add("@DepthTo", SqlDbType.Float, 0, DepthTo);
		pl.Add("@TableFrom", SqlDbType.Float, 0, TableFrom);
		pl.Add("@TableTo", SqlDbType.Float, 0, TableTo);
		pl.Add("@Flour", SqlDbType.NVarChar, 50, Flour);
		pl.Add("@Lab", SqlDbType.NVarChar, 50, Lab);
		pl.Add("@Sort", SqlDbType.NVarChar, 0, Sort);
		pl.Add("@ShowAdvanced", SqlDbType.NVarChar, 50, ShowAdvanced);
		pl.Add("@advancedParameter", SqlDbType.NVarChar, 50, advancedParameter);
		pl.Add("@TabSelected", SqlDbType.Int, 0, TabSelected);
		pl.Add("@ViewsOptions", SqlDbType.NVarChar, 50, ViewsOptions);
		pl.Add("@CenterDiamondID", SqlDbType.Int, 0, CenterDiamondID);
		pl.Add("@StudsMatchID", SqlDbType.Int, 0, StudsMatchID);
		pl.Add("@FancyColor", SqlDbType.NVarChar, 50, FancyColor);
		pl.Add("@FancyIntensity", SqlDbType.NVarChar, 50, FancyIntensity);
		pl.Add("@sliderChanged", SqlDbType.NVarChar, 50, sliderChanged);
        XmlReader reader;
        data.RunProc("WebSite.GetDiamondsPairsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondsPairsXmlTest_WebSiteSDR( Object ps, Object PageNumber, Object CaratFrom, Object CaratTo, Object Shape, Object Cut, Object Color, Object Clarity, Object Polish, Object Symmetry, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object Flour, Object Lab, Object Sort, Object ShowAdvanced, Object advancedParameter, Object TabSelected, Object ViewsOptions, Object CenterDiamondID, Object StudsMatchID, Object FancyColor, Object FancyIntensity, Object sliderChanged)
    {
        ParamList pl = new ParamList();
		pl.Add("@ps", SqlDbType.Int, 0, ps);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@CaratFrom", SqlDbType.Float, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Float, 0, CaratTo);
		pl.Add("@Shape", SqlDbType.NVarChar, 50, Shape);
		pl.Add("@Cut", SqlDbType.NVarChar, 50, Cut);
		pl.Add("@Color", SqlDbType.NVarChar, 50, Color);
		pl.Add("@Clarity", SqlDbType.NVarChar, 50, Clarity);
		pl.Add("@Polish", SqlDbType.NVarChar, 50, Polish);
		pl.Add("@Symmetry", SqlDbType.NVarChar, 50, Symmetry);
		pl.Add("@PriceFrom", SqlDbType.Int, 0, PriceFrom);
		pl.Add("@PriceTo", SqlDbType.Int, 0, PriceTo);
		pl.Add("@DepthFrom", SqlDbType.Float, 0, DepthFrom);
		pl.Add("@DepthTo", SqlDbType.Float, 0, DepthTo);
		pl.Add("@TableFrom", SqlDbType.Float, 0, TableFrom);
		pl.Add("@TableTo", SqlDbType.Float, 0, TableTo);
		pl.Add("@Flour", SqlDbType.NVarChar, 50, Flour);
		pl.Add("@Lab", SqlDbType.NVarChar, 50, Lab);
		pl.Add("@Sort", SqlDbType.NVarChar, 0, Sort);
		pl.Add("@ShowAdvanced", SqlDbType.NVarChar, 50, ShowAdvanced);
		pl.Add("@advancedParameter", SqlDbType.NVarChar, 50, advancedParameter);
		pl.Add("@TabSelected", SqlDbType.Int, 0, TabSelected);
		pl.Add("@ViewsOptions", SqlDbType.NVarChar, 50, ViewsOptions);
		pl.Add("@CenterDiamondID", SqlDbType.Int, 0, CenterDiamondID);
		pl.Add("@StudsMatchID", SqlDbType.Int, 0, StudsMatchID);
		pl.Add("@FancyColor", SqlDbType.NVarChar, 50, FancyColor);
		pl.Add("@FancyIntensity", SqlDbType.NVarChar, 50, FancyIntensity);
		pl.Add("@sliderChanged", SqlDbType.NVarChar, 50, sliderChanged);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondsPairsXmlTest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsPairsXmlTest_WebSiteDs( Object ps, Object PageNumber, Object CaratFrom, Object CaratTo, Object Shape, Object Cut, Object Color, Object Clarity, Object Polish, Object Symmetry, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object Flour, Object Lab, Object Sort, Object ShowAdvanced, Object advancedParameter, Object TabSelected, Object ViewsOptions, Object CenterDiamondID, Object StudsMatchID, Object FancyColor, Object FancyIntensity, Object sliderChanged)
    {
            SqlDataReader reader = GetDiamondsPairsXmlTest_WebSiteSDR(  ps,  PageNumber,  CaratFrom,  CaratTo,  Shape,  Cut,  Color,  Clarity,  Polish,  Symmetry,  PriceFrom,  PriceTo,  DepthFrom,  DepthTo,  TableFrom,  TableTo,  Flour,  Lab,  Sort,  ShowAdvanced,  advancedParameter,  TabSelected,  ViewsOptions,  CenterDiamondID,  StudsMatchID,  FancyColor,  FancyIntensity,  sliderChanged);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondsPairXml_WebSite( Object FirstDiamondID, Object SecondDiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FirstDiamondID", SqlDbType.Int, 0, FirstDiamondID);
		pl.Add("@SecondDiamondID", SqlDbType.Int, 0, SecondDiamondID);
        XmlReader reader;
        data.RunProc("WebSite.GetDiamondsPairXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondSpecificationsHelp_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondSpecificationsHelp",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondSpecificationsHelp_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondSpecificationsHelp_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondSpecificationsHelpByColor_WebSiteSDR( Object ColorID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ColorID", SqlDbType.Int, 0, ColorID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondSpecificationsHelpByColor",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondSpecificationsHelpByColor_WebSiteDs( Object ColorID)
    {
            SqlDataReader reader = GetDiamondSpecificationsHelpByColor_WebSiteSDR(  ColorID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondStatus_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondStatus",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondStatus_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondStatus_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondStudEarrings_WebSiteSDR( Object CategoryID, Object PageNumber, Object PageSize, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@Debug", SqlDbType.SmallInt, 0, Debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondStudEarrings",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondStudEarrings_WebSiteDs( Object CategoryID, Object PageNumber, Object PageSize, Object Debug)
    {
            SqlDataReader reader = GetDiamondStudEarrings_WebSiteSDR(  CategoryID,  PageNumber,  PageSize,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondUrlByDiamondID_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondUrlByDiamondID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondUrlByDiamondID_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondUrlByDiamondID_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondUrlByJASourceID_WebSiteSDR( Object JASourceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JASourceID", SqlDbType.Int, 0, JASourceID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiamondUrlByJASourceID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondUrlByJASourceID_WebSiteDs( Object JASourceID)
    {
            SqlDataReader reader = GetDiamondUrlByJASourceID_WebSiteSDR(  JASourceID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiscountByCategoryID_WebSiteSDR( Object JewelCategoryID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelCategoryID", SqlDbType.Int, 0, JewelCategoryID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiscountByCategoryID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiscountByCategoryID_WebSiteDs( Object JewelCategoryID)
    {
            SqlDataReader reader = GetDiscountByCategoryID_WebSiteSDR(  JewelCategoryID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiscountCodeByStateAndCity_WebSiteSDR( Object State, Object City)
    {
        ParamList pl = new ParamList();
		pl.Add("@State", SqlDbType.NVarChar, 3, State);
		pl.Add("@City", SqlDbType.NVarChar, 50, City);
        SqlDataReader reader;
        data.RunProc("WebSite.GetDiscountCodeByStateAndCity",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiscountCodeByStateAndCity_WebSiteDs( Object State, Object City)
    {
            SqlDataReader reader = GetDiscountCodeByStateAndCity_WebSiteSDR(  State,  City);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetEmailInfoForSoldRingEmail_WebSiteSDR( Object Code, Object RecipientName, Object src)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
		pl.Add("@RecipientName", SqlDbType.VarChar, 100, RecipientName);
		pl.Add("@src", SqlDbType.VarChar, 10, src);
        SqlDataReader reader;
        data.RunProc("WebSite.GetEmailInfoForSoldRingEmail",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetEmailInfoForSoldRingEmail_WebSiteDs( Object Code, Object RecipientName, Object src)
    {
            SqlDataReader reader = GetEmailInfoForSoldRingEmail_WebSiteSDR(  Code,  RecipientName,  src);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetEngagementMomentsFilterXml_WebSite( Object CountryRegionCode, Object City, Object State)
    {
        ParamList pl = new ParamList();
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 2, CountryRegionCode);
		pl.Add("@City", SqlDbType.NVarChar, 50, City);
		pl.Add("@State", SqlDbType.NVarChar, 50, State);
        XmlReader reader;
        data.RunProc("WebSite.GetEngagementMomentsFilterXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetEngagementMomentsItemXml_WebSite( Object EngagementMomentID)
    {
        ParamList pl = new ParamList();
		pl.Add("@EngagementMomentID", SqlDbType.Int, 0, EngagementMomentID);
        XmlReader reader;
        data.RunProc("WebSite.GetEngagementMomentsItemXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetEngagementMomentsXml_WebSite( Object CountryRegionCode, Object City, Object State, Object LastItem, Object ItemsCount)
    {
        ParamList pl = new ParamList();
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 2, CountryRegionCode);
		pl.Add("@City", SqlDbType.NVarChar, 50, City);
		pl.Add("@State", SqlDbType.NVarChar, 50, State);
		pl.Add("@LastItem", SqlDbType.Int, 0, LastItem);
		pl.Add("@ItemsCount", SqlDbType.Int, 0, ItemsCount);
        XmlReader reader;
        data.RunProc("WebSite.GetEngagementMomentsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetEngagementSplashData_WebSiteSDR( Object CategoryID, Object ShapeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetEngagementSplashData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetEngagementSplashData_WebSiteDs( Object CategoryID, Object ShapeID)
    {
            SqlDataReader reader = GetEngagementSplashData_WebSiteSDR(  CategoryID,  ShapeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetExternalReviews_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetExternalReviews",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetExternalReviews_WebSiteDs()
    {
            SqlDataReader reader = GetExternalReviews_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetFAQXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetFAQXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetFunnelItems_WebSiteSDR( Object Setting, Object Diamond, Object Gemstone, Object Currency, Object StartWith)
    {
        ParamList pl = new ParamList();
		pl.Add("@Setting", SqlDbType.Int, 0, Setting);
		pl.Add("@Diamond", SqlDbType.Int, 0, Diamond);
		pl.Add("@Gemstone", SqlDbType.Int, 0, Gemstone);
		pl.Add("@Currency", SqlDbType.VarChar, 20, Currency);
		pl.Add("@StartWith", SqlDbType.VarChar, 10, StartWith);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItems",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItems_WebSiteDs( Object Setting, Object Diamond, Object Gemstone, Object Currency, Object StartWith)
    {
            SqlDataReader reader = GetFunnelItems_WebSiteSDR(  Setting,  Diamond,  Gemstone,  Currency,  StartWith);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItems1_WebSiteSDR( Object Setting, Object Diamond, Object Gemstone, Object Diamonds, Object Currency, Object StartWith)
    {
        ParamList pl = new ParamList();
		pl.Add("@Setting", SqlDbType.Int, 0, Setting);
		pl.Add("@Diamond", SqlDbType.Int, 0, Diamond);
		pl.Add("@Gemstone", SqlDbType.Int, 0, Gemstone);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@Currency", SqlDbType.VarChar, 20, Currency);
		pl.Add("@StartWith", SqlDbType.VarChar, 10, StartWith);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItems1",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItems1_WebSiteDs( Object Setting, Object Diamond, Object Gemstone, Object Diamonds, Object Currency, Object StartWith)
    {
            SqlDataReader reader = GetFunnelItems1_WebSiteSDR(  Setting,  Diamond,  Gemstone,  Diamonds,  Currency,  StartWith);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItems1_Origin_WebSiteSDR( Object Setting, Object Diamond, Object Gemstone, Object Diamonds, Object Currency, Object StartWith)
    {
        ParamList pl = new ParamList();
		pl.Add("@Setting", SqlDbType.Int, 0, Setting);
		pl.Add("@Diamond", SqlDbType.Int, 0, Diamond);
		pl.Add("@Gemstone", SqlDbType.Int, 0, Gemstone);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@Currency", SqlDbType.VarChar, 20, Currency);
		pl.Add("@StartWith", SqlDbType.VarChar, 10, StartWith);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItems1_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItems1_Origin_WebSiteDs( Object Setting, Object Diamond, Object Gemstone, Object Diamonds, Object Currency, Object StartWith)
    {
            SqlDataReader reader = GetFunnelItems1_Origin_WebSiteSDR(  Setting,  Diamond,  Gemstone,  Diamonds,  Currency,  StartWith);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItemsData_WebSiteSDR( Object RingID, Object DiamondID, Object GemstoneID, Object QRingID, Object QDiamondID, Object QGemstoneID, Object ReadAsMail)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItemsData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItemsData_WebSiteDs( Object RingID, Object DiamondID, Object GemstoneID, Object QRingID, Object QDiamondID, Object QGemstoneID, Object ReadAsMail)
    {
            SqlDataReader reader = GetFunnelItemsData_WebSiteSDR(  RingID,  DiamondID,  GemstoneID,  QRingID,  QDiamondID,  QGemstoneID,  ReadAsMail);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItemsData_Origin_WebSiteSDR( Object RingID, Object DiamondID, Object GemstoneID, Object QRingID, Object QDiamondID, Object QGemstoneID, Object ReadAsMail)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItemsData_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItemsData_Origin_WebSiteDs( Object RingID, Object DiamondID, Object GemstoneID, Object QRingID, Object QDiamondID, Object QGemstoneID, Object ReadAsMail)
    {
            SqlDataReader reader = GetFunnelItemsData_Origin_WebSiteSDR(  RingID,  DiamondID,  GemstoneID,  QRingID,  QDiamondID,  QGemstoneID,  ReadAsMail);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItemsData1_WebSiteSDR( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@EarringID", SqlDbType.Int, 0, EarringID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Gemstones", SqlDbType.Int, 0, Gemstones);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@FunnelType", SqlDbType.VarChar, 20, FunnelType);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
		pl.Add("@debug", SqlDbType.Int, 0, debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItemsData1",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItemsData1_WebSiteDs( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
            SqlDataReader reader = GetFunnelItemsData1_WebSiteSDR(  RingID,  EarringID,  DiamondID,  GemstoneID,  Gemstones,  Diamonds,  QRingID,  QDiamondID,  QGemstoneID,  FunnelType,  ReadAsMail,  debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItemsData1_old_17062018_WebSiteSDR( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@EarringID", SqlDbType.Int, 0, EarringID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Gemstones", SqlDbType.Int, 0, Gemstones);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@FunnelType", SqlDbType.VarChar, 20, FunnelType);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
		pl.Add("@debug", SqlDbType.Int, 0, debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItemsData1_old_17062018",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItemsData1_old_17062018_WebSiteDs( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
            SqlDataReader reader = GetFunnelItemsData1_old_17062018_WebSiteSDR(  RingID,  EarringID,  DiamondID,  GemstoneID,  Gemstones,  Diamonds,  QRingID,  QDiamondID,  QGemstoneID,  FunnelType,  ReadAsMail,  debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItemsData1_Origin_WebSiteSDR( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@EarringID", SqlDbType.Int, 0, EarringID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Gemstones", SqlDbType.Int, 0, Gemstones);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@FunnelType", SqlDbType.VarChar, 20, FunnelType);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
		pl.Add("@debug", SqlDbType.Int, 0, debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItemsData1_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItemsData1_Origin_WebSiteDs( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
            SqlDataReader reader = GetFunnelItemsData1_Origin_WebSiteSDR(  RingID,  EarringID,  DiamondID,  GemstoneID,  Gemstones,  Diamonds,  QRingID,  QDiamondID,  QGemstoneID,  FunnelType,  ReadAsMail,  debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFunnelItemsData1_RF_WebSiteSDR( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@EarringID", SqlDbType.Int, 0, EarringID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Gemstones", SqlDbType.Int, 0, Gemstones);
		pl.Add("@Diamonds", SqlDbType.VarChar, 200, Diamonds);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@FunnelType", SqlDbType.VarChar, 20, FunnelType);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
		pl.Add("@debug", SqlDbType.Int, 0, debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetFunnelItemsData1_RF",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFunnelItemsData1_RF_WebSiteDs( Object RingID, Object EarringID, Object DiamondID, Object GemstoneID, Object Gemstones, Object Diamonds, Object QRingID, Object QDiamondID, Object QGemstoneID, Object FunnelType, Object ReadAsMail, Object debug)
    {
            SqlDataReader reader = GetFunnelItemsData1_RF_WebSiteSDR(  RingID,  EarringID,  DiamondID,  GemstoneID,  Gemstones,  Diamonds,  QRingID,  QDiamondID,  QGemstoneID,  FunnelType,  ReadAsMail,  debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetFunnelItemsDataXML_WebSite( Object RingID, Object DiamondID, Object GemstoneID, Object QRingID, Object QDiamondID, Object QGemstoneID, Object ReadAsMail)
    {
        ParamList pl = new ParamList();
		pl.Add("@RingID", SqlDbType.Int, 0, RingID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@QRingID", SqlDbType.Int, 0, QRingID);
		pl.Add("@QDiamondID", SqlDbType.Int, 0, QDiamondID);
		pl.Add("@QGemstoneID", SqlDbType.Int, 0, QGemstoneID);
		pl.Add("@ReadAsMail", SqlDbType.Int, 0, ReadAsMail);
        XmlReader reader;
        data.RunProc("WebSite.GetFunnelItemsDataXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetGemstoneCertificateXml_WebSite( Object GemstoneID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 50, RecentlyViewCSV);
        XmlReader reader;
        data.RunProc("WebSite.GetGemstoneCertificateXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetGemstoneItemXml_WebSite( Object GemstoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
        XmlReader reader;
        data.RunProc("WebSite.GetGemstoneItemXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetGemstonesXml_WebSite( Object ps, Object pn, Object CaratFrom, Object CaratTo, Object Shape, Object Color, Object PriceFrom, Object PriceTo, Object TabSelected, Object ViewsOptions, Object Sort, Object RingMatchID, Object StudsMatchID, Object DiamondID, Object AdvancedParameter, Object SliderChanged, Object SupplierBranchID, Object IsPairs, Object GalleryCurrentPage, Object PagesCount, Object isDebug)
    {
        ParamList pl = new ParamList();
		pl.Add("@ps", SqlDbType.Int, 0, ps);
		pl.Add("@pn", SqlDbType.Int, 0, pn);
		pl.Add("@CaratFrom", SqlDbType.Float, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Float, 0, CaratTo);
		pl.Add("@Shape", SqlDbType.NVarChar, 100, Shape);
		pl.Add("@Color", SqlDbType.NVarChar, 50, Color);
		pl.Add("@PriceFrom", SqlDbType.Float, 0, PriceFrom);
		pl.Add("@PriceTo", SqlDbType.Float, 0, PriceTo);
		pl.Add("@TabSelected", SqlDbType.Int, 0, TabSelected);
		pl.Add("@ViewsOptions", SqlDbType.NVarChar, 50, ViewsOptions);
		pl.Add("@Sort", SqlDbType.NVarChar, 0, Sort);
		pl.Add("@RingMatchID", SqlDbType.Int, 0, RingMatchID);
		pl.Add("@StudsMatchID", SqlDbType.Int, 0, StudsMatchID);
		pl.Add("@DiamondID", SqlDbType.NVarChar, 50, DiamondID);
		pl.Add("@AdvancedParameter", SqlDbType.NVarChar, 50, AdvancedParameter);
		pl.Add("@SliderChanged", SqlDbType.NVarChar, 50, SliderChanged);
		pl.Add("@SupplierBranchID", SqlDbType.Int, 0, SupplierBranchID);
		pl.Add("@IsPairs", SqlDbType.Bit, 0, IsPairs);
		pl.Add("@GalleryCurrentPage", SqlDbType.Int, 0, GalleryCurrentPage);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@isDebug", SqlDbType.Bit, 0, isDebug);
        XmlReader reader;
        data.RunProc("WebSite.GetGemstonesXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetGemstoneUrlByGemstoneID_WebSiteSDR( Object GemstoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetGemstoneUrlByGemstoneID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGemstoneUrlByGemstoneID_WebSiteDs( Object GemstoneID)
    {
            SqlDataReader reader = GetGemstoneUrlByGemstoneID_WebSiteSDR(  GemstoneID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetGemstoneUrlValue_WebSiteSDR( Object GemstoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetGemstoneUrlValue",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGemstoneUrlValue_WebSiteDs( Object GemstoneID)
    {
            SqlDataReader reader = GetGemstoneUrlValue_WebSiteSDR(  GemstoneID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetGemstoneXml_WebSite( Object GemstoneID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 50, RecentlyViewCSV);
        XmlReader reader;
        data.RunProc("WebSite.GetGemstoneXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetGoogleCheckOutItemData_WebSiteSDR( Object ItemID, Object ItemType, Object CurrencyRate)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@ItemType", SqlDbType.VarChar, 20, ItemType);
		pl.Add("@CurrencyRate", SqlDbType.Decimal, 0, CurrencyRate);
        SqlDataReader reader;
        data.RunProc("WebSite.GetGoogleCheckOutItemData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGoogleCheckOutItemData_WebSiteDs( Object ItemID, Object ItemType, Object CurrencyRate)
    {
            SqlDataReader reader = GetGoogleCheckOutItemData_WebSiteSDR(  ItemID,  ItemType,  CurrencyRate);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetGoogleEcommerce_WebSiteSDR( Object Order)
    {
        ParamList pl = new ParamList();
		pl.Add("@Order", SqlDbType.BigInt, 0, Order);
        SqlDataReader reader;
        data.RunProc("WebSite.GetGoogleEcommerce",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGoogleEcommerce_WebSiteDs( Object Order)
    {
            SqlDataReader reader = GetGoogleEcommerce_WebSiteSDR(  Order);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetGoogleEcommerceXML_WebSite( Object Order)
    {
        ParamList pl = new ParamList();
		pl.Add("@Order", SqlDbType.BigInt, 0, Order);
        XmlReader reader;
        data.RunProc("WebSite.GetGoogleEcommerceXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetGoogleEEByOrderID_WebSiteSDR( Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.NVarChar, 0, OrderID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetGoogleEEByOrderID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGoogleEEByOrderID_WebSiteDs( Object OrderID)
    {
            SqlDataReader reader = GetGoogleEEByOrderID_WebSiteSDR(  OrderID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetGooglePixelID_WebSiteSDR( Object InteractionType, Object TimeStamp, Object ViewsCounter, Object UTMSource, Object UTMMedium, Object UTMCampaign, Object UTMTerm, Object ExperimentID, Object ExtraData)
    {
        ParamList pl = new ParamList();
		pl.Add("@InteractionType", SqlDbType.NVarChar, 50, InteractionType);
		pl.Add("@TimeStamp", SqlDbType.NVarChar, 50, TimeStamp);
		pl.Add("@ViewsCounter", SqlDbType.Int, 0, ViewsCounter);
		pl.Add("@UTMSource", SqlDbType.NVarChar, 100, UTMSource);
		pl.Add("@UTMMedium", SqlDbType.NVarChar, 100, UTMMedium);
		pl.Add("@UTMCampaign", SqlDbType.NVarChar, 100, UTMCampaign);
		pl.Add("@UTMTerm", SqlDbType.NVarChar, 200, UTMTerm);
		pl.Add("@ExperimentID", SqlDbType.NVarChar, 200, ExperimentID);
		pl.Add("@ExtraData", SqlDbType.NVarChar, 1000, ExtraData);
        SqlDataReader reader;
        data.RunProc("WebSite.GetGooglePixelID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGooglePixelID_WebSiteDs( Object InteractionType, Object TimeStamp, Object ViewsCounter, Object UTMSource, Object UTMMedium, Object UTMCampaign, Object UTMTerm, Object ExperimentID, Object ExtraData)
    {
            SqlDataReader reader = GetGooglePixelID_WebSiteSDR(  InteractionType,  TimeStamp,  ViewsCounter,  UTMSource,  UTMMedium,  UTMCampaign,  UTMTerm,  ExperimentID,  ExtraData);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetHDPlayerXML_WebSite( Object ParentID, Object CategoryID, Object ItemID, Object Mode)
    {
        ParamList pl = new ParamList();
		pl.Add("@ParentID", SqlDbType.Int, 0, ParentID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@Mode", SqlDbType.NVarChar, 50, Mode);
        XmlReader reader;
        data.RunProc("WebSite.GetHDPlayerXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetInsertTracking_WebSiteSDR( Object tAffiliateID, Object tBannerID, Object CategoryID, Object tPage, Object tReferrer, Object tIP, Object sID)
    {
        ParamList pl = new ParamList();
		pl.Add("@tAffiliateID", SqlDbType.Int, 0, tAffiliateID);
		pl.Add("@tBannerID", SqlDbType.Int, 0, tBannerID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@tPage", SqlDbType.VarChar, 1000, tPage);
		pl.Add("@tReferrer", SqlDbType.VarChar, 1000, tReferrer);
		pl.Add("@tIP", SqlDbType.VarChar, 100, tIP);
		pl.Add("@sID", SqlDbType.VarChar, 500, sID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetInsertTracking",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInsertTracking_WebSiteDs( Object tAffiliateID, Object tBannerID, Object CategoryID, Object tPage, Object tReferrer, Object tIP, Object sID)
    {
            SqlDataReader reader = GetInsertTracking_WebSiteSDR(  tAffiliateID,  tBannerID,  CategoryID,  tPage,  tReferrer,  tIP,  sID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetInspiredDiamondItemXml_WebSite( Object SoldRingId)
    {
        ParamList pl = new ParamList();
		pl.Add("@SoldRingId", SqlDbType.Int, 0, SoldRingId);
        XmlReader reader;
        data.RunProc("WebSite.GetInspiredDiamondItemXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetInspiredGemstoneItemXml_WebSite( Object SoldRingId)
    {
        ParamList pl = new ParamList();
		pl.Add("@SoldRingId", SqlDbType.Int, 0, SoldRingId);
        XmlReader reader;
        data.RunProc("WebSite.GetInspiredGemstoneItemXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetInspiredItemXml_WebSite( Object SoldRingId)
    {
        ParamList pl = new ParamList();
		pl.Add("@SoldRingId", SqlDbType.Int, 0, SoldRingId);
        XmlReader reader;
        data.RunProc("WebSite.GetInspiredItemXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetInspiredListItemsXml_WebSite( Object CategoryID, Object OrderID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Shape, Object MinTotalCarat, Object MaxTotalCarat, Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@Shape", SqlDbType.NVarChar, 20, Shape);
		pl.Add("@MinTotalCarat", SqlDbType.Decimal, 0, MinTotalCarat);
		pl.Add("@MaxTotalCarat", SqlDbType.Decimal, 0, MaxTotalCarat);
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("WebSite.GetInspiredListItemsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetInvoceIDByAmazonOrderID_WebSiteSDR( Object OrderReferenceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderReferenceID", SqlDbType.NVarChar, 50, OrderReferenceID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetInvoceIDByAmazonOrderID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInvoceIDByAmazonOrderID_WebSiteDs( Object OrderReferenceID)
    {
            SqlDataReader reader = GetInvoceIDByAmazonOrderID_WebSiteSDR(  OrderReferenceID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetItemDetailsFromOrderXML_WebSite( Object InvoiceID, Object SKU, Object Action)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.BigInt, 0, InvoiceID);
		pl.Add("@SKU", SqlDbType.NVarChar, 20, SKU);
		pl.Add("@Action", SqlDbType.NVarChar, 50, Action);
        XmlReader reader;
        data.RunProc("WebSite.GetItemDetailsFromOrderXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetItemFilePathForEmail_WebSiteSDR( Object ItemID, Object ItemType)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@ItemType", SqlDbType.Int, 0, ItemType);
        SqlDataReader reader;
        data.RunProc("WebSite.GetItemFilePathForEmail",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetItemFilePathForEmail_WebSiteDs( Object ItemID, Object ItemType)
    {
            SqlDataReader reader = GetItemFilePathForEmail_WebSiteSDR(  ItemID,  ItemType);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetItemInfoForGoogleAdwords_WebSiteSDR( Object item_type, Object itemid)
    {
        ParamList pl = new ParamList();
		pl.Add("@item_type", SqlDbType.Int, 0, item_type);
		pl.Add("@itemid", SqlDbType.VarChar, 30, itemid);
        SqlDataReader reader;
        data.RunProc("WebSite.GetItemInfoForGoogleAdwords",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetItemInfoForGoogleAdwords_WebSiteDs( Object item_type, Object itemid)
    {
            SqlDataReader reader = GetItemInfoForGoogleAdwords_WebSiteSDR(  item_type,  itemid);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetItemsFromOrderQueue_WebSiteSDR( Object InvoiceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.BigInt, 0, InvoiceID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetItemsFromOrderQueue",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetItemsFromOrderQueue_WebSiteDs( Object InvoiceID)
    {
            SqlDataReader reader = GetItemsFromOrderQueue_WebSiteSDR(  InvoiceID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetItemURLForMobile_WebSiteSDR( Object ItemID, Object ItemType)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@ItemType", SqlDbType.Int, 0, ItemType);
        SqlDataReader reader;
        data.RunProc("WebSite.GetItemURLForMobile",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetItemURLForMobile_WebSiteDs( Object ItemID, Object ItemType)
    {
            SqlDataReader reader = GetItemURLForMobile_WebSiteSDR(  ItemID,  ItemType);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJADiamonds_WebSiteSDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJADiamonds",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJADiamonds_WebSiteDs( Object LastModify)
    {
            SqlDataReader reader = GetJADiamonds_WebSiteSDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJADiamonds_Origin_WebSiteSDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJADiamonds_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJADiamonds_Origin_WebSiteDs( Object LastModify)
    {
            SqlDataReader reader = GetJADiamonds_Origin_WebSiteSDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJADiamondsLite_WebSiteSDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJADiamondsLite",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJADiamondsLite_WebSiteDs( Object LastModify)
    {
            SqlDataReader reader = GetJADiamondsLite_WebSiteSDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJADiamondsLite_Origin_WebSiteSDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJADiamondsLite_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJADiamondsLite_Origin_WebSiteDs( Object LastModify)
    {
            SqlDataReader reader = GetJADiamondsLite_Origin_WebSiteSDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJamesAllenAlertResultRows_WebSiteSDR( Object JamesAllenAlertID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JamesAllenAlertID", SqlDbType.Int, 0, JamesAllenAlertID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJamesAllenAlertResultRows",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJamesAllenAlertResultRows_WebSiteDs( Object JamesAllenAlertID)
    {
            SqlDataReader reader = GetJamesAllenAlertResultRows_WebSiteSDR(  JamesAllenAlertID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetJATrackerStatusXml_WebSite( Object invoice_no)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice_no", SqlDbType.BigInt, 0, invoice_no);
        XmlReader reader;
        data.RunProc("WebSite.GetJATrackerStatusXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetJewel_WebSiteSDR( Object JewelID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 50, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewel",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewel_WebSiteDs( Object JewelID, Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetJewel_WebSiteSDR(  JewelID,  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewel_TMP_old_WebSiteSDR( Object JewelID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 50, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewel_TMP_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewel_TMP_old_WebSiteDs( Object JewelID, Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetJewel_TMP_old_WebSiteSDR(  JewelID,  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetJewelByIDorSkuXml_WebSite( Object SearchText)
    {
        ParamList pl = new ParamList();
		pl.Add("@SearchText", SqlDbType.NVarChar, 50, SearchText);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelByIDorSkuXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetJewelCategoriesXml_WebSite( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelCategoriesXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetJewelDetailsXml_WebSite( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelDetailsXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetJewelFromCacheXml_WebSite( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelFromCacheXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetJewelGallery_WebSiteSDR( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object IsStore)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@ShowUnActive", SqlDbType.Bit, 0, ShowUnActive);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
		pl.Add("@SelectedShapeID", SqlDbType.Int, 0, SelectedShapeID);
		pl.Add("@IncludeExpressShipping", SqlDbType.Bit, 0, IncludeExpressShipping);
		pl.Add("@ShowPromotionBanner", SqlDbType.Bit, 0, ShowPromotionBanner);
		pl.Add("@ActiveCampaign", SqlDbType.NVarChar, 50, ActiveCampaign);
		pl.Add("@IsStore", SqlDbType.Bit, 0, IsStore);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGallery",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGallery_WebSiteDs( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object IsStore)
    {
            SqlDataReader reader = GetJewelGallery_WebSiteSDR(  CategoryID,  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  ShowUnActive,  SKU,  Debug,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines,  SelectedShapeID,  IncludeExpressShipping,  ShowPromotionBanner,  ActiveCampaign,  IsStore);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelGallery_05_11_2018_WebSiteSDR( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object IsStore)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@ShowUnActive", SqlDbType.Bit, 0, ShowUnActive);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
		pl.Add("@SelectedShapeID", SqlDbType.Int, 0, SelectedShapeID);
		pl.Add("@IncludeExpressShipping", SqlDbType.Bit, 0, IncludeExpressShipping);
		pl.Add("@ShowPromotionBanner", SqlDbType.Bit, 0, ShowPromotionBanner);
		pl.Add("@ActiveCampaign", SqlDbType.NVarChar, 50, ActiveCampaign);
		pl.Add("@IsStore", SqlDbType.Bit, 0, IsStore);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGallery_05_11_2018",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGallery_05_11_2018_WebSiteDs( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object IsStore)
    {
            SqlDataReader reader = GetJewelGallery_05_11_2018_WebSiteSDR(  CategoryID,  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  ShowUnActive,  SKU,  Debug,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines,  SelectedShapeID,  IncludeExpressShipping,  ShowPromotionBanner,  ActiveCampaign,  IsStore);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelGallery_05_11_2018_new_WebSiteSDR( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object IsStore)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@ShowUnActive", SqlDbType.Bit, 0, ShowUnActive);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
		pl.Add("@SelectedShapeID", SqlDbType.Int, 0, SelectedShapeID);
		pl.Add("@IncludeExpressShipping", SqlDbType.Bit, 0, IncludeExpressShipping);
		pl.Add("@ShowPromotionBanner", SqlDbType.Bit, 0, ShowPromotionBanner);
		pl.Add("@ActiveCampaign", SqlDbType.NVarChar, 50, ActiveCampaign);
		pl.Add("@IsStore", SqlDbType.Bit, 0, IsStore);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGallery_05_11_2018_new",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGallery_05_11_2018_new_WebSiteDs( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object IsStore)
    {
            SqlDataReader reader = GetJewelGallery_05_11_2018_new_WebSiteSDR(  CategoryID,  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  ShowUnActive,  SKU,  Debug,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines,  SelectedShapeID,  IncludeExpressShipping,  ShowPromotionBanner,  ActiveCampaign,  IsStore);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelGallery_RF_stoneType_WebSiteSDR( Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object StoneTypes, Object CategoryIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@ShowUnActive", SqlDbType.Bit, 0, ShowUnActive);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
		pl.Add("@SelectedShapeID", SqlDbType.Int, 0, SelectedShapeID);
		pl.Add("@IncludeExpressShipping", SqlDbType.Bit, 0, IncludeExpressShipping);
		pl.Add("@ShowPromotionBanner", SqlDbType.Bit, 0, ShowPromotionBanner);
		pl.Add("@ActiveCampaign", SqlDbType.NVarChar, 50, ActiveCampaign);
		pl.Add("@StoneTypes", SqlDbType.NVarChar, 250, StoneTypes);
		pl.Add("@CategoryIDs", SqlDbType.NVarChar, 250, CategoryIDs);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGallery_RF_stoneType",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGallery_RF_stoneType_WebSiteDs( Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object StoneTypes, Object CategoryIDs)
    {
            SqlDataReader reader = GetJewelGallery_RF_stoneType_WebSiteSDR(  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  ShowUnActive,  SKU,  Debug,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines,  SelectedShapeID,  IncludeExpressShipping,  ShowPromotionBanner,  ActiveCampaign,  StoneTypes,  CategoryIDs);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelGallery_RF_stoneType_2_WebSiteSDR( Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object StoneTypeIDs, Object CategoryIDs, Object ComponentIDs, Object MetalIDs, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
		pl.Add("@SelectedShapeID", SqlDbType.Int, 0, SelectedShapeID);
		pl.Add("@IncludeExpressShipping", SqlDbType.Bit, 0, IncludeExpressShipping);
		pl.Add("@ShowPromotionBanner", SqlDbType.Bit, 0, ShowPromotionBanner);
		pl.Add("@ActiveCampaign", SqlDbType.NVarChar, 50, ActiveCampaign);
		pl.Add("@StoneTypeIDs", SqlDbType.NVarChar, 250, StoneTypeIDs);
		pl.Add("@CategoryIDs", SqlDbType.NVarChar, 250, CategoryIDs);
		pl.Add("@ComponentIDs", SqlDbType.NVarChar, 250, ComponentIDs);
		pl.Add("@MetalIDs", SqlDbType.NVarChar, 250, MetalIDs);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGallery_RF_stoneType_2",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGallery_RF_stoneType_2_WebSiteDs( Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object StoneTypeIDs, Object CategoryIDs, Object ComponentIDs, Object MetalIDs, Object Debug)
    {
            SqlDataReader reader = GetJewelGallery_RF_stoneType_2_WebSiteSDR(  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines,  SelectedShapeID,  IncludeExpressShipping,  ShowPromotionBanner,  ActiveCampaign,  StoneTypeIDs,  CategoryIDs,  ComponentIDs,  MetalIDs,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelGallery_RF_stoneType_2_for_dev_WebSiteSDR( Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object StoneTypeIDs, Object CategoryIDs, Object ComponentIDs, Object MetalIDs, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
		pl.Add("@SelectedShapeID", SqlDbType.Int, 0, SelectedShapeID);
		pl.Add("@IncludeExpressShipping", SqlDbType.Bit, 0, IncludeExpressShipping);
		pl.Add("@ShowPromotionBanner", SqlDbType.Bit, 0, ShowPromotionBanner);
		pl.Add("@ActiveCampaign", SqlDbType.NVarChar, 50, ActiveCampaign);
		pl.Add("@StoneTypeIDs", SqlDbType.NVarChar, 250, StoneTypeIDs);
		pl.Add("@CategoryIDs", SqlDbType.NVarChar, 250, CategoryIDs);
		pl.Add("@ComponentIDs", SqlDbType.NVarChar, 250, ComponentIDs);
		pl.Add("@MetalIDs", SqlDbType.NVarChar, 250, MetalIDs);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGallery_RF_stoneType_2_for_dev",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGallery_RF_stoneType_2_for_dev_WebSiteDs( Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines, Object SelectedShapeID, Object IncludeExpressShipping, Object ShowPromotionBanner, Object ActiveCampaign, Object StoneTypeIDs, Object CategoryIDs, Object ComponentIDs, Object MetalIDs, Object Debug)
    {
            SqlDataReader reader = GetJewelGallery_RF_stoneType_2_for_dev_WebSiteSDR(  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines,  SelectedShapeID,  IncludeExpressShipping,  ShowPromotionBanner,  ActiveCampaign,  StoneTypeIDs,  CategoryIDs,  ComponentIDs,  MetalIDs,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelGalleryTemp_WebSiteSDR( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@DiamondRingMatchID", SqlDbType.Int, 0, DiamondRingMatchID);
		pl.Add("@GemstoneRingMatchID", SqlDbType.Int, 0, GemstoneRingMatchID);
		pl.Add("@DiamondsPairMatchID", SqlDbType.Int, 0, DiamondsPairMatchID);
		pl.Add("@GemstonesStudsMatchID", SqlDbType.Int, 0, GemstonesStudsMatchID);
		pl.Add("@ShowUnActive", SqlDbType.Bit, 0, ShowUnActive);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
		pl.Add("@GemColor", SqlDbType.NVarChar, 50, GemColor);
		pl.Add("@ISDiamondRequired", SqlDbType.Bit, 0, ISDiamondRequired);
		pl.Add("@IsDeliveredBy", SqlDbType.Bit, 0, IsDeliveredBy);
		pl.Add("@GalleryPagePosition", SqlDbType.Int, 0, GalleryPagePosition);
		pl.Add("@IgnorePagePosition", SqlDbType.Bit, 0, IgnorePagePosition);
		pl.Add("@PagesCount", SqlDbType.Int, 0, PagesCount);
		pl.Add("@PageTopScroll", SqlDbType.NVarChar, 1024, PageTopScroll);
		pl.Add("@IsTablet", SqlDbType.Bit, 0, IsTablet);
		pl.Add("@OnlySummary", SqlDbType.Bit, 0, OnlySummary);
		pl.Add("@ViewMode", SqlDbType.Int, 0, ViewMode);
		pl.Add("@ShippingDate", SqlDbType.Int, 0, ShippingDate);
		pl.Add("@Metallica", SqlDbType.NVarChar, 50, Metallica);
		pl.Add("@ShippedByXmas", SqlDbType.Bit, 0, ShippedByXmas);
		pl.Add("@ShippedByNewYears", SqlDbType.Bit, 0, ShippedByNewYears);
		pl.Add("@ShippedByValentines", SqlDbType.Bit, 0, ShippedByValentines);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelGalleryTemp",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelGalleryTemp_WebSiteDs( Object CategoryID, Object MetalType, Object MinPrice, Object MaxPrice, Object PageNumber, Object PageSize, Object OrderBy, Object DiamondRingMatchID, Object GemstoneRingMatchID, Object DiamondsPairMatchID, Object GemstonesStudsMatchID, Object ShowUnActive, Object SKU, Object Debug, Object GemColor, Object ISDiamondRequired, Object IsDeliveredBy, Object GalleryPagePosition, Object IgnorePagePosition, Object PagesCount, Object PageTopScroll, Object IsTablet, Object OnlySummary, Object ViewMode, Object ShippingDate, Object Metallica, Object ShippedByXmas, Object ShippedByNewYears, Object ShippedByValentines)
    {
            SqlDataReader reader = GetJewelGalleryTemp_WebSiteSDR(  CategoryID,  MetalType,  MinPrice,  MaxPrice,  PageNumber,  PageSize,  OrderBy,  DiamondRingMatchID,  GemstoneRingMatchID,  DiamondsPairMatchID,  GemstonesStudsMatchID,  ShowUnActive,  SKU,  Debug,  GemColor,  ISDiamondRequired,  IsDeliveredBy,  GalleryPagePosition,  IgnorePagePosition,  PagesCount,  PageTopScroll,  IsTablet,  OnlySummary,  ViewMode,  ShippingDate,  Metallica,  ShippedByXmas,  ShippedByNewYears,  ShippedByValentines);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelItemPage_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemPage",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemPage_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetJewelItemPage_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetJewelItemXml_WebSite( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelItemXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetJewelItemXml_05_11_2018_WebSiteSDR( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemXml_05_11_2018",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemXml_05_11_2018_WebSiteDs( Object JewelID, Object IsPreview)
    {
            SqlDataReader reader = GetJewelItemXml_05_11_2018_WebSiteSDR(  JewelID,  IsPreview);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelItemXml_05_11_2018_new_WebSiteSDR( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemXml_05_11_2018_new",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemXml_05_11_2018_new_WebSiteDs( Object JewelID, Object IsPreview)
    {
            SqlDataReader reader = GetJewelItemXml_05_11_2018_new_WebSiteSDR(  JewelID,  IsPreview);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelItemXml_16102017_WebSiteSDR( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemXml_16102017",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemXml_16102017_WebSiteDs( Object JewelID, Object IsPreview)
    {
            SqlDataReader reader = GetJewelItemXml_16102017_WebSiteSDR(  JewelID,  IsPreview);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelItemXml_Old_WebSiteSDR( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemXml_Old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemXml_Old_WebSiteDs( Object JewelID, Object IsPreview)
    {
            SqlDataReader reader = GetJewelItemXml_Old_WebSiteSDR(  JewelID,  IsPreview);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelItemXml_RF_OtherQuality_Filtered_WebSiteSDR( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemXml_RF_OtherQuality_Filtered",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemXml_RF_OtherQuality_Filtered_WebSiteDs( Object JewelID, Object IsPreview)
    {
            SqlDataReader reader = GetJewelItemXml_RF_OtherQuality_Filtered_WebSiteSDR(  JewelID,  IsPreview);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelItemXml_testSharon_WebSiteSDR( Object JewelID, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelItemXml_testSharon",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelItemXml_testSharon_WebSiteDs( Object JewelID, Object IsPreview)
    {
            SqlDataReader reader = GetJewelItemXml_testSharon_WebSiteSDR(  JewelID,  IsPreview);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetJewelLifeStyleXml_WebSite( Object JewelID, Object CategoryID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelLifeStyleXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetJewelModelSkuBySku_WebSiteSDR( Object SKU)
    {
        ParamList pl = new ParamList();
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelModelSkuBySku",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelModelSkuBySku_WebSiteDs( Object SKU)
    {
            SqlDataReader reader = GetJewelModelSkuBySku_WebSiteSDR(  SKU);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelPriceNStatus_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelPriceNStatus",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelPriceNStatus_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetJewelPriceNStatus_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelRating_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelRating",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelRating_WebSiteDs()
    {
            SqlDataReader reader = GetJewelRating_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelSaleInfo_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelSaleInfo",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelSaleInfo_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetJewelSaleInfo_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetJewelSaleInfoXml_WebSite( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("WebSite.GetJewelSaleInfoXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetJewelUrlByItemID_WebSiteSDR( Object ItemID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelUrlByItemID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelUrlByItemID_WebSiteDs( Object ItemID)
    {
            SqlDataReader reader = GetJewelUrlByItemID_WebSiteSDR(  ItemID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelUrlByJeweID_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewelUrlByJeweID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelUrlByJeweID_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetJewelUrlByJeweID_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewlery_WebSiteSDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJewlery",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewlery_WebSiteDs( Object LastModify)
    {
            SqlDataReader reader = GetJewlery_WebSiteSDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJMIC_OrderDetails_WebSiteSDR( Object invoice, Object email)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice", SqlDbType.BigInt, 0, invoice);
		pl.Add("@email", SqlDbType.VarChar, 100, email);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJMIC_OrderDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJMIC_OrderDetails_WebSiteDs( Object invoice, Object email)
    {
            SqlDataReader reader = GetJMIC_OrderDetails_WebSiteSDR(  invoice,  email);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJMIC_OrderExists_WebSiteSDR( Object invoice, Object email)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice", SqlDbType.BigInt, 0, invoice);
		pl.Add("@email", SqlDbType.VarChar, 100, email);
        SqlDataReader reader;
        data.RunProc("WebSite.GetJMIC_OrderExists",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJMIC_OrderExists_WebSiteDs( Object invoice, Object email)
    {
            SqlDataReader reader = GetJMIC_OrderExists_WebSiteSDR(  invoice,  email);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetLoginRedirect_WebSiteSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetLoginRedirect",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetLoginRedirect_WebSiteDs( Object ContactID)
    {
            SqlDataReader reader = GetLoginRedirect_WebSiteSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMatchingItems_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetMatchingItems",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMatchingItems_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetMatchingItems_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMostPopular_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetMostPopular",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMostPopular_WebSiteDs()
    {
            SqlDataReader reader = GetMostPopular_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetMyAccountDataXML_WebSite( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        XmlReader reader;
        data.RunProc("WebSite.GetMyAccountDataXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetNewAccountSettingXml_WebSite( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        XmlReader reader;
        data.RunProc("WebSite.GetNewAccountSettingXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetNonAvailableMetalsXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetNonAvailableMetalsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetNYTaxByZipCode_WebSiteSDR( Object ZipCode)
    {
        ParamList pl = new ParamList();
		pl.Add("@ZipCode", SqlDbType.NVarChar, 50, ZipCode);
        SqlDataReader reader;
        data.RunProc("WebSite.GetNYTaxByZipCode",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetNYTaxByZipCode_WebSiteDs( Object ZipCode)
    {
            SqlDataReader reader = GetNYTaxByZipCode_WebSiteSDR(  ZipCode);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public String GetOrder4PoyntJson_WebSiteJSON( Object OrderID, Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
		pl.Add("@Email", SqlDbType.NVarChar, 100, Email);
        
        return data.GetJSON("WebSite.GetOrder4PoyntJson",pl);        
    }
    
    public SqlDataReader GetOrderAnalysis_WebSiteSDR( Object OrderID, Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.BigInt, 0, OrderID);
		pl.Add("@Email", SqlDbType.VarChar, 100, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderAnalysis",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderAnalysis_WebSiteDs( Object OrderID, Object Email)
    {
            SqlDataReader reader = GetOrderAnalysis_WebSiteSDR(  OrderID,  Email);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetOrderAnalysisXML_WebSite( Object OrderID, Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.VarChar, 100, OrderID);
		pl.Add("@Email", SqlDbType.VarChar, 100, Email);
        XmlReader reader;
        data.RunProc("WebSite.GetOrderAnalysisXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetOrderConfirmationEmailBody_WebSiteSDR( Object InvoiceID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderConfirmationEmailBody",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderConfirmationEmailBody_WebSiteDs( Object InvoiceID, Object Debug)
    {
            SqlDataReader reader = GetOrderConfirmationEmailBody_WebSiteSDR(  InvoiceID,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrderConfirmationEmailBodyRF_WebSiteSDR( Object InvoiceID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderConfirmationEmailBodyRF",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderConfirmationEmailBodyRF_WebSiteDs( Object InvoiceID, Object Debug)
    {
            SqlDataReader reader = GetOrderConfirmationEmailBodyRF_WebSiteSDR(  InvoiceID,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrderDetails_WebSiteSDR( Object ContactID, Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderDetails_WebSiteDs( Object ContactID, Object OrderID)
    {
            SqlDataReader reader = GetOrderDetails_WebSiteSDR(  ContactID,  OrderID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrderDetailsForDatalayer_WebSiteSDR( Object InvoiceID, Object R2NetContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
		pl.Add("@R2NetContactID", SqlDbType.Int, 0, R2NetContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderDetailsForDatalayer",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderDetailsForDatalayer_WebSiteDs( Object InvoiceID, Object R2NetContactID)
    {
            SqlDataReader reader = GetOrderDetailsForDatalayer_WebSiteSDR(  InvoiceID,  R2NetContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrderDetailsNew_WebSiteSDR( Object ContactID, Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderDetailsNew",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderDetailsNew_WebSiteDs( Object ContactID, Object OrderID)
    {
            SqlDataReader reader = GetOrderDetailsNew_WebSiteSDR(  ContactID,  OrderID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetOrderDetailsXML_WebSite( Object ContactID, Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
        XmlReader reader;
        data.RunProc("WebSite.GetOrderDetailsXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetOrderNumberInLastMinute_WebSiteSDR( Object ContactID, Object Minutes)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Minutes", SqlDbType.Float, 0, Minutes);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderNumberInLastMinute",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderNumberInLastMinute_WebSiteDs( Object ContactID, Object Minutes)
    {
            SqlDataReader reader = GetOrderNumberInLastMinute_WebSiteSDR(  ContactID,  Minutes);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrders_WebSiteSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrders",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrders_WebSiteDs( Object ContactID)
    {
            SqlDataReader reader = GetOrders_WebSiteSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrdersNew_WebSiteSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrdersNew",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrdersNew_WebSiteDs( Object ContactID)
    {
            SqlDataReader reader = GetOrdersNew_WebSiteSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrdersNew_Origin_WebSiteSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrdersNew_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrdersNew_Origin_WebSiteDs( Object ContactID)
    {
            SqlDataReader reader = GetOrdersNew_Origin_WebSiteSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetOrderTracker_WebSiteSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetOrderTracker",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetOrderTracker_WebSiteDs( Object ContactID)
    {
            SqlDataReader reader = GetOrderTracker_WebSiteSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPapAffiliate_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetPapAffiliate",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPapAffiliate_WebSiteDs()
    {
            SqlDataReader reader = GetPapAffiliate_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetParentPageIDByDiamondID_WebSiteSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetParentPageIDByDiamondID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetParentPageIDByDiamondID_WebSiteDs( Object DiamondID)
    {
            SqlDataReader reader = GetParentPageIDByDiamondID_WebSiteSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetParentPageIDByGemstoneID_WebSiteSDR( Object GemstoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetParentPageIDByGemstoneID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetParentPageIDByGemstoneID_WebSiteDs( Object GemstoneID)
    {
            SqlDataReader reader = GetParentPageIDByGemstoneID_WebSiteSDR(  GemstoneID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetParentPageIDByJewelID_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetParentPageIDByJewelID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetParentPageIDByJewelID_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetParentPageIDByJewelID_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetPariRingsXml_WebSite( Object CategoryID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
        XmlReader reader;
        data.RunProc("WebSite.GetPariRingsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetPasswordByMail_WebSiteSDR( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPasswordByMail",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPasswordByMail_WebSiteDs( Object Email)
    {
            SqlDataReader reader = GetPasswordByMail_WebSiteSDR(  Email);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPlayerXML_ToDelete_WebSiteSDR( Object ParentID, Object CategoryID, Object ItemID, Object Mode)
    {
        ParamList pl = new ParamList();
		pl.Add("@ParentID", SqlDbType.Int, 0, ParentID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@Mode", SqlDbType.NVarChar, 50, Mode);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPlayerXML_ToDelete",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPlayerXML_ToDelete_WebSiteDs( Object ParentID, Object CategoryID, Object ItemID, Object Mode)
    {
            SqlDataReader reader = GetPlayerXML_ToDelete_WebSiteSDR(  ParentID,  CategoryID,  ItemID,  Mode);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetProccessOAUpload_WebSiteSDR( Object Email, Object OrderID, Object FileName)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.VarChar, 100, Email);
		pl.Add("@OrderID", SqlDbType.VarChar, 20, OrderID);
		pl.Add("@FileName", SqlDbType.VarChar, 100, FileName);
        SqlDataReader reader;
        data.RunProc("WebSite.GetProccessOAUpload",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetProccessOAUpload_WebSiteDs( Object Email, Object OrderID, Object FileName)
    {
            SqlDataReader reader = GetProccessOAUpload_WebSiteSDR(  Email,  OrderID,  FileName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPurchasedDiamond_WebSiteSDR( Object DiamondID, Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 50, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPurchasedDiamond",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPurchasedDiamond_WebSiteDs( Object DiamondID, Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetPurchasedDiamond_WebSiteSDR(  DiamondID,  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetPurchasedGemstoneItemsXml_WebSite( Object CategoryID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Color, Object Sku)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 100, OrderBy);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@Color", SqlDbType.NVarChar, 20, Color);
		pl.Add("@Sku", SqlDbType.NVarChar, 50, Sku);
        XmlReader reader;
        data.RunProc("WebSite.GetPurchasedGemstoneItemsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetPurchasedGemstoneItemsXml_integration_WebSiteSDR( Object CategoryID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Color, Object Sku)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 100, OrderBy);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@Color", SqlDbType.NVarChar, 20, Color);
		pl.Add("@Sku", SqlDbType.NVarChar, 50, Sku);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPurchasedGemstoneItemsXml_integration",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPurchasedGemstoneItemsXml_integration_WebSiteDs( Object CategoryID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Color, Object Sku)
    {
            SqlDataReader reader = GetPurchasedGemstoneItemsXml_integration_WebSiteSDR(  CategoryID,  MetalType,  PageNumber,  PageSize,  OrderBy,  MinPrice,  MaxPrice,  Color,  Sku);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPurchasedItem_WebSiteSDR( Object PurchasedID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PurchasedID", SqlDbType.Int, 0, PurchasedID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPurchasedItem",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPurchasedItem_WebSiteDs( Object PurchasedID)
    {
            SqlDataReader reader = GetPurchasedItem_WebSiteSDR(  PurchasedID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPurchasedItem2_WebSiteSDR( Object PurchasedID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PurchasedID", SqlDbType.Int, 0, PurchasedID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPurchasedItem2",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPurchasedItem2_WebSiteDs( Object PurchasedID)
    {
            SqlDataReader reader = GetPurchasedItem2_WebSiteSDR(  PurchasedID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetPurchasedItemsNewXml_WebSite( Object CategoryID, Object OrderID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Shape, Object MinTotalCarat, Object MaxTotalCarat, Object JewelID, Object Sku)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@Shape", SqlDbType.NVarChar, 20, Shape);
		pl.Add("@MinTotalCarat", SqlDbType.Decimal, 0, MinTotalCarat);
		pl.Add("@MaxTotalCarat", SqlDbType.Decimal, 0, MaxTotalCarat);
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Sku", SqlDbType.NVarChar, 50, Sku);
        XmlReader reader;
        data.RunProc("WebSite.GetPurchasedItemsNewXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetPurchasedItemsNewXml_IntegrationTest_WebSiteSDR( Object CategoryID, Object OrderID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Shape, Object MinTotalCarat, Object MaxTotalCarat, Object JewelID, Object Sku)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@MinPrice", SqlDbType.Int, 0, MinPrice);
		pl.Add("@MaxPrice", SqlDbType.Int, 0, MaxPrice);
		pl.Add("@Shape", SqlDbType.NVarChar, 20, Shape);
		pl.Add("@MinTotalCarat", SqlDbType.Decimal, 0, MinTotalCarat);
		pl.Add("@MaxTotalCarat", SqlDbType.Decimal, 0, MaxTotalCarat);
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Sku", SqlDbType.NVarChar, 50, Sku);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPurchasedItemsNewXml_IntegrationTest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPurchasedItemsNewXml_IntegrationTest_WebSiteDs( Object CategoryID, Object OrderID, Object MetalType, Object PageNumber, Object PageSize, Object OrderBy, Object MinPrice, Object MaxPrice, Object Shape, Object MinTotalCarat, Object MaxTotalCarat, Object JewelID, Object Sku)
    {
            SqlDataReader reader = GetPurchasedItemsNewXml_IntegrationTest_WebSiteSDR(  CategoryID,  OrderID,  MetalType,  PageNumber,  PageSize,  OrderBy,  MinPrice,  MaxPrice,  Shape,  MinTotalCarat,  MaxTotalCarat,  JewelID,  Sku);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPurchasedItemUrl_WebSiteSDR( Object PurchasedID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PurchasedID", SqlDbType.Int, 0, PurchasedID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetPurchasedItemUrl",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPurchasedItemUrl_WebSiteDs( Object PurchasedID)
    {
            SqlDataReader reader = GetPurchasedItemUrl_WebSiteSDR(  PurchasedID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetRecommandedDiamondsXML_WebSite( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("WebSite.GetRecommandedDiamondsXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetRedirectUrl_WebSiteSDR( Object IsAjax)
    {
        ParamList pl = new ParamList();
		pl.Add("@IsAjax", SqlDbType.Bit, 0, IsAjax);
        SqlDataReader reader;
        data.RunProc("WebSite.GetRedirectUrl",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRedirectUrl_WebSiteDs( Object IsAjax)
    {
            SqlDataReader reader = GetRedirectUrl_WebSiteSDR(  IsAjax);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRemovedUrl_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetRemovedUrl",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRemovedUrl_WebSiteDs()
    {
            SqlDataReader reader = GetRemovedUrl_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRing_WebSiteSDR( Object JewelID, Object RecentlyViewCSV,out Object Data, Object ReturnResultSet)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
		pl.AddOut("@Data", SqlDbType.Xml, 0);
		pl.Add("@ReturnResultSet", SqlDbType.Int, 0, ReturnResultSet);
        SqlDataReader reader;
        data.RunProc("WebSite.GetRing",pl, out reader);
        
		Data= pl.GetParamValue("@Data");
        return reader;
    }
    
    public DataSet GetRing_WebSiteDs( Object JewelID, Object RecentlyViewCSV,out Object Data, Object ReturnResultSet)
    {
            SqlDataReader reader = GetRing_WebSiteSDR(  JewelID,  RecentlyViewCSV,out  Data,  ReturnResultSet);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetRingDataXml_WebSite( Object JewelID, Object RecentlyViewCSV, Object Data, Object ReturnResultSet, Object IsPreview)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
		pl.Add("@Data", SqlDbType.Xml, 0, Data);
		pl.Add("@ReturnResultSet", SqlDbType.Int, 0, ReturnResultSet);
		pl.Add("@IsPreview", SqlDbType.Bit, 0, IsPreview);
        XmlReader reader;
        data.RunProc("WebSite.GetRingDataXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetRingRecentlyView_WebSiteSDR( Object RecentlyViewCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
        SqlDataReader reader;
        data.RunProc("WebSite.GetRingRecentlyView",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRingRecentlyView_WebSiteDs( Object RecentlyViewCSV)
    {
            SqlDataReader reader = GetRingRecentlyView_WebSiteSDR(  RecentlyViewCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRingUrlBySku_WebSiteSDR( Object Sku)
    {
        ParamList pl = new ParamList();
		pl.Add("@Sku", SqlDbType.NVarChar, 20, Sku);
        SqlDataReader reader;
        data.RunProc("WebSite.GetRingUrlBySku",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRingUrlBySku_WebSiteDs( Object Sku)
    {
            SqlDataReader reader = GetRingUrlBySku_WebSiteSDR(  Sku);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetSearchItemsXml_WebSite( Object SearchTerm, Object PageNumber, Object PageSize, Object OrderBy)
    {
        ParamList pl = new ParamList();
		pl.Add("@SearchTerm", SqlDbType.NVarChar, 50, SearchTerm);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
        XmlReader reader;
        data.RunProc("WebSite.GetSearchItemsXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetSearsStoresXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetSearsStoresXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetSetCodeForFirstLoginUsers_WebSiteSDR( Object EmailAddress)
    {
        ParamList pl = new ParamList();
		pl.Add("@EmailAddress", SqlDbType.NVarChar, 256, EmailAddress);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSetCodeForFirstLoginUsers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSetCodeForFirstLoginUsers_WebSiteDs( Object EmailAddress)
    {
            SqlDataReader reader = GetSetCodeForFirstLoginUsers_WebSiteSDR(  EmailAddress);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSetLargeMovieAuthorization_WebSiteSDR( Object ContactID, Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSetLargeMovieAuthorization",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSetLargeMovieAuthorization_WebSiteDs( Object ContactID, Object DiamondID)
    {
            SqlDataReader reader = GetSetLargeMovieAuthorization_WebSiteSDR(  ContactID,  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSetSubscriberMail_WebSiteSDR( Object Email, Object AgeCategory, Object Gender, Object MaritalStatus, Object FirstName, Object LastName, Object Source, Object Birthday)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@AgeCategory", SqlDbType.NVarChar, 100, AgeCategory);
		pl.Add("@Gender", SqlDbType.NVarChar, 100, Gender);
		pl.Add("@MaritalStatus", SqlDbType.NVarChar, 100, MaritalStatus);
		pl.Add("@FirstName", SqlDbType.NVarChar, 100, FirstName);
		pl.Add("@LastName", SqlDbType.NVarChar, 100, LastName);
		pl.Add("@Source", SqlDbType.NVarChar, 100, Source);
		pl.Add("@Birthday", SqlDbType.Date, 0, Birthday);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSetSubscriberMail",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSetSubscriberMail_WebSiteDs( Object Email, Object AgeCategory, Object Gender, Object MaritalStatus, Object FirstName, Object LastName, Object Source, Object Birthday)
    {
            SqlDataReader reader = GetSetSubscriberMail_WebSiteSDR(  Email,  AgeCategory,  Gender,  MaritalStatus,  FirstName,  LastName,  Source,  Birthday);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShippingCountries_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetShippingCountries",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShippingCountries_WebSiteDs()
    {
            SqlDataReader reader = GetShippingCountries_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonTest_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonTest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonTest_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonTest_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetShopingCartDetailsFromJsonXml_WebSite( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        XmlReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml_bkp_WebSiteSDR( Object json_cart, Object AppName)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
		pl.Add("@AppName", SqlDbType.VarChar, 20, AppName);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml_bkp",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml_bkp_WebSiteDs( Object json_cart, Object AppName)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml_bkp_WebSiteSDR(  json_cart,  AppName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml_old_17062018_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml_old_17062018",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml_old_17062018_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml_old_17062018_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml_Origin_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml_Origin_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml_Origin_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml_TEST_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml_TEST",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml_TEST_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml_TEST_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml1_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml1",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml1_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml1_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml2_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml2",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml2_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml2_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsFromJsonXml3_WebSiteSDR( Object json_cart)
    {
        ParamList pl = new ParamList();
		pl.Add("@json_cart", SqlDbType.VarChar, 5000, json_cart);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsFromJsonXml3",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsFromJsonXml3_WebSiteDs( Object json_cart)
    {
            SqlDataReader reader = GetShopingCartDetailsFromJsonXml3_WebSiteSDR(  json_cart);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetShopingCartDetailsXml_WebSite( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondIDs", SqlDbType.NVarChar, 1024, DiamondIDs);
		pl.Add("@JewelIDs", SqlDbType.VarChar, 1024, JewelIDs);
		pl.Add("@GemIDs", SqlDbType.VarChar, 1024, GemIDs);
        XmlReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetShopingCartDetailsXml_Origin_WebSiteSDR( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondIDs", SqlDbType.NVarChar, 1024, DiamondIDs);
		pl.Add("@JewelIDs", SqlDbType.VarChar, 1024, JewelIDs);
		pl.Add("@GemIDs", SqlDbType.VarChar, 1024, GemIDs);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsXml_Origin",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsXml_Origin_WebSiteDs( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
            SqlDataReader reader = GetShopingCartDetailsXml_Origin_WebSiteSDR(  DiamondIDs,  JewelIDs,  GemIDs);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsXmlNew_WebSiteSDR( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondIDs", SqlDbType.NVarChar, 1024, DiamondIDs);
		pl.Add("@JewelIDs", SqlDbType.VarChar, 1024, JewelIDs);
		pl.Add("@GemIDs", SqlDbType.VarChar, 1024, GemIDs);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsXmlNew",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsXmlNew_WebSiteDs( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
            SqlDataReader reader = GetShopingCartDetailsXmlNew_WebSiteSDR(  DiamondIDs,  JewelIDs,  GemIDs);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetShopingCartDetailsXmlTest_WebSiteSDR( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondIDs", SqlDbType.NVarChar, 1024, DiamondIDs);
		pl.Add("@JewelIDs", SqlDbType.VarChar, 1024, JewelIDs);
		pl.Add("@GemIDs", SqlDbType.VarChar, 1024, GemIDs);
        SqlDataReader reader;
        data.RunProc("WebSite.GetShopingCartDetailsXmlTest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetShopingCartDetailsXmlTest_WebSiteDs( Object DiamondIDs, Object JewelIDs, Object GemIDs)
    {
            SqlDataReader reader = GetShopingCartDetailsXmlTest_WebSiteSDR(  DiamondIDs,  JewelIDs,  GemIDs);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSignetJewelPackshot_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetSignetJewelPackshot",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSignetJewelPackshot_WebSiteDs()
    {
            SqlDataReader reader = GetSignetJewelPackshot_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSiteMap_WebSiteSDR( Object Type)
    {
        ParamList pl = new ParamList();
		pl.Add("@Type", SqlDbType.VarChar, 50, Type);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSiteMap",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSiteMap_WebSiteDs( Object Type)
    {
            SqlDataReader reader = GetSiteMap_WebSiteSDR(  Type);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetSiteMapXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetSiteMapXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetSoldRingByOrderID_WebSiteSDR( Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSoldRingByOrderID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSoldRingByOrderID_WebSiteDs( Object OrderID)
    {
            SqlDataReader reader = GetSoldRingByOrderID_WebSiteSDR(  OrderID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetSoldRingCodeXml_WebSite( Object JewelID123, Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID123", SqlDbType.Int, 0, JewelID123);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        XmlReader reader;
        data.RunProc("WebSite.GetSoldRingCodeXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetSoldRingHeaderXML_WebSite( Object Code)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
        XmlReader reader;
        data.RunProc("WebSite.GetSoldRingHeaderXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetSoldRings_WebSiteSDR( Object SKU)
    {
        ParamList pl = new ParamList();
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSoldRings",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSoldRings_WebSiteDs( Object SKU)
    {
            SqlDataReader reader = GetSoldRings_WebSiteSDR(  SKU);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSoldRingsCustomers_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetSoldRingsCustomers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSoldRingsCustomers_WebSiteDs()
    {
            SqlDataReader reader = GetSoldRingsCustomers_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSoldRingsSplash_WebSiteSDR( Object CategoryID, Object ShapeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSoldRingsSplash",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSoldRingsSplash_WebSiteDs( Object CategoryID, Object ShapeID)
    {
            SqlDataReader reader = GetSoldRingsSplash_WebSiteSDR(  CategoryID,  ShapeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSoldRingsSplash1_WebSiteSDR( Object CategoryID, Object ShapeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSoldRingsSplash1",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSoldRingsSplash1_WebSiteDs( Object CategoryID, Object ShapeID)
    {
            SqlDataReader reader = GetSoldRingsSplash1_WebSiteSDR(  CategoryID,  ShapeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetSoldRingsXml_WebSite( Object SKU)
    {
        ParamList pl = new ParamList();
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
        XmlReader reader;
        data.RunProc("WebSite.GetSoldRingsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetStates_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetStates",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStates_WebSiteDs()
    {
            SqlDataReader reader = GetStates_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetStatesForRingSizeRequest_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetStatesForRingSizeRequest",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStatesForRingSizeRequest_WebSiteDs()
    {
            SqlDataReader reader = GetStatesForRingSizeRequest_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetStatesXml_WebSite()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("WebSite.GetStatesXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetStoreSalesReps_WebSiteSDR( Object StoreBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@StoreBranchID", SqlDbType.Int, 0, StoreBranchID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetStoreSalesReps",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStoreSalesReps_WebSiteDs( Object StoreBranchID)
    {
            SqlDataReader reader = GetStoreSalesReps_WebSiteSDR(  StoreBranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetStoreSalesRepsXml_WebSite( Object StoreBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@StoreBranchID", SqlDbType.Int, 0, StoreBranchID);
        XmlReader reader;
        data.RunProc("WebSite.GetStoreSalesRepsXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetStudOption_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetStudOption",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStudOption_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetStudOption_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSyncData_WebSiteSDR( Object LastModify)
    {
        ParamList pl = new ParamList();
		pl.Add("@LastModify", SqlDbType.NVarChar, 256, LastModify);
        SqlDataReader reader;
        data.RunProc("WebSite.GetSyncData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSyncData_WebSiteDs( Object LastModify)
    {
            SqlDataReader reader = GetSyncData_WebSiteSDR(  LastModify);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTaxByState_WebSiteSDR( Object State)
    {
        ParamList pl = new ParamList();
		pl.Add("@State", SqlDbType.Int, 0, State);
        SqlDataReader reader;
        data.RunProc("WebSite.GetTaxByState",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTaxByState_WebSiteDs( Object State)
    {
            SqlDataReader reader = GetTaxByState_WebSiteSDR(  State);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTaxByStateLetters_WebSiteSDR( Object StateLetters)
    {
        ParamList pl = new ParamList();
		pl.Add("@StateLetters", SqlDbType.VarChar, 10, StateLetters);
        SqlDataReader reader;
        data.RunProc("WebSite.GetTaxByStateLetters",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTaxByStateLetters_WebSiteDs( Object StateLetters)
    {
            SqlDataReader reader = GetTaxByStateLetters_WebSiteSDR(  StateLetters);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTaxByZipCodeNState_WebSiteSDR( Object ZipCode, Object State)
    {
        ParamList pl = new ParamList();
		pl.Add("@ZipCode", SqlDbType.VarChar, 50, ZipCode);
		pl.Add("@State", SqlDbType.VarChar, 50, State);
        SqlDataReader reader;
        data.RunProc("WebSite.GetTaxByZipCodeNState",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTaxByZipCodeNState_WebSiteDs( Object ZipCode, Object State)
    {
            SqlDataReader reader = GetTaxByZipCodeNState_WebSiteSDR(  ZipCode,  State);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTaxByZipCodeNStateID_WebSiteSDR( Object ZipCode, Object StateID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ZipCode", SqlDbType.VarChar, 50, ZipCode);
		pl.Add("@StateID", SqlDbType.Int, 0, StateID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetTaxByZipCodeNStateID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTaxByZipCodeNStateID_WebSiteDs( Object ZipCode, Object StateID)
    {
            SqlDataReader reader = GetTaxByZipCodeNStateID_WebSiteSDR(  ZipCode,  StateID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTaxByZipCodeNStateLetters_WebSiteSDR( Object ZipCode, Object StateLetters)
    {
        ParamList pl = new ParamList();
		pl.Add("@ZipCode", SqlDbType.VarChar, 50, ZipCode);
		pl.Add("@StateLetters", SqlDbType.VarChar, 10, StateLetters);
        SqlDataReader reader;
        data.RunProc("WebSite.GetTaxByZipCodeNStateLetters",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTaxByZipCodeNStateLetters_WebSiteDs( Object ZipCode, Object StateLetters)
    {
            SqlDataReader reader = GetTaxByZipCodeNStateLetters_WebSiteSDR(  ZipCode,  StateLetters);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTopRatedRings_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetTopRatedRings",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTopRatedRings_WebSiteDs()
    {
            SqlDataReader reader = GetTopRatedRings_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUnConfirmedOrderQueue_WebSiteSDR( Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUnConfirmedOrderQueue",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUnConfirmedOrderQueue_WebSiteDs( Object Debug)
    {
            SqlDataReader reader = GetUnConfirmedOrderQueue_WebSiteSDR(  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUrlToRedirect_WebSiteSDR( Object OldUrl)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldUrl", SqlDbType.NVarChar, 2048, OldUrl);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUrlToRedirect",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUrlToRedirect_WebSiteDs( Object OldUrl)
    {
            SqlDataReader reader = GetUrlToRedirect_WebSiteSDR(  OldUrl);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUserByContactID_WebSiteSDR( Object contactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUserByContactID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserByContactID_WebSiteDs( Object contactID)
    {
            SqlDataReader reader = GetUserByContactID_WebSiteSDR(  contactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetUserByContactIDXML_WebSite( Object contactID, Object IsStore)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
		pl.Add("@IsStore", SqlDbType.Bit, 0, IsStore);
        XmlReader reader;
        data.RunProc("WebSite.GetUserByContactIDXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetUserByMail_WebSiteSDR( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUserByMail",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserByMail_WebSiteDs( Object Email)
    {
            SqlDataReader reader = GetUserByMail_WebSiteSDR(  Email);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUserByMailAndPassword_old_20140504_WebSiteSDR( Object Email, Object HashPassword)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@HashPassword", SqlDbType.NVarChar, 256, HashPassword);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUserByMailAndPassword_old_20140504",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserByMailAndPassword_old_20140504_WebSiteDs( Object Email, Object HashPassword)
    {
            SqlDataReader reader = GetUserByMailAndPassword_old_20140504_WebSiteSDR(  Email,  HashPassword);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUserShoppingCart_WebSiteSDR( Object contactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUserShoppingCart",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserShoppingCart_WebSiteDs( Object contactID)
    {
            SqlDataReader reader = GetUserShoppingCart_WebSiteSDR(  contactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUserWishList_WebSiteSDR( Object contactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUserWishList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserWishList_WebSiteDs( Object contactID)
    {
            SqlDataReader reader = GetUserWishList_WebSiteSDR(  contactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUsRingSize_WebSiteSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("WebSite.GetUsRingSize",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUsRingSize_WebSiteDs()
    {
            SqlDataReader reader = GetUsRingSize_WebSiteSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUSTax_WebSiteSDR( Object ZipCode, Object StateLetters, Object StateID, Object TaxType, Object ItemsXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@ZipCode", SqlDbType.VarChar, 50, ZipCode);
		pl.Add("@StateLetters", SqlDbType.VarChar, 10, StateLetters);
		pl.Add("@StateID", SqlDbType.Int, 0, StateID);
		pl.Add("@TaxType", SqlDbType.NVarChar, 50, TaxType);
		pl.Add("@ItemsXml", SqlDbType.Xml, 0, ItemsXml);
        SqlDataReader reader;
        data.RunProc("WebSite.GetUSTax",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUSTax_WebSiteDs( Object ZipCode, Object StateLetters, Object StateID, Object TaxType, Object ItemsXml)
    {
            SqlDataReader reader = GetUSTax_WebSiteSDR(  ZipCode,  StateLetters,  StateID,  TaxType,  ItemsXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetWeddingRingOptions_WebSiteSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetWeddingRingOptions",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWeddingRingOptions_WebSiteDs( Object JewelID)
    {
            SqlDataReader reader = GetWeddingRingOptions_WebSiteSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetWizardGalleryXml_WebSite( Object Budget, Object ShapeID, Object MetalType, Object StyleID, Object IsDebug)
    {
        ParamList pl = new ParamList();
		pl.Add("@Budget", SqlDbType.Int, 0, Budget);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@StyleID", SqlDbType.Int, 0, StyleID);
		pl.Add("@IsDebug", SqlDbType.Bit, 0, IsDebug);
        XmlReader reader;
        data.RunProc("WebSite.GetWizardGalleryXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetWizardGalleryXml_NEW_WebSiteSDR( Object Budget, Object ShapeID, Object MetalType, Object StyleID, Object IsDebug)
    {
        ParamList pl = new ParamList();
		pl.Add("@Budget", SqlDbType.Int, 0, Budget);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@StyleID", SqlDbType.Int, 0, StyleID);
		pl.Add("@IsDebug", SqlDbType.Bit, 0, IsDebug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetWizardGalleryXml_NEW",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWizardGalleryXml_NEW_WebSiteDs( Object Budget, Object ShapeID, Object MetalType, Object StyleID, Object IsDebug)
    {
            SqlDataReader reader = GetWizardGalleryXml_NEW_WebSiteSDR(  Budget,  ShapeID,  MetalType,  StyleID,  IsDebug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetWizardGalleryXml_OLD_20140325_WebSiteSDR( Object Budget, Object ShapeID, Object MetalType, Object StyleID, Object IsDebug)
    {
        ParamList pl = new ParamList();
		pl.Add("@Budget", SqlDbType.Int, 0, Budget);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@MetalType", SqlDbType.NVarChar, 10, MetalType);
		pl.Add("@StyleID", SqlDbType.Int, 0, StyleID);
		pl.Add("@IsDebug", SqlDbType.Bit, 0, IsDebug);
        SqlDataReader reader;
        data.RunProc("WebSite.GetWizardGalleryXml_OLD_20140325",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWizardGalleryXml_OLD_20140325_WebSiteDs( Object Budget, Object ShapeID, Object MetalType, Object StyleID, Object IsDebug)
    {
            SqlDataReader reader = GetWizardGalleryXml_OLD_20140325_WebSiteSDR(  Budget,  ShapeID,  MetalType,  StyleID,  IsDebug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetWizardRing_WebSiteSDR( Object JewelID, Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.GetWizardRing",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWizardRing_WebSiteDs( Object JewelID, Object DiamondID)
    {
            SqlDataReader reader = GetWizardRing_WebSiteSDR(  JewelID,  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void INSERT_COOKIE_TRACKING_WebSite( Object BaseCookie, Object CookieID, Object IP, Object Referrer)
    {
        ParamList pl = new ParamList();
		pl.Add("@BaseCookie", SqlDbType.VarChar, 10, BaseCookie);
		pl.Add("@CookieID", SqlDbType.VarChar, 10, CookieID);
		pl.Add("@IP", SqlDbType.VarChar, 20, IP);
		pl.Add("@Referrer", SqlDbType.VarChar, 1000, Referrer);
        data.RunProc("WebSite.INSERT_COOKIE_TRACKING",pl);
        
        data.Close();        
    }
    
    public string InsertBlessingToPersonalPage_WebSite( Object Code, Object Name, Object Text)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
		pl.Add("@Name", SqlDbType.NVarChar, 100, Name);
		pl.Add("@Text", SqlDbType.NVarChar, 0, Text);
        
        string id = data.ExecuteScalar("WebSite.InsertBlessingToPersonalPage",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertConfimOrderViaMail_WebSite( Object param, Object ip)
    {
        ParamList pl = new ParamList();
		pl.Add("@param", SqlDbType.BigInt, 0, param);
		pl.Add("@ip", SqlDbType.VarChar, 100, ip);
        
        string id = data.ExecuteScalar("WebSite.InsertConfimOrderViaMail",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertCustomerCoupon_WebSite( Object CustomerId, Object FriendsXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@CustomerId", SqlDbType.Int, 0, CustomerId);
		pl.Add("@FriendsXml", SqlDbType.Xml, 0, FriendsXml);
        
        string id = data.ExecuteScalar("WebSite.InsertCustomerCoupon",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertDesignRequest_WebSite( Object Name, Object Email, Object Phone, Object Comments)
    {
        ParamList pl = new ParamList();
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 200, Email);
		pl.Add("@Phone", SqlDbType.NVarChar, 50, Phone);
		pl.Add("@Comments", SqlDbType.NVarChar, 0, Comments);
        
        string id = data.ExecuteScalar("WebSite.InsertDesignRequest",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertDesignRequestFiles_WebSite( Object FeedbackID, Object FilesXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@FeedbackID", SqlDbType.Int, 0, FeedbackID);
		pl.Add("@FilesXml", SqlDbType.Xml, 0, FilesXml);
        
        string id = data.ExecuteScalar("WebSite.InsertDesignRequestFiles",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertDiamondReview_WebSite( Object DiamondID, Object Name, Object Email, Object Description, Object Rating)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@Name", SqlDbType.VarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
        
        string id = data.ExecuteScalar("WebSite.InsertDiamondReview",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertEngagementMomentsLog_WebSite( Object Message)
    {
        ParamList pl = new ParamList();
		pl.Add("@Message", SqlDbType.NVarChar, 500, Message);
        
        string id = data.ExecuteScalar("WebSite.InsertEngagementMomentsLog",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertGemstoneReview_WebSite( Object GemstoneID, Object Name, Object Email, Object Description, Object Rating)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Name", SqlDbType.VarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
        
        string id = data.ExecuteScalar("WebSite.InsertGemstoneReview",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertHttpRequest_WebSite( Object Name, Object Data, Object ContactID, Object Notes)
    {
        ParamList pl = new ParamList();
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@Data", SqlDbType.Xml, 0, Data);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Notes", SqlDbType.NVarChar, 500, Notes);
        
        string id = data.ExecuteScalar("WebSite.InsertHttpRequest",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertIntoJewelryItemFeedback_WebSite( Object Name, Object Email, Object Phone, Object Message)
    {
        ParamList pl = new ParamList();
		pl.Add("@Name", SqlDbType.VarChar, 50, Name);
		pl.Add("@Email", SqlDbType.VarChar, 100, Email);
		pl.Add("@Phone", SqlDbType.VarChar, 20, Phone);
		pl.Add("@Message", SqlDbType.VarChar, 0, Message);
        
        string id = data.ExecuteScalar("WebSite.InsertIntoJewelryItemFeedback",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertISA_WebSite( Object order)
    {
        ParamList pl = new ParamList();
		pl.Add("@order", SqlDbType.VarChar, 20, order);
        
        string id = data.ExecuteScalar("WebSite.InsertISA",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertIvouchReviews_WebSite( Object ReviewsXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@ReviewsXml", SqlDbType.Xml, 0, ReviewsXml);
        
        string id = data.ExecuteScalar("WebSite.InsertIvouchReviews",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertJamesAllenAlert_WebSite( Object Name, Object Email, Object SearchPattern)
    {
        ParamList pl = new ParamList();
		pl.Add("@Name", SqlDbType.NVarChar, 100, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@SearchPattern", SqlDbType.Xml, 0, SearchPattern);
        
        string id = data.ExecuteScalar("WebSite.InsertJamesAllenAlert",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertJewelDiscount_WebSite( Object DiscountID, Object DiscountCatID, Object StartDate, Object EndDate, Object IsActive)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiscountID", SqlDbType.Int, 0, DiscountID);
		pl.Add("@DiscountCatID", SqlDbType.NVarChar, 50, DiscountCatID);
		pl.Add("@StartDate", SqlDbType.Date, 0, StartDate);
		pl.Add("@EndDate", SqlDbType.Date, 0, EndDate);
		pl.Add("@IsActive", SqlDbType.Bit, 0, IsActive);
        
        string id = data.ExecuteScalar("WebSite.InsertJewelDiscount",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertJewelReview_WebSite( Object JewelID, Object Name, Object Email, Object Description, Object Rating)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Name", SqlDbType.VarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
        
        string id = data.ExecuteScalar("WebSite.InsertJewelReview",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertLog404_WebSite( Object URL, Object JSONLog)
    {
        ParamList pl = new ParamList();
		pl.Add("@URL", SqlDbType.NVarChar, 2048, URL);
		pl.Add("@JSONLog", SqlDbType.NVarChar, 0, JSONLog);
        
        string id = data.ExecuteScalar("WebSite.InsertLog404",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertNewEngagementMoments_WebSite( Object FName, Object LName, Object Email, Object FianceFName, Object FianceLName, Object FianceEmail, Object CountryRegionCode, Object State, Object City, Object JaOrderNumber, Object Description, Object ImgRing, Object VideoUrl, Object SKU, Object Platform)
    {
        ParamList pl = new ParamList();
		pl.Add("@FName", SqlDbType.NVarChar, 50, FName);
		pl.Add("@LName", SqlDbType.NVarChar, 50, LName);
		pl.Add("@Email", SqlDbType.NVarChar, 50, Email);
		pl.Add("@FianceFName", SqlDbType.NVarChar, 50, FianceFName);
		pl.Add("@FianceLName", SqlDbType.NVarChar, 50, FianceLName);
		pl.Add("@FianceEmail", SqlDbType.NVarChar, 50, FianceEmail);
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 2, CountryRegionCode);
		pl.Add("@State", SqlDbType.NVarChar, 50, State);
		pl.Add("@City", SqlDbType.NVarChar, 50, City);
		pl.Add("@JaOrderNumber", SqlDbType.Int, 0, JaOrderNumber);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@ImgRing", SqlDbType.NVarChar, 100, ImgRing);
		pl.Add("@VideoUrl", SqlDbType.NVarChar, 300, VideoUrl);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Platform", SqlDbType.NVarChar, 50, Platform);
        
        string id = data.ExecuteScalar("WebSite.InsertNewEngagementMoments",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertNewEngagementMomentsImg_WebSite( Object EngagementMomentsID, Object ImgPath)
    {
        ParamList pl = new ParamList();
		pl.Add("@EngagementMomentsID", SqlDbType.Int, 0, EngagementMomentsID);
		pl.Add("@ImgPath", SqlDbType.VarChar, 500, ImgPath);
        
        string id = data.ExecuteScalar("WebSite.InsertNewEngagementMomentsImg",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertOrderAnalysisEmail_WebSite( Object email, Object invoice)
    {
        ParamList pl = new ParamList();
		pl.Add("@email", SqlDbType.VarChar, 100, email);
		pl.Add("@invoice", SqlDbType.BigInt, 0, invoice);
        
        string id = data.ExecuteScalar("WebSite.InsertOrderAnalysisEmail",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertOrderAnalysisFile_WebSite( Object FileName, Object invoice)
    {
        ParamList pl = new ParamList();
		pl.Add("@FileName", SqlDbType.VarChar, 100, FileName);
		pl.Add("@invoice", SqlDbType.BigInt, 0, invoice);
        
        string id = data.ExecuteScalar("WebSite.InsertOrderAnalysisFile",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPayPalLog_WebSite( Object forterCookie, Object data1, Object km_ai)
    {
        ParamList pl = new ParamList();
		pl.Add("@forterCookie", SqlDbType.VarChar, 50, forterCookie);
		pl.Add("@data1", SqlDbType.VarChar, 5000, data1);
		pl.Add("@km_ai", SqlDbType.VarChar, 100, km_ai);
        
        string id = data.ExecuteScalar("WebSite.InsertPayPalLog",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertReferFriend_WebSite( Object referedXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@referedXML", SqlDbType.Xml, 0, referedXML);
        
        string id = data.ExecuteScalar("WebSite.InsertReferFriend",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertReview_WebSite( Object JewelID, Object Name, Object Email, Object Description, Object Rating)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Name", SqlDbType.VarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
        
        string id = data.ExecuteScalar("WebSite.InsertReview",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertSendToFriendItemPage_WebSite( Object item_id, Object name, Object comments, Object email, Object pageref)
    {
        ParamList pl = new ParamList();
		pl.Add("@item_id", SqlDbType.Int, 0, item_id);
		pl.Add("@name", SqlDbType.VarChar, 100, name);
		pl.Add("@comments", SqlDbType.VarChar, 500, comments);
		pl.Add("@email", SqlDbType.VarChar, 200, email);
		pl.Add("@pageref", SqlDbType.VarChar, 200, pageref);
        
        string id = data.ExecuteScalar("WebSite.InsertSendToFriendItemPage",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertServiceRequestLog_WebSite( Object InvoiceID, Object NewInvoiceID, Object Action, Object SKU, Object Pass, Object ExtraData, Object TrackingNumber, Object FedExLabelUrl)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.BigInt, 0, InvoiceID);
		pl.Add("@NewInvoiceID", SqlDbType.BigInt, 0, NewInvoiceID);
		pl.Add("@Action", SqlDbType.NVarChar, 50, Action);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@Pass", SqlDbType.Bit, 0, Pass);
		pl.Add("@ExtraData", SqlDbType.NVarChar, 1000, ExtraData);
		pl.Add("@TrackingNumber", SqlDbType.NVarChar, 50, TrackingNumber);
		pl.Add("@FedExLabelUrl", SqlDbType.NVarChar, 250, FedExLabelUrl);
        
        string id = data.ExecuteScalar("WebSite.InsertServiceRequestLog",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertTaxResponse_WebSite( Object ArchiveID, Object InvoiceID, Object CartTotalCost, Object CurrencyCode, Object CurrencyRate, Object TotalTax, Object ShipsToCountry, Object Platform, Object JsonResponse)
    {
        ParamList pl = new ParamList();
		pl.Add("@ArchiveID", SqlDbType.NVarChar, 50, ArchiveID);
		pl.Add("@InvoiceID", SqlDbType.BigInt, 0, InvoiceID);
		pl.Add("@CartTotalCost", SqlDbType.Decimal, 0, CartTotalCost);
		pl.Add("@CurrencyCode", SqlDbType.NVarChar, 10, CurrencyCode);
		pl.Add("@CurrencyRate", SqlDbType.Decimal, 0, CurrencyRate);
		pl.Add("@TotalTax", SqlDbType.Decimal, 0, TotalTax);
		pl.Add("@ShipsToCountry", SqlDbType.NVarChar, 10, ShipsToCountry);
		pl.Add("@Platform", SqlDbType.NVarChar, 50, Platform);
		pl.Add("@JsonResponse", SqlDbType.NVarChar, 2500, JsonResponse);
        
        string id = data.ExecuteScalar("WebSite.InsertTaxResponse",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertTrackingCode_WebSite( Object invoice_no, Object code)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice_no", SqlDbType.BigInt, 0, invoice_no);
		pl.Add("@code", SqlDbType.VarChar, 20, code);
        
        string id = data.ExecuteScalar("WebSite.InsertTrackingCode",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertUser_old_WebSite( Object FirstName, Object LastNamne, Object Email, Object HashPassword, Object SendEmails, Object ID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@LastNamne", SqlDbType.NVarChar, 50, LastNamne);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@HashPassword", SqlDbType.NVarChar, 256, HashPassword);
		pl.Add("@SendEmails", SqlDbType.Bit, 0, SendEmails);
		pl.Add("@ID", SqlDbType.Int, 0, ID);
        
        string id = data.ExecuteScalar("WebSite.InsertUser_old",pl);
        
        data.Close();
        return id;
    }
    
    public bool IsApprovedUser_WebSite( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.IsApprovedUser",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsConfimOrderViaMail_WebSite( Object param, Object ip, Object TrackCode, Object forterToken, Object agent)
    {
        ParamList pl = new ParamList();
		pl.Add("@param", SqlDbType.BigInt, 0, param);
		pl.Add("@ip", SqlDbType.VarChar, 100, ip);
		pl.Add("@TrackCode", SqlDbType.VarChar, 20, TrackCode);
		pl.Add("@forterToken", SqlDbType.VarChar, 200, forterToken);
		pl.Add("@agent", SqlDbType.VarChar, 700, agent);
        SqlDataReader reader;
        data.RunProc("WebSite.IsConfimOrderViaMail",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsDiamondAvailable_WebSite( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("WebSite.IsDiamondAvailable",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsEmailInDB_WebSite( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.IsEmailInDB",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsHasOrders_WebSite( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("WebSite.IsHasOrders",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsItemAvailable_WebSite( Object ItemID, Object type)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@type", SqlDbType.NVarChar, 0, type);
        SqlDataReader reader;
        data.RunProc("WebSite.IsItemAvailable",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsOrderInDataLayer_WebSite( Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.Int, 0, OrderID);
        SqlDataReader reader;
        data.RunProc("WebSite.IsOrderInDataLayer",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsSavePasswordSuccess_WebSite( Object HashOldPassword, Object HashNewPassword, Object PlainTextPassword, Object ID)
    {
        ParamList pl = new ParamList();
		pl.Add("@HashOldPassword", SqlDbType.NVarChar, 256, HashOldPassword);
		pl.Add("@HashNewPassword", SqlDbType.NVarChar, 256, HashNewPassword);
		pl.Add("@PlainTextPassword", SqlDbType.NVarChar, 50, PlainTextPassword);
		pl.Add("@ID", SqlDbType.Int, 0, ID);
        SqlDataReader reader;
        data.RunProc("WebSite.IsSavePasswordSuccess",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsSignedAndApprovedEmail_WebSite( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.IsSignedAndApprovedEmail",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsUserSubscribed_WebSite( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        SqlDataReader reader;
        data.RunProc("WebSite.IsUserSubscribed",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public bool IsValidZipState_WebSite( Object ZipCode, Object StateLetters, Object StateID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ZipCode", SqlDbType.VarChar, 50, ZipCode);
		pl.Add("@StateLetters", SqlDbType.VarChar, 10, StateLetters);
		pl.Add("@StateID", SqlDbType.Int, 0, StateID);
        SqlDataReader reader;
        data.RunProc("WebSite.IsValidZipState",pl, out reader);
        reader.Read();
        
        return (bool)reader.GetSqlBoolean(0);
    }
    
    public void MarkAsEligible_WebSite( Object Email, Object SpecialOffer)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@SpecialOffer", SqlDbType.NVarChar, 50, SpecialOffer);
        data.RunProc("WebSite.MarkAsEligible",pl);
        
        data.Close();        
    }
    
    public void R2Net_SP_JA_CopyInvoiceItemsToNewInvoice_WebSite( Object old_invoice_no, Object new_invoice, Object OrderStatus, Object UserID)
    {
        ParamList pl = new ParamList();
		pl.Add("@old_invoice_no", SqlDbType.Int, 0, old_invoice_no);
		pl.Add("@new_invoice", SqlDbType.Int, 0, new_invoice);
		pl.Add("@OrderStatus", SqlDbType.Int, 0, OrderStatus);
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
        data.RunProc("WebSite.R2Net_SP_JA_CopyInvoiceItemsToNewInvoice",pl);
        
        data.Close();        
    }
    
    public void R2Net_UpdateRepairOrResizeOrder_WebSite( Object SKU, Object new_invoice, Object NewRingSize, Object UserRemarks, Object OrderStatus, Object ActionName, Object OriginalOrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@new_invoice", SqlDbType.BigInt, 0, new_invoice);
		pl.Add("@NewRingSize", SqlDbType.VarChar, 10, NewRingSize);
		pl.Add("@UserRemarks", SqlDbType.NVarChar, 700, UserRemarks);
		pl.Add("@OrderStatus", SqlDbType.Int, 0, OrderStatus);
		pl.Add("@ActionName", SqlDbType.NVarChar, 50, ActionName);
		pl.Add("@OriginalOrderID", SqlDbType.BigInt, 0, OriginalOrderID);
        data.RunProc("WebSite.R2Net_UpdateRepairOrResizeOrder",pl);
        
        data.Close();        
    }
    
    public void R2Net_UpdateReturnOrder_WebSite( Object InvoiceID, Object UserRemarks, Object ActionName)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.BigInt, 0, InvoiceID);
		pl.Add("@UserRemarks", SqlDbType.NVarChar, 700, UserRemarks);
		pl.Add("@ActionName", SqlDbType.NVarChar, 50, ActionName);
        data.RunProc("WebSite.R2Net_UpdateReturnOrder",pl);
        
        data.Close();        
    }
    
    public void RemoveAllDataFromDataBaseByEmail_WebSite( Object EmailToRemove)
    {
        ParamList pl = new ParamList();
		pl.Add("@EmailToRemove", SqlDbType.NVarChar, 256, EmailToRemove);
        data.RunProc("WebSite.RemoveAllDataFromDataBaseByEmail",pl);
        
        data.Close();        
    }
    
    public void RemoveDiamondPackshot_WebSite( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        data.RunProc("WebSite.RemoveDiamondPackshot",pl);
        
        data.Close();        
    }
    
    public void RemoveGemstone_WebSite( Object GemstoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
        data.RunProc("WebSite.RemoveGemstone",pl);
        
        data.Close();        
    }
    
    public void RemoveGemstonePackshot_WebSite( Object GemstoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
        data.RunProc("WebSite.RemoveGemstonePackshot",pl);
        
        data.Close();        
    }
    
    public void RemovePersonalPageBlessing_WebSite( Object BlessingID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BlessingID", SqlDbType.Int, 0, BlessingID);
        data.RunProc("WebSite.RemovePersonalPageBlessing",pl);
        
        data.Close();        
    }
    
    public void ResetPassword_WebSite( Object newPassword, Object HashNewPassword, Object ID)
    {
        ParamList pl = new ParamList();
		pl.Add("@newPassword", SqlDbType.NVarChar, 256, newPassword);
		pl.Add("@HashNewPassword", SqlDbType.NVarChar, 256, HashNewPassword);
		pl.Add("@ID", SqlDbType.Int, 0, ID);
        data.RunProc("WebSite.ResetPassword",pl);
        
        data.Close();        
    }
    
    public string SaveErrorLog_WebSite( Object ErrorLogID, Object Url, Object UrlReferrer, Object UserAgent, Object UserHostAddress, Object UserHostName, Object ExceptionMessage, Object ExceptionSource, Object ExceptionStackTrace, Object Date, Object Dump)
    {
        ParamList pl = new ParamList();
		pl.Add("@ErrorLogID", SqlDbType.Int, 0, ErrorLogID);
		pl.Add("@Url", SqlDbType.NVarChar, 2048, Url);
		pl.Add("@UrlReferrer", SqlDbType.NVarChar, 2048, UrlReferrer);
		pl.Add("@UserAgent", SqlDbType.NVarChar, 150, UserAgent);
		pl.Add("@UserHostAddress", SqlDbType.NVarChar, 50, UserHostAddress);
		pl.Add("@UserHostName", SqlDbType.NVarChar, 50, UserHostName);
		pl.Add("@ExceptionMessage", SqlDbType.NVarChar, 2048, ExceptionMessage);
		pl.Add("@ExceptionSource", SqlDbType.NVarChar, 2048, ExceptionSource);
		pl.Add("@ExceptionStackTrace", SqlDbType.NVarChar, 2048, ExceptionStackTrace);
		pl.Add("@Date", SqlDbType.DateTime, 0, Date);
		pl.Add("@Dump", SqlDbType.NVarChar, 0, Dump);
        
        string id = data.ExecuteScalar("WebSite.SaveErrorLog",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveJewelDeatils_WebSite( Object JewelID, Object JATitle, Object AppraisalTitle, Object Description, Object Cost)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@JATitle", SqlDbType.VarChar, 256, JATitle);
		pl.Add("@AppraisalTitle", SqlDbType.NVarChar, 256, AppraisalTitle);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Cost", SqlDbType.Money, 0, Cost);
        
        string id = data.ExecuteScalar("WebSite.SaveJewelDeatils",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveMailSubscriber_30122014_WebSite( Object MailSubscriberID, Object Email, Object IsActive)
    {
        ParamList pl = new ParamList();
		pl.Add("@MailSubscriberID", SqlDbType.Int, 0, MailSubscriberID);
		pl.Add("@Email", SqlDbType.NVarChar, 1024, Email);
		pl.Add("@IsActive", SqlDbType.Bit, 0, IsActive);
        
        string id = data.ExecuteScalar("WebSite.SaveMailSubscriber_30122014",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveRingSizeRequest_WebSite( Object xmlData, Object ItemID)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlData", SqlDbType.Xml, 0, xmlData);
		pl.Add("@ItemID", SqlDbType.VarChar, 20, ItemID);
        
        string id = data.ExecuteScalar("WebSite.SaveRingSizeRequest",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveSoldPageHeader_WebSite( Object Code, Object HeaderText)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
		pl.Add("@HeaderText", SqlDbType.NVarChar, 150, HeaderText);
        
        string id = data.ExecuteScalar("WebSite.SaveSoldPageHeader",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveUser_WebSite( Object ContactID, Object FirstName, Object LastNamne, Object Email, Object PlainTextPassword, Object HashPassword, Object SendEmails, Object ReturnBranchID, Object IP, Object notes, Object StoreID, Object SaleRepID, Object IsFacebookAccount, Object Gender, Object IsGoogleAccount)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@LastNamne", SqlDbType.NVarChar, 50, LastNamne);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@PlainTextPassword", SqlDbType.NVarChar, 50, PlainTextPassword);
		pl.Add("@HashPassword", SqlDbType.NVarChar, 256, HashPassword);
		pl.Add("@SendEmails", SqlDbType.Bit, 0, SendEmails);
		pl.Add("@ReturnBranchID", SqlDbType.Bit, 0, ReturnBranchID);
		pl.Add("@IP", SqlDbType.NVarChar, 20, IP);
		pl.Add("@notes", SqlDbType.NVarChar, 50, notes);
		pl.Add("@StoreID", SqlDbType.Int, 0, StoreID);
		pl.Add("@SaleRepID", SqlDbType.Int, 0, SaleRepID);
		pl.Add("@IsFacebookAccount", SqlDbType.Bit, 0, IsFacebookAccount);
		pl.Add("@Gender", SqlDbType.NVarChar, 50, Gender);
		pl.Add("@IsGoogleAccount", SqlDbType.Bit, 0, IsGoogleAccount);
        
        string id = data.ExecuteScalar("WebSite.SaveUser",pl);
        
        data.Close();
        return id;
    }
    
    public void SendJamesAllenAlers_WebSite()
    {
        ParamList pl = new ParamList();
        data.RunProc("WebSite.SendJamesAllenAlers",pl);
        
        data.Close();        
    }
    
    public void SendJAOrderConfirmation_WebSite()
    {
        ParamList pl = new ParamList();
        data.RunProc("WebSite.SendJAOrderConfirmation",pl);
        
        data.Close();        
    }
    
    public void SetCustomerCouponIsUsed_WebSite( Object Coupon)
    {
        ParamList pl = new ParamList();
		pl.Add("@Coupon", SqlDbType.NVarChar, 15, Coupon);
        data.RunProc("WebSite.SetCustomerCouponIsUsed",pl);
        
        data.Close();        
    }
    
    public void SetHideDiamondSocialPage_WebSite( Object Code, Object IsHide)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
		pl.Add("@IsHide", SqlDbType.Bit, 0, IsHide);
        data.RunProc("WebSite.SetHideDiamondSocialPage",pl);
        
        data.Close();        
    }
    
    public void SetJewelCategoryPosition_WebSite( Object CategoryID, Object JewelPositionXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@JewelPositionXml", SqlDbType.Xml, 0, JewelPositionXml);
        data.RunProc("WebSite.SetJewelCategoryPosition",pl);
        
        data.Close();        
    }
    
    public void SetSoldRingOnSite_WebSite( Object SoldRingXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@SoldRingXml", SqlDbType.Xml, 0, SoldRingXml);
        data.RunProc("WebSite.SetSoldRingOnSite",pl);
        
        data.Close();        
    }
    
    public void SP_INSERT_TRACKING_JA_WebSite( Object tAffiliateID, Object tBannerID, Object CategoryID, Object tPage, Object tReferrer, Object tIP, Object sID)
    {
        ParamList pl = new ParamList();
		pl.Add("@tAffiliateID", SqlDbType.Int, 0, tAffiliateID);
		pl.Add("@tBannerID", SqlDbType.Int, 0, tBannerID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@tPage", SqlDbType.VarChar, 1000, tPage);
		pl.Add("@tReferrer", SqlDbType.VarChar, 1000, tReferrer);
		pl.Add("@tIP", SqlDbType.VarChar, 100, tIP);
		pl.Add("@sID", SqlDbType.VarChar, 500, sID);
        data.RunProc("WebSite.SP_INSERT_TRACKING_JA",pl);
        
        data.Close();        
    }
    
    public void TestDiamondImagesByImageType_WebSite( Object ImageTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ImageTypeID", SqlDbType.Int, 0, ImageTypeID);
        data.RunProc("WebSite.TestDiamondImagesByImageType",pl);
        
        data.Close();        
    }
    
    public void TMP_GetSoldRingHeaderXML_WebSite( Object Code)
    {
        ParamList pl = new ParamList();
		pl.Add("@Code", SqlDbType.Int, 0, Code);
        data.RunProc("WebSite.TMP_GetSoldRingHeaderXML",pl);
        
        data.Close();        
    }
    
    public void UnsubscribeEmail_WebSite( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
        data.RunProc("WebSite.UnsubscribeEmail",pl);
        
        data.Close();        
    }
    
    public void UpdateAmazonOrder_WebSite( Object OrderReferenceID, Object Amount, Object Currency)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderReferenceID", SqlDbType.NVarChar, 50, OrderReferenceID);
		pl.Add("@Amount", SqlDbType.Decimal, 0, Amount);
		pl.Add("@Currency", SqlDbType.NVarChar, 20, Currency);
        data.RunProc("WebSite.UpdateAmazonOrder",pl);
        
        data.Close();        
    }
    
    public void UpdateConfirmFacebookAccount_WebSite( Object email)
    {
        ParamList pl = new ParamList();
		pl.Add("@email", SqlDbType.NVarChar, 0, email);
        data.RunProc("WebSite.UpdateConfirmFacebookAccount",pl);
        
        data.Close();        
    }
    
    public void UpdateCustomerShareInfo_WebSite( Object contactID, Object shareInfo, Object SYWApprove, Object SYWNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
		pl.Add("@shareInfo", SqlDbType.Bit, 0, shareInfo);
		pl.Add("@SYWApprove", SqlDbType.Bit, 0, SYWApprove);
		pl.Add("@SYWNumber", SqlDbType.NVarChar, 0, SYWNumber);
        data.RunProc("WebSite.UpdateCustomerShareInfo",pl);
        
        data.Close();        
    }
    
    public void UpdateEngagementMoments_WebSite( Object FName, Object LName, Object Email, Object FianceFName, Object FianceLName, Object FianceEmail, Object CountryRegionCode, Object State, Object City, Object JaOrderNumber, Object Description, Object ImgRing, Object VideoUrl, Object ContactID, Object UserId, Object IsActive, Object IsSelected, Object SelectImg, Object SKU)
    {
        ParamList pl = new ParamList();
		pl.Add("@FName", SqlDbType.NVarChar, 50, FName);
		pl.Add("@LName", SqlDbType.NVarChar, 50, LName);
		pl.Add("@Email", SqlDbType.NVarChar, 50, Email);
		pl.Add("@FianceFName", SqlDbType.NVarChar, 50, FianceFName);
		pl.Add("@FianceLName", SqlDbType.NVarChar, 50, FianceLName);
		pl.Add("@FianceEmail", SqlDbType.NVarChar, 50, FianceEmail);
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 2, CountryRegionCode);
		pl.Add("@State", SqlDbType.NVarChar, 50, State);
		pl.Add("@City", SqlDbType.NVarChar, 50, City);
		pl.Add("@JaOrderNumber", SqlDbType.Int, 0, JaOrderNumber);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@ImgRing", SqlDbType.NVarChar, 100, ImgRing);
		pl.Add("@VideoUrl", SqlDbType.NVarChar, 300, VideoUrl);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@UserId", SqlDbType.Int, 0, UserId);
		pl.Add("@IsActive", SqlDbType.Bit, 0, IsActive);
		pl.Add("@IsSelected", SqlDbType.Bit, 0, IsSelected);
		pl.Add("@SelectImg", SqlDbType.NVarChar, 100, SelectImg);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
        data.RunProc("WebSite.UpdateEngagementMoments",pl);
        
        data.Close();        
    }
    
    public void UpdateGoogleEE_WebSite( Object orderID, Object orderCookie)
    {
        ParamList pl = new ParamList();
		pl.Add("@orderID", SqlDbType.Int, 0, orderID);
		pl.Add("@orderCookie", SqlDbType.NVarChar, 2000, orderCookie);
        data.RunProc("WebSite.UpdateGoogleEE",pl);
        
        data.Close();        
    }
    
    public void UpdateGooglePixelCounter_WebSite( Object ID, Object InteractionType)
    {
        ParamList pl = new ParamList();
		pl.Add("@ID", SqlDbType.Int, 0, ID);
		pl.Add("@InteractionType", SqlDbType.NVarChar, 50, InteractionType);
        data.RunProc("WebSite.UpdateGooglePixelCounter",pl);
        
        data.Close();        
    }
    
    public void UpdateGooglePixelEvents_WebSite( Object ID, Object EventVisit, Object EventSignup, Object EventNewsletter, Object EventCompleteRing, Object EventViewWishlist, Object EventToggleWishlist, Object EventViewCheckout, Object EventPurchase)
    {
        ParamList pl = new ParamList();
		pl.Add("@ID", SqlDbType.Int, 0, ID);
		pl.Add("@EventVisit", SqlDbType.Bit, 0, EventVisit);
		pl.Add("@EventSignup", SqlDbType.Bit, 0, EventSignup);
		pl.Add("@EventNewsletter", SqlDbType.Bit, 0, EventNewsletter);
		pl.Add("@EventCompleteRing", SqlDbType.Bit, 0, EventCompleteRing);
		pl.Add("@EventViewWishlist", SqlDbType.Bit, 0, EventViewWishlist);
		pl.Add("@EventToggleWishlist", SqlDbType.Bit, 0, EventToggleWishlist);
		pl.Add("@EventViewCheckout", SqlDbType.Bit, 0, EventViewCheckout);
		pl.Add("@EventPurchase", SqlDbType.Bit, 0, EventPurchase);
        data.RunProc("WebSite.UpdateGooglePixelEvents",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelCategories_WebSite( Object JewelXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelXml", SqlDbType.Xml, 0, JewelXml);
        data.RunProc("WebSite.UpdateJewelCategories",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelItems_WebSite( Object CategoryID, Object JewelItemsXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@JewelItemsXml", SqlDbType.Xml, 0, JewelItemsXml);
        data.RunProc("WebSite.UpdateJewelItems",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelItemStageCache_WebSite( Object JewelID, Object ItemStageXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@ItemStageXml", SqlDbType.Xml, 0, ItemStageXml);
        data.RunProc("WebSite.UpdateJewelItemStageCache",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelLifeStyleDetails_WebSite( Object JewelID, Object LsTitle, Object CategoryID, Object LsPosition, Object SingleMainPackshotID, Object DoubleMainPackshotID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@LsTitle", SqlDbType.NVarChar, 300, LsTitle);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@LsPosition", SqlDbType.Int, 0, LsPosition);
		pl.Add("@SingleMainPackshotID", SqlDbType.Int, 0, SingleMainPackshotID);
		pl.Add("@DoubleMainPackshotID", SqlDbType.Int, 0, DoubleMainPackshotID);
        data.RunProc("WebSite.UpdateJewelLifeStyleDetails",pl);
        
        data.Close();        
    }
    
    public void UpdateOrderQueue_WebSite( Object OrderQueueID, Object OrderConfirmationSent)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderQueueID", SqlDbType.Int, 0, OrderQueueID);
		pl.Add("@OrderConfirmationSent", SqlDbType.Bit, 0, OrderConfirmationSent);
        data.RunProc("WebSite.UpdateOrderQueue",pl);
        
        data.Close();        
    }
    
    public void UpdatePayPalTrans_WebSite( Object token, Object payerId, Object PaymentAmount, Object TransactionID, Object AmountPaid, Object AddressStatus, Object ErrorMsg, Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@token", SqlDbType.VarChar, 50, token);
		pl.Add("@payerId", SqlDbType.VarChar, 50, payerId);
		pl.Add("@PaymentAmount", SqlDbType.VarChar, 50, PaymentAmount);
		pl.Add("@TransactionID", SqlDbType.VarChar, 50, TransactionID);
		pl.Add("@AmountPaid", SqlDbType.VarChar, 50, AmountPaid);
		pl.Add("@AddressStatus", SqlDbType.VarChar, 50, AddressStatus);
		pl.Add("@ErrorMsg", SqlDbType.VarChar, 2000, ErrorMsg);
		pl.Add("@OrderID", SqlDbType.BigInt, 0, OrderID);
        data.RunProc("WebSite.UpdatePayPalTrans",pl);
        
        data.Close();        
    }
    
    public void UpdateSendEmails_WebSite( Object contactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
        data.RunProc("WebSite.UpdateSendEmails",pl);
        
        data.Close();        
    }
    
    public void UpdateShoppingCart_WebSite( Object contactID, Object shoppingCartJson)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
		pl.Add("@shoppingCartJson", SqlDbType.NVarChar, 2000, shoppingCartJson);
        data.RunProc("WebSite.UpdateShoppingCart",pl);
        
        data.Close();        
    }
    
    public void UpdateSubscriberDoubleOpt_WebSite( Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@Email", SqlDbType.NVarChar, 100, Email);
        data.RunProc("WebSite.UpdateSubscriberDoubleOpt",pl);
        
        data.Close();        
    }
    
    public void UpdateUserDetails_WebSite( Object ContactID, Object EmailAddress, Object FirstName, Object LastName, Object Gender, Object SendEmail)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@EmailAddress", SqlDbType.NVarChar, 256, EmailAddress);
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@LastName", SqlDbType.NVarChar, 50, LastName);
		pl.Add("@Gender", SqlDbType.NVarChar, 50, Gender);
		pl.Add("@SendEmail", SqlDbType.Bit, 0, SendEmail);
        data.RunProc("WebSite.UpdateUserDetails",pl);
        
        data.Close();        
    }
    
    public void UpdateWishList_WebSite( Object contactID, Object wishListJson)
    {
        ParamList pl = new ParamList();
		pl.Add("@contactID", SqlDbType.Int, 0, contactID);
		pl.Add("@wishListJson", SqlDbType.NVarChar, 2000, wishListJson);
        data.RunProc("WebSite.UpdateWishList",pl);
        
        data.Close();        
    }
    
    public void UpdateYotpoRating_WebSite( Object ItemModelSku, Object RatingAvg, Object RatingCount)
    {
        ParamList pl = new ParamList();
		pl.Add("@ItemModelSku", SqlDbType.NVarChar, 100, ItemModelSku);
		pl.Add("@RatingAvg", SqlDbType.Decimal, 0, RatingAvg);
		pl.Add("@RatingCount", SqlDbType.Int, 0, RatingCount);
        data.RunProc("WebSite.UpdateYotpoRating",pl);
        
        data.Close();        
    }
    
    public void WriteAmazonLog_WebSite( Object LogData, Object OrderReferenceID, Object Type, Object Status, Object ReasonCode, Object ReasonDescription)
    {
        ParamList pl = new ParamList();
		pl.Add("@LogData", SqlDbType.NVarChar, 3000, LogData);
		pl.Add("@OrderReferenceID", SqlDbType.NVarChar, 50, OrderReferenceID);
		pl.Add("@Type", SqlDbType.NVarChar, 50, Type);
		pl.Add("@Status", SqlDbType.NVarChar, 50, Status);
		pl.Add("@ReasonCode", SqlDbType.NVarChar, 50, ReasonCode);
		pl.Add("@ReasonDescription", SqlDbType.NVarChar, 500, ReasonDescription);
        data.RunProc("WebSite.WriteAmazonLog",pl);
        
        data.Close();        
    }
    
    public void WriteEmarsysLog_WebSite( Object Exception, Object UserData, Object Method, Object Sender)
    {
        ParamList pl = new ParamList();
		pl.Add("@Exception", SqlDbType.NVarChar, 500, Exception);
		pl.Add("@UserData", SqlDbType.NVarChar, 50, UserData);
		pl.Add("@Method", SqlDbType.NVarChar, 50, Method);
		pl.Add("@Sender", SqlDbType.NVarChar, 50, Sender);
        data.RunProc("WebSite.WriteEmarsysLog",pl);
        
        data.Close();        
    }
    
    public void WriteMailChimpLog_WebSite( Object Exception, Object UserData, Object Method, Object Sender)
    {
        ParamList pl = new ParamList();
		pl.Add("@Exception", SqlDbType.NVarChar, 500, Exception);
		pl.Add("@UserData", SqlDbType.NVarChar, 200, UserData);
		pl.Add("@Method", SqlDbType.NVarChar, 50, Method);
		pl.Add("@Sender", SqlDbType.NVarChar, 50, Sender);
        data.RunProc("WebSite.WriteMailChimpLog",pl);
        
        data.Close();        
    }
    
}
