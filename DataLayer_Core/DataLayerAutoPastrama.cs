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
//Functions for Pastrama schema
//--------------------------------------------------------------------------------
    public void AddFlawType_Pastrama( Object FlawTypeName)
    {
        ParamList pl = new ParamList();
		pl.Add("@FlawTypeName", SqlDbType.NVarChar, 50, FlawTypeName);
        data.RunProc("Pastrama.AddFlawType",pl);
        
        data.Close();        
    }
    
    public void CopyDataToSimilarBaseSKUs_Pastrama( Object JewelID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.CopyDataToSimilarBaseSKUs",pl);
        
        data.Close();        
    }
    
    public void CopyDataToSimilarGroupSKUs_Pastrama( Object JewelID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.CopyDataToSimilarGroupSKUs",pl);
        
        data.Close();        
    }
    
    public void CreateJewelArchive_Pastrama( Object JewelID, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        data.RunProc("Pastrama.CreateJewelArchive",pl);
        
        data.Close();        
    }
    
    public void DeleteFlawType_Pastrama( Object FlawTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FlawTypeID", SqlDbType.Int, 0, FlawTypeID);
        data.RunProc("Pastrama.DeleteFlawType",pl);
        
        data.Close();        
    }
    
    public void DeleteJewelItem_Pastrama( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        data.RunProc("Pastrama.DeleteJewelItem",pl);
        
        data.Close();        
    }
    
    public void FixOrderConfirmationEmailBody_Pastrama( Object InvoiceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@InvoiceID", SqlDbType.Int, 0, InvoiceID);
        data.RunProc("Pastrama.FixOrderConfirmationEmailBody",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetAllCountry_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetAllCountry",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAllCountry_PastramaDs()
    {
            SqlDataReader reader = GetAllCountry_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAllEngagementMomentItems_PastramaSDR( Object CountryRegionCode, Object City, Object State, Object Fname, Object Lname, Object FianceFname, Object FianceLname)
    {
        ParamList pl = new ParamList();
		pl.Add("@CountryRegionCode", SqlDbType.NVarChar, 2, CountryRegionCode);
		pl.Add("@City", SqlDbType.NVarChar, 50, City);
		pl.Add("@State", SqlDbType.NVarChar, 50, State);
		pl.Add("@Fname", SqlDbType.NVarChar, 50, Fname);
		pl.Add("@Lname", SqlDbType.NVarChar, 50, Lname);
		pl.Add("@FianceFname", SqlDbType.NVarChar, 50, FianceFname);
		pl.Add("@FianceLname", SqlDbType.NVarChar, 50, FianceLname);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetAllEngagementMomentItems",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAllEngagementMomentItems_PastramaDs( Object CountryRegionCode, Object City, Object State, Object Fname, Object Lname, Object FianceFname, Object FianceLname)
    {
            SqlDataReader reader = GetAllEngagementMomentItems_PastramaSDR(  CountryRegionCode,  City,  State,  Fname,  Lname,  FianceFname,  FianceLname);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAllUsState_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetAllUsState",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAllUsState_PastramaDs()
    {
            SqlDataReader reader = GetAllUsState_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAuthorizationGuidForLargeMovieUsersList_PastramaSDR( Object FName, Object LName, Object Email)
    {
        ParamList pl = new ParamList();
		pl.Add("@FName", SqlDbType.NVarChar, 100, FName);
		pl.Add("@LName", SqlDbType.NVarChar, 100, LName);
		pl.Add("@Email", SqlDbType.NVarChar, 100, Email);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetAuthorizationGuidForLargeMovieUsersList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAuthorizationGuidForLargeMovieUsersList_PastramaDs( Object FName, Object LName, Object Email)
    {
            SqlDataReader reader = GetAuthorizationGuidForLargeMovieUsersList_PastramaSDR(  FName,  LName,  Email);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public String GetB2BReferenceJSON_PastramaJSON( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        
        return data.GetJSON("Pastrama.GetB2BReferenceJSON",pl);        
    }
    
    public XmlReader GetCategoryGroupsDataSourceJAXML_Pastrama( Object WebSiteID)
    {
        ParamList pl = new ParamList();
		pl.Add("@WebSiteID", SqlDbType.Int, 0, WebSiteID);
        XmlReader reader;
        data.RunProc("Pastrama.GetCategoryGroupsDataSourceJAXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetCategoryGroupsDataSourceXML_Pastrama( Object WebSiteID)
    {
        ParamList pl = new ParamList();
		pl.Add("@WebSiteID", SqlDbType.Int, 0, WebSiteID);
        XmlReader reader;
        data.RunProc("Pastrama.GetCategoryGroupsDataSourceXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetCategoryGroupsDataSourceXML_old_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetCategoryGroupsDataSourceXML_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCategoryGroupsDataSourceXML_old_PastramaDs()
    {
            SqlDataReader reader = GetCategoryGroupsDataSourceXML_old_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCertsStatusByBranch_PastramaSDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetCertsStatusByBranch",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCertsStatusByBranch_PastramaDs( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetCertsStatusByBranch_PastramaSDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondAmountByFlawTypeID_PastramaSDR( Object FlawTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FlawTypeID", SqlDbType.Int, 0, FlawTypeID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetDiamondAmountByFlawTypeID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondAmountByFlawTypeID_PastramaDs( Object FlawTypeID)
    {
            SqlDataReader reader = GetDiamondAmountByFlawTypeID_PastramaSDR(  FlawTypeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondCard_PastramaSDR( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetDiamondCard",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondCard_PastramaDs( Object DiamondID)
    {
            SqlDataReader reader = GetDiamondCard_PastramaSDR(  DiamondID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondFlaws_PastramaSDR( Object ProductID, Object Tested)
    {
        ParamList pl = new ParamList();
		pl.Add("@ProductID", SqlDbType.Int, 0, ProductID);
		pl.Add("@Tested", SqlDbType.Bit, 0, Tested);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetDiamondFlaws",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondFlaws_PastramaDs( Object ProductID, Object Tested)
    {
            SqlDataReader reader = GetDiamondFlaws_PastramaSDR(  ProductID,  Tested);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondReview_PastramaSDR( Object DiamondReviewID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondReviewID", SqlDbType.Int, 0, DiamondReviewID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetDiamondReview",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondReview_PastramaDs( Object DiamondReviewID)
    {
            SqlDataReader reader = GetDiamondReview_PastramaSDR(  DiamondReviewID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondReviews_PastramaSDR( Object PageSize, Object PageNumber, Object OrderBy)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetDiamondReviews",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondReviews_PastramaDs( Object PageSize, Object PageNumber, Object OrderBy)
    {
            SqlDataReader reader = GetDiamondReviews_PastramaSDR(  PageSize,  PageNumber,  OrderBy);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondStock_PastramaSDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetDiamondStock",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondStock_PastramaDs( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetDiamondStock_PastramaSDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetEngagementMomentsItem_PastramaSDR( Object EngagementMomentID)
    {
        ParamList pl = new ParamList();
		pl.Add("@EngagementMomentID", SqlDbType.Int, 0, EngagementMomentID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetEngagementMomentsItem",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetEngagementMomentsItem_PastramaDs( Object EngagementMomentID)
    {
            SqlDataReader reader = GetEngagementMomentsItem_PastramaSDR(  EngagementMomentID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFlawTypes_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetFlawTypes",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFlawTypes_PastramaDs()
    {
            SqlDataReader reader = GetFlawTypes_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetFlawTypesXML_Pastrama()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("Pastrama.GetFlawTypesXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetGemstoneReview_PastramaSDR( Object GemstoneReviewID)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneReviewID", SqlDbType.Int, 0, GemstoneReviewID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetGemstoneReview",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGemstoneReview_PastramaDs( Object GemstoneReviewID)
    {
            SqlDataReader reader = GetGemstoneReview_PastramaSDR(  GemstoneReviewID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetGemstoneReviews_PastramaSDR( Object PageSize, Object PageNumber, Object OrderBy)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetGemstoneReviews",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetGemstoneReviews_PastramaDs( Object PageSize, Object PageNumber, Object OrderBy)
    {
            SqlDataReader reader = GetGemstoneReviews_PastramaSDR(  PageSize,  PageNumber,  OrderBy);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetInsertNewJewel_PastramaSDR( Object SupplierBranchID, Object CloneJewelID, Object CategoryID, Object ContactID, Object WebSiteID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierBranchID", SqlDbType.Int, 0, SupplierBranchID);
		pl.Add("@CloneJewelID", SqlDbType.Int, 0, CloneJewelID);
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@WebSiteID", SqlDbType.Int, 0, WebSiteID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetInsertNewJewel",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInsertNewJewel_PastramaDs( Object SupplierBranchID, Object CloneJewelID, Object CategoryID, Object ContactID, Object WebSiteID)
    {
            SqlDataReader reader = GetInsertNewJewel_PastramaSDR(  SupplierBranchID,  CloneJewelID,  CategoryID,  ContactID,  WebSiteID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJATrackerStatus_PastramaSDR( Object invoice_no)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice_no", SqlDbType.BigInt, 0, invoice_no);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJATrackerStatus",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJATrackerStatus_PastramaDs( Object invoice_no)
    {
            SqlDataReader reader = GetJATrackerStatus_PastramaSDR(  invoice_no);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetJATrackerStatusXml_Pastrama( Object invoice_no)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice_no", SqlDbType.BigInt, 0, invoice_no);
        XmlReader reader;
        data.RunProc("Pastrama.GetJATrackerStatusXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetJewelFormDataSource_PastramaSDR( Object JewelID, Object ArchiveIndex, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@ArchiveIndex", SqlDbType.Int, 0, ArchiveIndex);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelFormDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelFormDataSource_PastramaDs( Object JewelID, Object ArchiveIndex, Object Debug)
    {
            SqlDataReader reader = GetJewelFormDataSource_PastramaSDR(  JewelID,  ArchiveIndex,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelFormDataSourceArchive_PastramaSDR( Object JewelID, Object ArchiveIndex, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@ArchiveIndex", SqlDbType.Int, 0, ArchiveIndex);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelFormDataSourceArchive",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelFormDataSourceArchive_PastramaDs( Object JewelID, Object ArchiveIndex, Object Debug)
    {
            SqlDataReader reader = GetJewelFormDataSourceArchive_PastramaSDR(  JewelID,  ArchiveIndex,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelFormDataSourceHeadRevision_PastramaSDR( Object JewelID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Debug", SqlDbType.Int, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelFormDataSourceHeadRevision",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelFormDataSourceHeadRevision_PastramaDs( Object JewelID, Object Debug)
    {
            SqlDataReader reader = GetJewelFormDataSourceHeadRevision_PastramaSDR(  JewelID,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelFormStaticData_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelFormStaticData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelFormStaticData_PastramaDs()
    {
            SqlDataReader reader = GetJewelFormStaticData_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelReview_PastramaSDR( Object JewelReviewID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelReviewID", SqlDbType.Int, 0, JewelReviewID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelReview",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelReview_PastramaDs( Object JewelReviewID)
    {
            SqlDataReader reader = GetJewelReview_PastramaSDR(  JewelReviewID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelReviews_PastramaSDR( Object PageSize, Object PageNumber, Object OrderBy, Object DateFrom, Object DateTo)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@DateFrom", SqlDbType.DateTime, 0, DateFrom);
		pl.Add("@DateTo", SqlDbType.DateTime, 0, DateTo);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelReviews",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelReviews_PastramaDs( Object PageSize, Object PageNumber, Object OrderBy, Object DateFrom, Object DateTo)
    {
            SqlDataReader reader = GetJewelReviews_PastramaSDR(  PageSize,  PageNumber,  OrderBy,  DateFrom,  DateTo);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryComponentsGridDataSource_PastramaSDR( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelryComponentsGridDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryComponentsGridDataSource_PastramaDs( Object JewelID)
    {
            SqlDataReader reader = GetJewelryComponentsGridDataSource_PastramaSDR(  JewelID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryComponentsGridDataSourceArchive_PastramaSDR( Object JewelID, Object JewelDateArchived, Object JewelComponentArchive)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@JewelDateArchived", SqlDbType.DateTime, 0, JewelDateArchived);
		pl.Add("@JewelComponentArchive", SqlDbType.DateTime, 0, JewelComponentArchive);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelryComponentsGridDataSourceArchive",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryComponentsGridDataSourceArchive_PastramaDs( Object JewelID, Object JewelDateArchived, Object JewelComponentArchive)
    {
            SqlDataReader reader = GetJewelryComponentsGridDataSourceArchive_PastramaSDR(  JewelID,  JewelDateArchived,  JewelComponentArchive);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryGridDataSource_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelryGridDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryGridDataSource_PastramaDs()
    {
            SqlDataReader reader = GetJewelryGridDataSource_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryGridDataSourceFiltered_PastramaSDR( Object Query, Object PageSize, Object PageNumber, Object WebSiteID)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@WebSiteID", SqlDbType.Int, 0, WebSiteID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelryGridDataSourceFiltered",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryGridDataSourceFiltered_PastramaDs( Object Query, Object PageSize, Object PageNumber, Object WebSiteID)
    {
            SqlDataReader reader = GetJewelryGridDataSourceFiltered_PastramaSDR(  Query,  PageSize,  PageNumber,  WebSiteID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryGridDataSourceFilteredJA_PastramaSDR( Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelryGridDataSourceFilteredJA",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryGridDataSourceFilteredJA_PastramaDs( Object Query, Object PageSize, Object PageNumber)
    {
            SqlDataReader reader = GetJewelryGridDataSourceFilteredJA_PastramaSDR(  Query,  PageSize,  PageNumber);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelrySupplierCard_PastramaSDR( Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetJewelrySupplierCard",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelrySupplierCard_PastramaDs( Object BranchID, Object Debug)
    {
            SqlDataReader reader = GetJewelrySupplierCard_PastramaSDR(  BranchID,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelrySuppliers_PastramaSDR( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
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
        data.RunProc("Pastrama.GetJewelrySuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelrySuppliers_PastramaDs( Object PageSize, Object PageNumber, Object OrderBy, Object BranchIDList, Object BranchName, Object CompanyIDList, Object CompanyName)
    {
            SqlDataReader reader = GetJewelrySuppliers_PastramaSDR(  PageSize,  PageNumber,  OrderBy,  BranchIDList,  BranchName,  CompanyIDList,  CompanyName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMarketingCategories_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetMarketingCategories",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMarketingCategories_PastramaDs()
    {
            SqlDataReader reader = GetMarketingCategories_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMarketingCategoryData_PastramaSDR( Object invoice_no, Object categoryid)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice_no", SqlDbType.BigInt, 0, invoice_no);
		pl.Add("@categoryid", SqlDbType.Int, 0, categoryid);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetMarketingCategoryData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMarketingCategoryData_PastramaDs( Object invoice_no, Object categoryid)
    {
            SqlDataReader reader = GetMarketingCategoryData_PastramaSDR(  invoice_no,  categoryid);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMarketingEmailFields_PastramaSDR( Object invoice_no)
    {
        ParamList pl = new ParamList();
		pl.Add("@invoice_no", SqlDbType.BigInt, 0, invoice_no);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetMarketingEmailFields",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMarketingEmailFields_PastramaDs( Object invoice_no)
    {
            SqlDataReader reader = GetMarketingEmailFields_PastramaSDR(  invoice_no);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMetalPriceHistory_PastramaSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetMetalPriceHistory",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMetalPriceHistory_PastramaDs( Object BranchID)
    {
            SqlDataReader reader = GetMetalPriceHistory_PastramaSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetNewCategoryGroupsDataSourceXML_Pastrama()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("Pastrama.GetNewCategoryGroupsDataSourceXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetPackshots_PastramaSDR( Object FileUploadID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FileUploadID", SqlDbType.Int, 0, FileUploadID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetPackshots",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPackshots_PastramaDs( Object FileUploadID)
    {
            SqlDataReader reader = GetPackshots_PastramaSDR(  FileUploadID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPendingPackshotProcess_PastramaSDR( Object SKU, Object CreateDateFrom, Object CreateDateTo)
    {
        ParamList pl = new ParamList();
		pl.Add("@SKU", SqlDbType.NVarChar, 100, SKU);
		pl.Add("@CreateDateFrom", SqlDbType.DateTime, 0, CreateDateFrom);
		pl.Add("@CreateDateTo", SqlDbType.DateTime, 0, CreateDateTo);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetPendingPackshotProcess",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPendingPackshotProcess_PastramaDs( Object SKU, Object CreateDateFrom, Object CreateDateTo)
    {
            SqlDataReader reader = GetPendingPackshotProcess_PastramaSDR(  SKU,  CreateDateFrom,  CreateDateTo);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSearchMatchingItems_PastramaSDR( Object JewelID, Object SKU, Object ItemID, Object ItemName)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@ItemName", SqlDbType.NVarChar, 50, ItemName);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetSearchMatchingItems",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSearchMatchingItems_PastramaDs( Object JewelID, Object SKU, Object ItemID, Object ItemName)
    {
            SqlDataReader reader = GetSearchMatchingItems_PastramaSDR(  JewelID,  SKU,  ItemID,  ItemName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSearchRelatedItems_PastramaSDR( Object JewelID, Object SKU, Object ItemID, Object ItemName)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@SKU", SqlDbType.NVarChar, 50, SKU);
		pl.Add("@ItemID", SqlDbType.Int, 0, ItemID);
		pl.Add("@ItemName", SqlDbType.NVarChar, 50, ItemName);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetSearchRelatedItems",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSearchRelatedItems_PastramaDs( Object JewelID, Object SKU, Object ItemID, Object ItemName)
    {
            SqlDataReader reader = GetSearchRelatedItems_PastramaSDR(  JewelID,  SKU,  ItemID,  ItemName);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetServiceRequestList_PastramaSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("Pastrama.GetServiceRequestList",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetServiceRequestList_PastramaDs()
    {
            SqlDataReader reader = GetServiceRequestList_PastramaSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetStock_PastramaSDR( Object PageSize, Object PageNumber, Object OrderBy, Object ProductIDList, Object SupplierBranchID, Object LotList, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorIDFrom, Object ColorIDTo, Object HasPic, Object IsOnJared, Object IsOnKay, Object Tested)
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
		pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
		pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
		pl.Add("@Tested", SqlDbType.NVarChar, 20, Tested);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetStock",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStock_PastramaDs( Object PageSize, Object PageNumber, Object OrderBy, Object ProductIDList, Object SupplierBranchID, Object LotList, Object ShapeID, Object CaratFrom, Object CaratTo, Object ColorIDFrom, Object ColorIDTo, Object HasPic, Object IsOnJared, Object IsOnKay, Object Tested)
    {
            SqlDataReader reader = GetStock_PastramaSDR(  PageSize,  PageNumber,  OrderBy,  ProductIDList,  SupplierBranchID,  LotList,  ShapeID,  CaratFrom,  CaratTo,  ColorIDFrom,  ColorIDTo,  HasPic,  IsOnJared,  IsOnKay,  Tested);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierListForAllocationUpdate_PastramaSDR( Object JewelIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelIDs", SqlDbType.NVarChar, 200, JewelIDs);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetSupplierListForAllocationUpdate",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierListForAllocationUpdate_PastramaDs( Object JewelIDs)
    {
            SqlDataReader reader = GetSupplierListForAllocationUpdate_PastramaSDR(  JewelIDs);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSuppliersStats_PastramaSDR( Object UploadDate, Object PageSize, Object PageNumber, Object OrderBy)
    {
        ParamList pl = new ParamList();
		pl.Add("@UploadDate", SqlDbType.DateTime, 0, UploadDate);
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetSuppliersStats",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSuppliersStats_PastramaDs( Object UploadDate, Object PageSize, Object PageNumber, Object OrderBy)
    {
            SqlDataReader reader = GetSuppliersStats_PastramaSDR(  UploadDate,  PageSize,  PageNumber,  OrderBy);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public String GetTrueHeartApprovalDataSourceJSON_PastramaJSON( Object Query, Object Take, Object Skip, Object Sort)
    {
        ParamList pl = new ParamList();
		pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
		pl.Add("@Take", SqlDbType.NVarChar, 10, Take);
		pl.Add("@Skip", SqlDbType.NVarChar, 10, Skip);
		pl.Add("@Sort", SqlDbType.NVarChar, 100, Sort);
        
        return data.GetJSON("Pastrama.GetTrueHeartApprovalDataSourceJSON",pl);        
    }
    
    public String GetTrueHeartCertNumDataSourceJSON_PastramaJSON( Object CertNum)
    {
        ParamList pl = new ParamList();
		pl.Add("@CertNum", SqlDbType.NVarChar, 50, CertNum);
        
        return data.GetJSON("Pastrama.GetTrueHeartCertNumDataSourceJSON",pl);        
    }
    
    public String GetTrueHeartsAuthorizedSuppliersJSON_PastramaJSON()
    {
        ParamList pl = new ParamList();
        
        return data.GetJSON("Pastrama.GetTrueHeartsAuthorizedSuppliersJSON",pl);        
    }
    
    public SqlDataReader GetUpdateJewelFormDataSource_PastramaSDR( Object dataXml, Object ContactID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@dataXml", SqlDbType.Xml, 0, dataXml);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetUpdateJewelFormDataSource",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUpdateJewelFormDataSource_PastramaDs( Object dataXml, Object ContactID, Object Debug)
    {
            SqlDataReader reader = GetUpdateJewelFormDataSource_PastramaSDR(  dataXml,  ContactID,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUpdateJewelFormPricing_PastramaSDR( Object DataXml, Object ContactID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetUpdateJewelFormPricing",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUpdateJewelFormPricing_PastramaDs( Object DataXml, Object ContactID, Object Debug)
    {
            SqlDataReader reader = GetUpdateJewelFormPricing_PastramaSDR(  DataXml,  ContactID,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetUserDetailsByOrderID_PastramaSDR( Object OrderID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OrderID", SqlDbType.BigInt, 0, OrderID);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetUserDetailsByOrderID",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetUserDetailsByOrderID_PastramaDs( Object OrderID)
    {
            SqlDataReader reader = GetUserDetailsByOrderID_PastramaSDR(  OrderID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetWebsitePurchasers_PastramaSDR( Object SinceDate, Object Coupon, Object OptedIn, Object DoubleOptIn)
    {
        ParamList pl = new ParamList();
		pl.Add("@SinceDate", SqlDbType.Date, 0, SinceDate);
		pl.Add("@Coupon", SqlDbType.NVarChar, 50, Coupon);
		pl.Add("@OptedIn", SqlDbType.Bit, 0, OptedIn);
		pl.Add("@DoubleOptIn", SqlDbType.Bit, 0, DoubleOptIn);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetWebsitePurchasers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWebsitePurchasers_PastramaDs( Object SinceDate, Object Coupon, Object OptedIn, Object DoubleOptIn)
    {
            SqlDataReader reader = GetWebsitePurchasers_PastramaSDR(  SinceDate,  Coupon,  OptedIn,  DoubleOptIn);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetWebsitePurchasersWithTracking_PastramaSDR( Object SinceDate)
    {
        ParamList pl = new ParamList();
		pl.Add("@SinceDate", SqlDbType.Date, 0, SinceDate);
        SqlDataReader reader;
        data.RunProc("Pastrama.GetWebsitePurchasersWithTracking",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetWebsitePurchasersWithTracking_PastramaDs( Object SinceDate)
    {
            SqlDataReader reader = GetWebsitePurchasersWithTracking_PastramaSDR(  SinceDate);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void RefreshJAJewelGallery_Pastrama()
    {
        ParamList pl = new ParamList();
        data.RunProc("Pastrama.RefreshJAJewelGallery",pl);
        
        data.Close();        
    }
    
    public void RemoveB2BReference_Pastrama( Object B2BReferenceID)
    {
        ParamList pl = new ParamList();
		pl.Add("@B2BReferenceID", SqlDbType.Int, 0, B2BReferenceID);
        data.RunProc("Pastrama.RemoveB2BReference",pl);
        
        data.Close();        
    }
    
    public void RemoveDiamondCertificate_Pastrama( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        data.RunProc("Pastrama.RemoveDiamondCertificate",pl);
        
        data.Close();        
    }
    
    public string SaveDiamondCard_Pastrama( Object DiamondID, Object IsOnJamesAllen, Object IsOnJared, Object IsOnKay, Object Notes)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@IsOnJamesAllen", SqlDbType.Bit, 0, IsOnJamesAllen);
		pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
		pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
		pl.Add("@Notes", SqlDbType.NVarChar, 1000, Notes);
        
        string id = data.ExecuteScalar("Pastrama.SaveDiamondCard",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveDiamondReview_Pastrama( Object DiamondReviewID, Object DiamondID, Object Name, Object Email, Object Description, Object Rating, Object Date, Object IsApproved)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondReviewID", SqlDbType.Int, 0, DiamondReviewID);
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
		pl.Add("@Date", SqlDbType.DateTime, 0, Date);
		pl.Add("@IsApproved", SqlDbType.Bit, 0, IsApproved);
        
        string id = data.ExecuteScalar("Pastrama.SaveDiamondReview",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveGemstoneReview_Pastrama( Object GemstoneReviewID, Object GemstoneID, Object Name, Object Email, Object Description, Object Rating, Object Date, Object IsApproved)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneReviewID", SqlDbType.Int, 0, GemstoneReviewID);
		pl.Add("@GemstoneID", SqlDbType.Int, 0, GemstoneID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
		pl.Add("@Date", SqlDbType.DateTime, 0, Date);
		pl.Add("@IsApproved", SqlDbType.Bit, 0, IsApproved);
        
        string id = data.ExecuteScalar("Pastrama.SaveGemstoneReview",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveJewelPriceLog_Pastrama( Object ContactID, Object CostType, Object FixedCost, Object Base, Object Factor, Object Extra, Object PriceType, Object FixedPrice, Object Margin)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@CostType", SqlDbType.NVarChar, 50, CostType);
		pl.Add("@FixedCost", SqlDbType.NVarChar, 50, FixedCost);
		pl.Add("@Base", SqlDbType.NVarChar, 50, Base);
		pl.Add("@Factor", SqlDbType.NVarChar, 50, Factor);
		pl.Add("@Extra", SqlDbType.NVarChar, 50, Extra);
		pl.Add("@PriceType", SqlDbType.NVarChar, 50, PriceType);
		pl.Add("@FixedPrice", SqlDbType.NVarChar, 50, FixedPrice);
		pl.Add("@Margin", SqlDbType.NVarChar, 50, Margin);
        
        string id = data.ExecuteScalar("Pastrama.SaveJewelPriceLog",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveJewelReview_Pastrama( Object JewelReviewID, Object JewelID, Object Name, Object Email, Object Description, Object Rating, Object Date, Object IsApproved)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelReviewID", SqlDbType.Int, 0, JewelReviewID);
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@Email", SqlDbType.NVarChar, 256, Email);
		pl.Add("@Description", SqlDbType.NVarChar, 0, Description);
		pl.Add("@Rating", SqlDbType.Int, 0, Rating);
		pl.Add("@Date", SqlDbType.DateTime, 0, Date);
		pl.Add("@IsApproved", SqlDbType.Bit, 0, IsApproved);
        
        string id = data.ExecuteScalar("Pastrama.SaveJewelReview",pl);
        
        data.Close();
        return id;
    }
    
    public void SetAuthorizationGuidForLargeMovie_Pastrama( Object ContactID, Object Guid)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Guid", SqlDbType.NVarChar, 100, Guid);
        data.RunProc("Pastrama.SetAuthorizationGuidForLargeMovie",pl);
        
        data.Close();        
    }
    
    public void SetDisplaySetTypeID_Pastrama( Object JewelID, Object DisplaySetTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@DisplaySetTypeID", SqlDbType.Int, 0, DisplaySetTypeID);
        data.RunProc("Pastrama.SetDisplaySetTypeID",pl);
        
        data.Close();        
    }
    
    public void SetEngagementMomentsImgOrder_Pastrama( Object ImgPath, Object ImgOrder)
    {
        ParamList pl = new ParamList();
		pl.Add("@ImgPath", SqlDbType.VarChar, 100, ImgPath);
		pl.Add("@ImgOrder", SqlDbType.Int, 0, ImgOrder);
        data.RunProc("Pastrama.SetEngagementMomentsImgOrder",pl);
        
        data.Close();        
    }
    
    public void SetSegomaImageRequest_Pastrama( Object JewelID, Object SegomaRefCode, Object VendorSKU, Object ShpaeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.BigInt, 0, JewelID);
		pl.Add("@SegomaRefCode", SqlDbType.NVarChar, 50, SegomaRefCode);
		pl.Add("@VendorSKU", SqlDbType.NVarChar, 50, VendorSKU);
		pl.Add("@ShpaeID", SqlDbType.Int, 0, ShpaeID);
        data.RunProc("Pastrama.SetSegomaImageRequest",pl);
        
        data.Close();        
    }
    
    public void UpdateB2BReference_Pastrama( Object B2BReferenceID, Object BranchID, Object ReferToBranchID, Object AsB2BReferenceTypeID, Object Terms, Object Discount, Object Credit, Object MarkUp, Object PriceTypeID, Object JADiscount)
    {
        ParamList pl = new ParamList();
		pl.Add("@B2BReferenceID", SqlDbType.Int, 0, B2BReferenceID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@ReferToBranchID", SqlDbType.Int, 0, ReferToBranchID);
		pl.Add("@AsB2BReferenceTypeID", SqlDbType.Int, 0, AsB2BReferenceTypeID);
		pl.Add("@Terms", SqlDbType.Int, 0, Terms);
		pl.Add("@Discount", SqlDbType.Float, 0, Discount);
		pl.Add("@Credit", SqlDbType.Int, 0, Credit);
		pl.Add("@MarkUp", SqlDbType.Float, 0, MarkUp);
		pl.Add("@PriceTypeID", SqlDbType.Int, 0, PriceTypeID);
		pl.Add("@JADiscount", SqlDbType.Float, 0, JADiscount);
        data.RunProc("Pastrama.UpdateB2BReference",pl);
        
        data.Close();        
    }
    
    public void UpdateBenchmarkCosts_Pastrama( Object DataXml, Object ContactID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateBenchmarkCosts",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondFlawList_Pastrama( Object ProductID, Object FlawTypeID, Object Checked)
    {
        ParamList pl = new ParamList();
		pl.Add("@ProductID", SqlDbType.Int, 0, ProductID);
		pl.Add("@FlawTypeID", SqlDbType.Int, 0, FlawTypeID);
		pl.Add("@Checked", SqlDbType.Bit, 0, Checked);
        data.RunProc("Pastrama.UpdateDiamondFlawList",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondSegomaRefCode_Pastrama( Object DiamondID, Object NewRefCode)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@NewRefCode", SqlDbType.NVarChar, 50, NewRefCode);
        data.RunProc("Pastrama.UpdateDiamondSegomaRefCode",pl);
        
        data.Close();        
    }
    
    public void UpdateFlawType_Pastrama( Object FlawTypeID, Object Name)
    {
        ParamList pl = new ParamList();
		pl.Add("@FlawTypeID", SqlDbType.Int, 0, FlawTypeID);
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
        data.RunProc("Pastrama.UpdateFlawType",pl);
        
        data.Close();        
    }
    
    public void UpdateFlawTypeName_Pastrama( Object FlawTypeID, Object FlawTypeName)
    {
        ParamList pl = new ParamList();
		pl.Add("@FlawTypeID", SqlDbType.Int, 0, FlawTypeID);
		pl.Add("@FlawTypeName", SqlDbType.NVarChar, 50, FlawTypeName);
        data.RunProc("Pastrama.UpdateFlawTypeName",pl);
        
        data.Close();        
    }
    
    public void UpdateJAUserPassword_Pastrama( Object ContactID, Object PlainTextPassword, Object HashPassword)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@PlainTextPassword", SqlDbType.NVarChar, 50, PlainTextPassword);
		pl.Add("@HashPassword", SqlDbType.NVarChar, 256, HashPassword);
        data.RunProc("Pastrama.UpdateJAUserPassword",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelCategories_Pastrama( Object DataXml, Object ContactID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateJewelCategories",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelFormDataSource_old_Pastrama( Object dataXml, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@dataXml", SqlDbType.Xml, 0, dataXml);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateJewelFormDataSource_old",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelItemURL_Pastrama( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        data.RunProc("Pastrama.UpdateJewelItemURL",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelManufacturersAllocation_Pastrama( Object JewelIDs, Object AllocationXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelIDs", SqlDbType.NVarChar, 200, JewelIDs);
		pl.Add("@AllocationXML", SqlDbType.Xml, 0, AllocationXML);
        data.RunProc("Pastrama.UpdateJewelManufacturersAllocation",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelryBatch_Pastrama( Object DataXml, Object ContactID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateJewelryBatch",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelrySupplierCard_Pastrama( Object DataXml, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateJewelrySupplierCard",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelrySupplierMetalPrices_Pastrama( Object ContactID, Object BranchID, Object DataXml, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateJewelrySupplierMetalPrices",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelrySupplierMetalPrices_oldjf_20170904_Pastrama( Object ContactID, Object BranchID, Object DataXml, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateJewelrySupplierMetalPrices_oldjf_20170904",pl);
        
        data.Close();        
    }
    
    public void UpdateMarketingCategory_Pastrama( Object CategoryID, Object body)
    {
        ParamList pl = new ParamList();
		pl.Add("@CategoryID", SqlDbType.Int, 0, CategoryID);
		pl.Add("@body", SqlDbType.Text, 2147483647, body);
        data.RunProc("Pastrama.UpdateMarketingCategory",pl);
        
        data.Close();        
    }
    
    public void UpdateMetalPrices_Pastrama( Object BranchID, Object DataXml, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("Pastrama.UpdateMetalPrices",pl);
        
        data.Close();        
    }
    
    public void UpdateTrueHeartApproval_Pastrama( Object PendingTrueHartID, Object Status)
    {
        ParamList pl = new ParamList();
		pl.Add("@PendingTrueHartID", SqlDbType.Int, 0, PendingTrueHartID);
		pl.Add("@Status", SqlDbType.NVarChar, 50, Status);
        data.RunProc("Pastrama.UpdateTrueHeartApproval",pl);
        
        data.Close();        
    }
    
}
