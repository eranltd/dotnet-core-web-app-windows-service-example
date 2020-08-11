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
//Functions for Segoma schema
//--------------------------------------------------------------------------------
    public void AddUpdateDiamondSupplier_Segoma( Object DataXml, Object SegomaClientID, Object MemberBranchID, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@SegomaClientID", SqlDbType.NVarChar, 50, SegomaClientID);
		pl.Add("@MemberBranchID", SqlDbType.Int, 0, MemberBranchID);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        data.RunProc("Segoma.AddUpdateDiamondSupplier",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetDiamond_SegomaSDR( Object DiamondID, Object RecentlyViewCSV, Object MailID, Object MessageID, Object GUID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@RecentlyViewCSV", SqlDbType.NVarChar, 500, RecentlyViewCSV);
		pl.Add("@MailID", SqlDbType.BigInt, 0, MailID);
		pl.Add("@MessageID", SqlDbType.BigInt, 0, MessageID);
		pl.Add("@GUID", SqlDbType.VarChar, 200, GUID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetDiamond",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamond_SegomaDs( Object DiamondID, Object RecentlyViewCSV, Object MailID, Object MessageID, Object GUID)
    {
            SqlDataReader reader = GetDiamond_SegomaSDR(  DiamondID,  RecentlyViewCSV,  MailID,  MessageID,  GUID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondDataXML_Segoma( Object DiamondID, Object SuppCode, Object WithCustomer, Object UserType, Object UserPassID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.BigInt, 0, DiamondID);
		pl.Add("@SuppCode", SqlDbType.Int, 0, SuppCode);
		pl.Add("@WithCustomer", SqlDbType.Int, 0, WithCustomer);
		pl.Add("@UserType", SqlDbType.VarChar, 1, UserType);
		pl.Add("@UserPassID", SqlDbType.Int, 0, UserPassID);
        XmlReader reader;
        data.RunProc("Segoma.GetDiamondDataXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetEmails_SegomaSDR( Object UserPassID, Object PageNumber, Object PageSize, Object OrderBy, Object FolderID, Object GUID, Object domain, Object SentFrom, Object DiamondID, Object SID, Object xmlData, Object SourceCallRequest)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserPassID", SqlDbType.Int, 0, UserPassID);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@FolderID", SqlDbType.Int, 0, FolderID);
		pl.Add("@GUID", SqlDbType.VarChar, 500, GUID);
		pl.Add("@domain", SqlDbType.VarChar, 200, domain);
		pl.Add("@SentFrom", SqlDbType.Int, 0, SentFrom);
		pl.Add("@DiamondID", SqlDbType.BigInt, 0, DiamondID);
		pl.Add("@SID", SqlDbType.Int, 0, SID);
		pl.Add("@xmlData", SqlDbType.Xml, 0, xmlData);
		pl.Add("@SourceCallRequest", SqlDbType.VarChar, 10, SourceCallRequest);
        SqlDataReader reader;
        data.RunProc("Segoma.GetEmails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetEmails_SegomaDs( Object UserPassID, Object PageNumber, Object PageSize, Object OrderBy, Object FolderID, Object GUID, Object domain, Object SentFrom, Object DiamondID, Object SID, Object xmlData, Object SourceCallRequest)
    {
            SqlDataReader reader = GetEmails_SegomaSDR(  UserPassID,  PageNumber,  PageSize,  OrderBy,  FolderID,  GUID,  domain,  SentFrom,  DiamondID,  SID,  xmlData,  SourceCallRequest);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFileUpload2_SegomaSDR( Object MemberID)
    {
        ParamList pl = new ParamList();
		pl.Add("@MemberID", SqlDbType.Int, 0, MemberID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetFileUpload2",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFileUpload2_SegomaDs( Object MemberID)
    {
            SqlDataReader reader = GetFileUpload2_SegomaSDR(  MemberID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetLoginKey_SegomaSDR( Object key)
    {
        ParamList pl = new ParamList();
		pl.Add("@key", SqlDbType.VarChar, 500, key);
        SqlDataReader reader;
        data.RunProc("Segoma.GetLoginKey",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetLoginKey_SegomaDs( Object key)
    {
            SqlDataReader reader = GetLoginKey_SegomaSDR(  key);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetMemberCardXML_Segoma( Object MemberBranchID,out Object DataXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@MemberBranchID", SqlDbType.Int, 0, MemberBranchID);
		pl.AddOut("@DataXML", SqlDbType.Xml, 0);
        XmlReader reader;
        data.RunProc("Segoma.GetMemberCardXML",pl, out reader);
        
		DataXML= pl.GetParamValue("@DataXML");
        return reader;
    }
    
    public XmlReader GetMemberCustomerCardXML_Segoma( Object CustomerBranchID,out Object DataXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@CustomerBranchID", SqlDbType.Int, 0, CustomerBranchID);
		pl.AddOut("@DataXML", SqlDbType.Xml, 0);
        XmlReader reader;
        data.RunProc("Segoma.GetMemberCustomerCardXML",pl, out reader);
        
		DataXML= pl.GetParamValue("@DataXML");
        return reader;
    }
    
    public SqlDataReader GetMemberCustomerDetails_SegomaSDR( Object CustomerID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CustomerID", SqlDbType.Int, 0, CustomerID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetMemberCustomerDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMemberCustomerDetails_SegomaDs( Object CustomerID)
    {
            SqlDataReader reader = GetMemberCustomerDetails_SegomaSDR(  CustomerID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMemberCustomers_SegomaSDR( Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object MemberID)
    {
        ParamList pl = new ParamList();
		pl.Add("@Search", SqlDbType.VarChar, 100, Search);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@MemberID", SqlDbType.Int, 0, MemberID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetMemberCustomers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMemberCustomers_SegomaDs( Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object MemberID)
    {
            SqlDataReader reader = GetMemberCustomers_SegomaSDR(  Search,  PageNumber,  PageSize,  OrderBy,  MemberID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMemberDetails_SegomaSDR( Object MemberID)
    {
        ParamList pl = new ParamList();
		pl.Add("@MemberID", SqlDbType.Int, 0, MemberID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetMemberDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMemberDetails_SegomaDs( Object MemberID)
    {
            SqlDataReader reader = GetMemberDetails_SegomaSDR(  MemberID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMembersList_SegomaSDR( Object SuppCode, Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object Src)
    {
        ParamList pl = new ParamList();
		pl.Add("@SuppCode", SqlDbType.Int, 0, SuppCode);
		pl.Add("@Search", SqlDbType.VarChar, 100, Search);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@Src", SqlDbType.VarChar, 20, Src);
        SqlDataReader reader;
        data.RunProc("Segoma.GetMembersList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMembersList_SegomaDs( Object SuppCode, Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object Src)
    {
            SqlDataReader reader = GetMembersList_SegomaSDR(  SuppCode,  Search,  PageNumber,  PageSize,  OrderBy,  Src);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPr_SaveAsMail_SegomaSDR( Object Title, Object Body, Object FromAddress, Object ToAddress, Object CCAddress, Object HTMLFormat, Object Contain, Object AttachmentFlag, Object SenderID, Object Lot, Object RecipientID, Object GUID)
    {
        ParamList pl = new ParamList();
		pl.Add("@Title", SqlDbType.VarChar, 255, Title);
		pl.Add("@Body", SqlDbType.Text, 2147483647, Body);
		pl.Add("@FromAddress", SqlDbType.Text, 2147483647, FromAddress);
		pl.Add("@ToAddress", SqlDbType.Text, 2147483647, ToAddress);
		pl.Add("@CCAddress", SqlDbType.Text, 2147483647, CCAddress);
		pl.Add("@HTMLFormat", SqlDbType.Bit, 0, HTMLFormat);
		pl.Add("@Contain", SqlDbType.Int, 0, Contain);
		pl.Add("@AttachmentFlag", SqlDbType.Bit, 0, AttachmentFlag);
		pl.Add("@SenderID", SqlDbType.Int, 0, SenderID);
		pl.Add("@Lot", SqlDbType.VarChar, 100, Lot);
		pl.Add("@RecipientID", SqlDbType.Int, 0, RecipientID);
		pl.Add("@GUID", SqlDbType.VarChar, 500, GUID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetPr_SaveAsMail",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPr_SaveAsMail_SegomaDs( Object Title, Object Body, Object FromAddress, Object ToAddress, Object CCAddress, Object HTMLFormat, Object Contain, Object AttachmentFlag, Object SenderID, Object Lot, Object RecipientID, Object GUID)
    {
            SqlDataReader reader = GetPr_SaveAsMail_SegomaSDR(  Title,  Body,  FromAddress,  ToAddress,  CCAddress,  HTMLFormat,  Contain,  AttachmentFlag,  SenderID,  Lot,  RecipientID,  GUID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRefCodeProcessList_SegomaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Segoma.GetRefCodeProcessList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRefCodeProcessList_SegomaDs()
    {
            SqlDataReader reader = GetRefCodeProcessList_SegomaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetSEDiamondsXML_Segoma( Object PageSize, Object PageNumber, Object ShapeList, Object CutList, Object ColorList, Object ColorIntensity, Object ClarityList, Object PolishList, Object SymmetryList, Object CaratFrom, Object CaratTo, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object OrderBy, Object MoreOp, Object FluorList, Object LabList, Object IDs, Object Src, Object SupplierID, Object CountOnly, Object Available, Object Working, Object MissingPic, Object MissingCert, Object Lot, Object DateFrom, Object DateTo, Object IsInvoiced, Object IsSterling, Object Missing3DImage, Object IsProcessed, Object UserPassID, Object Action, Object LotList, Object MarkAll, Object Invoice, Object DateRef)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@ShapeList", SqlDbType.NVarChar, 500, ShapeList);
		pl.Add("@CutList", SqlDbType.NVarChar, 200, CutList);
		pl.Add("@ColorList", SqlDbType.NVarChar, 100, ColorList);
		pl.Add("@ColorIntensity", SqlDbType.NVarChar, 50, ColorIntensity);
		pl.Add("@ClarityList", SqlDbType.NVarChar, 50, ClarityList);
		pl.Add("@PolishList", SqlDbType.NVarChar, 50, PolishList);
		pl.Add("@SymmetryList", SqlDbType.NVarChar, 50, SymmetryList);
		pl.Add("@CaratFrom", SqlDbType.Float, 0, CaratFrom);
		pl.Add("@CaratTo", SqlDbType.Float, 0, CaratTo);
		pl.Add("@PriceFrom", SqlDbType.Int, 0, PriceFrom);
		pl.Add("@PriceTo", SqlDbType.Int, 0, PriceTo);
		pl.Add("@DepthFrom", SqlDbType.Float, 0, DepthFrom);
		pl.Add("@DepthTo", SqlDbType.Float, 0, DepthTo);
		pl.Add("@TableFrom", SqlDbType.Float, 0, TableFrom);
		pl.Add("@TableTo", SqlDbType.Float, 0, TableTo);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@MoreOp", SqlDbType.Bit, 0, MoreOp);
		pl.Add("@FluorList", SqlDbType.NVarChar, 50, FluorList);
		pl.Add("@LabList", SqlDbType.NVarChar, 50, LabList);
		pl.Add("@IDs", SqlDbType.NVarChar, 2048, IDs);
		pl.Add("@Src", SqlDbType.NVarChar, 50, Src);
		pl.Add("@SupplierID", SqlDbType.Int, 0, SupplierID);
		pl.Add("@CountOnly", SqlDbType.Bit, 0, CountOnly);
		pl.Add("@Available", SqlDbType.Bit, 0, Available);
		pl.Add("@Working", SqlDbType.Bit, 0, Working);
		pl.Add("@MissingPic", SqlDbType.Bit, 0, MissingPic);
		pl.Add("@MissingCert", SqlDbType.Bit, 0, MissingCert);
		pl.Add("@Lot", SqlDbType.NVarChar, 50, Lot);
		pl.Add("@DateFrom", SqlDbType.Date, 0, DateFrom);
		pl.Add("@DateTo", SqlDbType.Date, 0, DateTo);
		pl.Add("@IsInvoiced", SqlDbType.NVarChar, 1, IsInvoiced);
		pl.Add("@IsSterling", SqlDbType.Bit, 0, IsSterling);
		pl.Add("@Missing3DImage", SqlDbType.Bit, 0, Missing3DImage);
		pl.Add("@IsProcessed", SqlDbType.NVarChar, 1, IsProcessed);
		pl.Add("@UserPassID", SqlDbType.Int, 0, UserPassID);
		pl.Add("@Action", SqlDbType.VarChar, 30, Action);
		pl.Add("@LotList", SqlDbType.VarChar, 0, LotList);
		pl.Add("@MarkAll", SqlDbType.VarChar, 10, MarkAll);
		pl.Add("@Invoice", SqlDbType.VarChar, 50, Invoice);
		pl.Add("@DateRef", SqlDbType.VarChar, 50, DateRef);
        XmlReader reader;
        data.RunProc("Segoma.GetSEDiamondsXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetSegomaImageRequestList_SegomaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Segoma.GetSegomaImageRequestList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSegomaImageRequestList_SegomaDs()
    {
            SqlDataReader reader = GetSegomaImageRequestList_SegomaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSegomaMembers_SegomaSDR( Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object MemberID)
    {
        ParamList pl = new ParamList();
		pl.Add("@Search", SqlDbType.VarChar, 100, Search);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@MemberID", SqlDbType.Int, 0, MemberID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetSegomaMembers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSegomaMembers_SegomaDs( Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object MemberID)
    {
            SqlDataReader reader = GetSegomaMembers_SegomaSDR(  Search,  PageNumber,  PageSize,  OrderBy,  MemberID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSegomaSnetMembers_SegomaSDR( Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object MemberID)
    {
        ParamList pl = new ParamList();
		pl.Add("@Search", SqlDbType.VarChar, 100, Search);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 1024, OrderBy);
		pl.Add("@MemberID", SqlDbType.Int, 0, MemberID);
        SqlDataReader reader;
        data.RunProc("Segoma.GetSegomaSnetMembers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSegomaSnetMembers_SegomaDs( Object Search, Object PageNumber, Object PageSize, Object OrderBy, Object MemberID)
    {
            SqlDataReader reader = GetSegomaSnetMembers_SegomaSDR(  Search,  PageNumber,  PageSize,  OrderBy,  MemberID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSetPublishDiamond_SegomaSDR( Object DiamondID, Object Budget)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.BigInt, 0, DiamondID);
		pl.Add("@Budget", SqlDbType.Float, 0, Budget);
        SqlDataReader reader;
        data.RunProc("Segoma.GetSetPublishDiamond",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSetPublishDiamond_SegomaDs( Object DiamondID, Object Budget)
    {
            SqlDataReader reader = GetSetPublishDiamond_SegomaSDR(  DiamondID,  Budget);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSuppliers_new_SegomaSDR( Object PageSize, Object PageNumber, Object B2BReferenceTypeID, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@B2BReferenceTypeID", SqlDbType.Int, 0, B2BReferenceTypeID);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@BranchIDList", SqlDbType.NVarChar, 1024, BranchIDList);
		pl.Add("@BranchName", SqlDbType.NVarChar, 50, BranchName);
		pl.Add("@CompanyIDList", SqlDbType.NVarChar, 1024, CompanyIDList);
		pl.Add("@CompanyName", SqlDbType.NVarChar, 50, CompanyName);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Segoma.GetSuppliers_new",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSuppliers_new_SegomaDs( Object PageSize, Object PageNumber, Object B2BReferenceTypeID, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName, Object Debug)
    {
            SqlDataReader reader = GetSuppliers_new_SegomaSDR(  PageSize,  PageNumber,  B2BReferenceTypeID,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSuppliers_old_SegomaSDR( Object PageSize, Object PageNumber, Object B2BReferenceTypeID, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@B2BReferenceTypeID", SqlDbType.Int, 0, B2BReferenceTypeID);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@BranchIDList", SqlDbType.NVarChar, 1024, BranchIDList);
		pl.Add("@BranchName", SqlDbType.NVarChar, 50, BranchName);
		pl.Add("@CompanyIDList", SqlDbType.NVarChar, 1024, CompanyIDList);
		pl.Add("@CompanyName", SqlDbType.NVarChar, 50, CompanyName);
        SqlDataReader reader;
        data.RunProc("Segoma.GetSuppliers_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSuppliers_old_SegomaDs( Object PageSize, Object PageNumber, Object B2BReferenceTypeID, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
            SqlDataReader reader = GetSuppliers_old_SegomaSDR(  PageSize,  PageNumber,  B2BReferenceTypeID,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUpdateSnetPhotoRefCode_SegomaSDR( Object DataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
        SqlDataReader reader;
        data.RunProc("Segoma.GetUpdateSnetPhotoRefCode",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUpdateSnetPhotoRefCode_SegomaDs( Object DataTable)
    {
            SqlDataReader reader = GetUpdateSnetPhotoRefCode_SegomaSDR(  DataTable);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string InsertMember_old_Segoma( Object SegomaClientID, Object ClientName, Object Phone, Object Email, Object Address, Object ContactName, Object CountryRegionCode, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@SegomaClientID", SqlDbType.Int, 0, SegomaClientID);
		pl.Add("@ClientName", SqlDbType.NVarChar, 50, ClientName);
		pl.Add("@Phone", SqlDbType.NVarChar, 50, Phone);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Address", SqlDbType.NVarChar, 200, Address);
		pl.Add("@ContactName", SqlDbType.NVarChar, 50, ContactName);
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 50, CountryRegionCode);
		pl.Add("@DEBUG", SqlDbType.Int, 0, DEBUG);
        
        string id = data.ExecuteScalar("Segoma.InsertMember_old",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertSupplier_old_Segoma( Object SegomaClientID, Object ClientName, Object Phone, Object Email, Object Address, Object ContactName, Object CountryRegionCode, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@SegomaClientID", SqlDbType.Int, 0, SegomaClientID);
		pl.Add("@ClientName", SqlDbType.NVarChar, 50, ClientName);
		pl.Add("@Phone", SqlDbType.NVarChar, 50, Phone);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Address", SqlDbType.NVarChar, 200, Address);
		pl.Add("@ContactName", SqlDbType.NVarChar, 50, ContactName);
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 50, CountryRegionCode);
		pl.Add("@DEBUG", SqlDbType.Int, 0, DEBUG);
        
        string id = data.ExecuteScalar("Segoma.InsertSupplier_old",pl);
        
        data.Close();
        return id;
    }
    
    public void LoginUser_Segoma( Object UserName, Object Password, Object ip)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.VarChar, 100, UserName);
		pl.Add("@Password", SqlDbType.VarChar, 100, Password);
		pl.Add("@ip", SqlDbType.VarChar, 100, ip);
        data.RunProc("Segoma.LoginUser",pl);
        
        data.Close();        
    }
    
    public void Pr_DeleteMail_Segoma( Object MailID)
    {
        ParamList pl = new ParamList();
		pl.Add("@MailID", SqlDbType.Int, 0, MailID);
        data.RunProc("Segoma.Pr_DeleteMail",pl);
        
        data.Close();        
    }
    
    public void Pr_SaveAsMailRead_Segoma( Object MailID)
    {
        ParamList pl = new ParamList();
		pl.Add("@MailID", SqlDbType.Int, 0, MailID);
        data.RunProc("Segoma.Pr_SaveAsMailRead",pl);
        
        data.Close();        
    }
    
    public void SetBase64Exists_Segoma( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        data.RunProc("Segoma.SetBase64Exists",pl);
        
        data.Close();        
    }
    
    public void SetLoginKey_Segoma( Object UserName, Object Password)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserName", SqlDbType.VarChar, 50, UserName);
		pl.Add("@Password", SqlDbType.VarChar, 50, Password);
        data.RunProc("Segoma.SetLoginKey",pl);
        
        data.Close();        
    }
    
    public void SetSegomaImageProcessFinished_Segoma( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        data.RunProc("Segoma.SetSegomaImageProcessFinished",pl);
        
        data.Close();        
    }
    
    public void UpdateCustomerForMember_Segoma( Object DataXml, Object MemberBranchID, Object CustomerBranchID, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@MemberBranchID", SqlDbType.Int, 0, MemberBranchID);
		pl.Add("@CustomerBranchID", SqlDbType.Int, 0, CustomerBranchID);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        data.RunProc("Segoma.UpdateCustomerForMember",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondSegomaRef_Segoma( Object OldBranchID, Object Lot, Object SegomaRefCode, Object SegomaPhotoID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldBranchID", SqlDbType.Int, 0, OldBranchID);
		pl.Add("@Lot", SqlDbType.NVarChar, 100, Lot);
		pl.Add("@SegomaRefCode", SqlDbType.NVarChar, 100, SegomaRefCode);
		pl.Add("@SegomaPhotoID", SqlDbType.Int, 0, SegomaPhotoID);
        data.RunProc("Segoma.UpdateDiamondSegomaRef",pl);
        
        data.Close();        
    }

    public void UpdateGemstoneSegomaRef_Segoma( Object OldBranchID, Object Lot, Object SegomaRefCode, Object SegomaPhotoID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldBranchID", SqlDbType.Int, 0, OldBranchID);
		pl.Add("@Lot", SqlDbType.NVarChar, 100, Lot);
		pl.Add("@SegomaRefCode", SqlDbType.NVarChar, 100, SegomaRefCode);
		pl.Add("@SegomaPhotoID", SqlDbType.Int, 0, SegomaPhotoID);
        data.RunProc("Segoma.UpdateGemstoneSegomaRef", pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondSegomaRefCode_Segoma( Object OldRef, Object NewRef)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldRef", SqlDbType.NVarChar, 50, OldRef);
		pl.Add("@NewRef", SqlDbType.NVarChar, 50, NewRef);
        data.RunProc("Segoma.UpdateDiamondSegomaRefCode",pl);
        
        data.Close();        
    }
    
    public void UpdateMember_Segoma( Object DataXml, Object SegomaClientID, Object MemberBranchID, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@SegomaClientID", SqlDbType.NVarChar, 50, SegomaClientID);
		pl.Add("@MemberBranchID", SqlDbType.Int, 0, MemberBranchID);
		pl.Add("@DEBUG", SqlDbType.Bit, 0, DEBUG);
        data.RunProc("Segoma.UpdateMember",pl);
        
        data.Close();        
    }
    
    public void UpdateUploadStatus_Segoma( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles, Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        data.RunProc("Segoma.UpdateUploadStatus",pl);
        
        data.Close();        
    }
    
    public void UploadDiamonds_Segoma( Object CompanyID, Object BranchID, Object InventoryFilePath, Object UploadTime, Object FirstRow, Object LastRow, Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        data.RunProc("Segoma.UploadDiamonds",pl);
        
        data.Close();        
    }
    
    public void UploadDiamondsData_Segoma( Object CompanyID, Object BranchID, Object InventoryFilePath, Object FirstRow, Object LastRow,out Object UploadUniqueID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Segoma.UploadDiamondsData",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadDiamondsDataManually_Segoma( Object SegomaClientID,out Object UploadUniqueID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@SegomaClientID", SqlDbType.NVarChar, 50, SegomaClientID);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Segoma.UploadDiamondsDataManually",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadDiamondsToR2Net_Segoma( Object DiamondsDataTable, Object DEBUG)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondsDataTable", DiamondsDataTable);
		pl.Add("@DEBUG", SqlDbType.Int, 0, DEBUG);
        data.RunProc("Segoma.UploadDiamondsToR2Net",pl);
        
        data.Close();        
    }
    
}
