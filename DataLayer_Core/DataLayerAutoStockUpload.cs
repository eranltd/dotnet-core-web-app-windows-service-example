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
//Functions for StockUpload schema
//--------------------------------------------------------------------------------
    public void ActivateJewelryByFile_StockUpload( Object FileUploadID, Object IsActive)
    {
        ParamList pl = new ParamList();
		pl.Add("@FileUploadID", SqlDbType.Int, 0, FileUploadID);
		pl.Add("@IsActive", SqlDbType.Bit, 0, IsActive);
        data.RunProc("StockUpload.ActivateJewelryByFile",pl);
        
        data.Close();        
    }
    
    public void CopyDiamondPackshot_StockUpload( Object OldDiamondID, Object NewDiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldDiamondID", SqlDbType.Int, 0, OldDiamondID);
		pl.Add("@NewDiamondID", SqlDbType.Int, 0, NewDiamondID);
        data.RunProc("StockUpload.CopyDiamondPackshot",pl);
        
        data.Close();        
    }
    
    public void DeleteJewelryByFile_StockUpload( Object FileUploadID)
    {
        ParamList pl = new ParamList();
		pl.Add("@FileUploadID", SqlDbType.Int, 0, FileUploadID);
        data.RunProc("StockUpload.DeleteJewelryByFile",pl);
        
        data.Close();        
    }
    
    public void DeleteMismachingImages_StockUpload( Object Pending3DImagesIDs)
    {
        ParamList pl = new ParamList();
		pl.Add("@Pending3DImagesIDs", SqlDbType.NVarChar, 4000, Pending3DImagesIDs);
        data.RunProc("StockUpload.DeleteMismachingImages",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetAllMismachingImages_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAllMismachingImages",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAllMismachingImages_StockUploadDs()
    {
            SqlDataReader reader = GetAllMismachingImages_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndDeleteDiamondPackshotsWithNoSegomaRef_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndDeleteDiamondPackshotsWithNoSegomaRef",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndDeleteDiamondPackshotsWithNoSegomaRef_StockUploadDs()
    {
            SqlDataReader reader = GetAndDeleteDiamondPackshotsWithNoSegomaRef_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndUploadDiamondSetd_StockUploadSDR( Object DiamondXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondXml", SqlDbType.Xml, 0, DiamondXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndUploadDiamondSetd",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndUploadDiamondSetd_StockUploadDs( Object DiamondXml)
    {
            SqlDataReader reader = GetAndUploadDiamondSetd_StockUploadSDR(  DiamondXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndUploadGemstoneSetd_StockUploadSDR( Object GemstoneXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneXml", SqlDbType.Xml, 0, GemstoneXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndUploadGemstoneSetd",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndUploadGemstoneSetd_StockUploadDs( Object GemstoneXml)
    {
            SqlDataReader reader = GetAndUploadGemstoneSetd_StockUploadSDR(  GemstoneXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndUploadJewelRoughDiamondSet_StockUploadSDR( Object GemstoneXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstoneXml", SqlDbType.Xml, 0, GemstoneXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndUploadJewelRoughDiamondSet",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndUploadJewelRoughDiamondSet_StockUploadDs( Object GemstoneXml)
    {
            SqlDataReader reader = GetAndUploadJewelRoughDiamondSet_StockUploadSDR(  GemstoneXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndUploadSegomaJewelrySet_StockUploadSDR( Object Xml)
    {
        ParamList pl = new ParamList();
		pl.Add("@Xml", SqlDbType.Xml, 0, Xml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndUploadSegomaJewelrySet",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndUploadSegomaJewelrySet_StockUploadDs( Object Xml)
    {
            SqlDataReader reader = GetAndUploadSegomaJewelrySet_StockUploadSDR(  Xml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndUploadSegomotSet_StockUploadSDR( Object DiamondXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondXml", SqlDbType.Xml, 0, DiamondXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndUploadSegomotSet",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndUploadSegomotSet_StockUploadDs( Object DiamondXml)
    {
            SqlDataReader reader = GetAndUploadSegomotSet_StockUploadSDR(  DiamondXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetAndUploadSoldRingsSet_StockUploadSDR( Object Xml)
    {
        ParamList pl = new ParamList();
		pl.Add("@Xml", SqlDbType.Xml, 0, Xml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetAndUploadSoldRingsSet",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAndUploadSoldRingsSet_StockUploadDs( Object Xml)
    {
            SqlDataReader reader = GetAndUploadSoldRingsSet_StockUploadSDR(  Xml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchesTemplates_old_StockUploadSDR( Object BranchIDList)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchIDList", SqlDbType.NVarChar, 200, BranchIDList);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetBranchesTemplates_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchesTemplates_old_StockUploadDs( Object BranchIDList)
    {
            SqlDataReader reader = GetBranchesTemplates_old_StockUploadSDR(  BranchIDList);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBranchFtpDir_StockUploadSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetBranchFtpDir",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBranchFtpDir_StockUploadDs( Object BranchID)
    {
            SqlDataReader reader = GetBranchFtpDir_StockUploadSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBrioFileName_StockUploadSDR( Object JewelryUploadFileID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelryUploadFileID", SqlDbType.Int, 0, JewelryUploadFileID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetBrioFileName",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBrioFileName_StockUploadDs( Object JewelryUploadFileID)
    {
            SqlDataReader reader = GetBrioFileName_StockUploadSDR(  JewelryUploadFileID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetBrioSKUPackShot_JaredCom_ToDelete09072018_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetBrioSKUPackShot_JaredCom_ToDelete09072018",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetBrioSKUPackShot_JaredCom_ToDelete09072018_StockUploadDs()
    {
            SqlDataReader reader = GetBrioSKUPackShot_JaredCom_ToDelete09072018_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCertificatesToCopy_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetCertificatesToCopy",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCertificatesToCopy_StockUploadDs()
    {
            SqlDataReader reader = GetCertificatesToCopy_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCMCertificatesToCopy_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetCMCertificatesToCopy",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCMCertificatesToCopy_StockUploadDs()
    {
            SqlDataReader reader = GetCMCertificatesToCopy_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetColumnType_StockUploadSDR( Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetColumnType",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetColumnType_StockUploadDs( Object TemplateTypeID)
    {
            SqlDataReader reader = GetColumnType_StockUploadSDR(  TemplateTypeID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDataForBrio_StockUploadSDR( Object JewelryUploadFileID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelryUploadFileID", SqlDbType.Int, 0, JewelryUploadFileID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetDataForBrio",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDataForBrio_StockUploadDs( Object JewelryUploadFileID)
    {
            SqlDataReader reader = GetDataForBrio_StockUploadSDR(  JewelryUploadFileID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDataForBrioXML_StockUpload( Object JewelryUploadBrioFileID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelryUploadBrioFileID", SqlDbType.Int, 0, JewelryUploadBrioFileID);
        XmlReader reader;
        data.RunProc("StockUpload.GetDataForBrioXML",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetDefaultTemplateXML_StockUpload( Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        XmlReader reader;
        data.RunProc("StockUpload.GetDefaultTemplateXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetDiamondsToRePic_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetDiamondsToRePic",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsToRePic_StockUploadDs()
    {
            SqlDataReader reader = GetDiamondsToRePic_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetExistingSKUs_StockUploadSDR( Object NewSkusCSV)
    {
        ParamList pl = new ParamList();
		pl.Add("@NewSkusCSV", SqlDbType.NVarChar, 0, NewSkusCSV);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetExistingSKUs",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetExistingSKUs_StockUploadDs( Object NewSkusCSV)
    {
            SqlDataReader reader = GetExistingSKUs_StockUploadSDR(  NewSkusCSV);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetFTPRootDir_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetFTPRootDir",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetFTPRootDir_StockUploadDs()
    {
            SqlDataReader reader = GetFTPRootDir_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetInitData_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetInitData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInitData_StockUploadDs()
    {
            SqlDataReader reader = GetInitData_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryByFile_StockUploadSDR( Object PageSize, Object PageNumber, Object OrderBy, Object FileUploadID)
    {
        ParamList pl = new ParamList();
		pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
		pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
		pl.Add("@OrderBy", SqlDbType.NVarChar, 0, OrderBy);
		pl.Add("@FileUploadID", SqlDbType.Int, 0, FileUploadID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetJewelryByFile",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryByFile_StockUploadDs( Object PageSize, Object PageNumber, Object OrderBy, Object FileUploadID)
    {
            SqlDataReader reader = GetJewelryByFile_StockUploadSDR(  PageSize,  PageNumber,  OrderBy,  FileUploadID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetJewelryFileUploads_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetJewelryFileUploads",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetJewelryFileUploads_StockUploadDs()
    {
            SqlDataReader reader = GetJewelryFileUploads_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetMismachingImages_StockUploadSDR( Object OldSuppierID, Object Pending3DImagesID)
    {
        ParamList pl = new ParamList();
		pl.Add("@OldSuppierID", SqlDbType.Int, 0, OldSuppierID);
		pl.Add("@Pending3DImagesID", SqlDbType.Int, 0, Pending3DImagesID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetMismachingImages",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetMismachingImages_StockUploadDs( Object OldSuppierID, Object Pending3DImagesID)
    {
            SqlDataReader reader = GetMismachingImages_StockUploadSDR(  OldSuppierID,  Pending3DImagesID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetNotFoundDiamondSets_StockUploadSDR( Object DiamondXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondXml", SqlDbType.Xml, 0, DiamondXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetNotFoundDiamondSets",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetNotFoundDiamondSets_StockUploadDs( Object DiamondXml)
    {
            SqlDataReader reader = GetNotFoundDiamondSets_StockUploadSDR(  DiamondXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPackshotsForValidation_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPackshotsForValidation",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPackshotsForValidation_StockUploadDs()
    {
            SqlDataReader reader = GetPackshotsForValidation_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPackshotsToRecover_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPackshotsToRecover",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPackshotsToRecover_StockUploadDs()
    {
            SqlDataReader reader = GetPackshotsToRecover_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPackShotsToReprocess_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPackShotsToReprocess",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPackShotsToReprocess_StockUploadDs()
    {
            SqlDataReader reader = GetPackShotsToReprocess_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPendingPackshot_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPendingPackshot",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPendingPackshot_StockUploadDs()
    {
            SqlDataReader reader = GetPendingPackshot_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPendingPackshotProcessByVariation_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPendingPackshotProcessByVariation",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPendingPackshotProcessByVariation_StockUploadDs()
    {
            SqlDataReader reader = GetPendingPackshotProcessByVariation_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPendingPackshotProcessByVariation_271014_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPendingPackshotProcessByVariation_271014",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPendingPackshotProcessByVariation_271014_StockUploadDs()
    {
            SqlDataReader reader = GetPendingPackshotProcessByVariation_271014_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetPendingPackshotVariationXml_StockUpload( Object JewelID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
        XmlReader reader;
        data.RunProc("StockUpload.GetPendingPackshotVariationXml",pl, out reader);
        
        return reader;
    }
    
    public XmlReader GetPendingPackshotXml_StockUpload( Object ModelSku)
    {
        ParamList pl = new ParamList();
		pl.Add("@ModelSku", SqlDbType.NVarChar, 50, ModelSku);
        XmlReader reader;
        data.RunProc("StockUpload.GetPendingPackshotXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetPictureIDs_StockUploadSDR( Object PicturesXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@PicturesXml", SqlDbType.Xml, 0, PicturesXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPictureIDs",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPictureIDs_StockUploadDs( Object PicturesXml)
    {
            SqlDataReader reader = GetPictureIDs_StockUploadSDR(  PicturesXml);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPicturesOfDirectory_StockUploadSDR( Object Directory)
    {
        ParamList pl = new ParamList();
		pl.Add("@Directory", SqlDbType.NVarChar, 50, Directory);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPicturesOfDirectory",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPicturesOfDirectory_StockUploadDs( Object Directory)
    {
            SqlDataReader reader = GetPicturesOfDirectory_StockUploadSDR(  Directory);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPinkCertificatesToCopy_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPinkCertificatesToCopy",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPinkCertificatesToCopy_StockUploadDs()
    {
            SqlDataReader reader = GetPinkCertificatesToCopy_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRapaportPendingLoad_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetRapaportPendingLoad",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRapaportPendingLoad_StockUploadDs()
    {
            SqlDataReader reader = GetRapaportPendingLoad_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSegomaSuppliers_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetSegomaSuppliers",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSegomaSuppliers_StockUploadDs()
    {
            SqlDataReader reader = GetSegomaSuppliers_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetStockUploadServiceDataSource_old_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetStockUploadServiceDataSource_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetStockUploadServiceDataSource_old_StockUploadDs()
    {
            SqlDataReader reader = GetStockUploadServiceDataSource_old_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierStockChangedReport_StockUploadSDR( Object Threshold)
    {
        ParamList pl = new ParamList();
		pl.Add("@Threshold", SqlDbType.Int, 0, Threshold);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetSupplierStockChangedReport",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierStockChangedReport_StockUploadDs( Object Threshold)
    {
            SqlDataReader reader = GetSupplierStockChangedReport_StockUploadSDR(  Threshold);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetSupplierTargetDir_StockUploadSDR( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetSupplierTargetDir",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetSupplierTargetDir_StockUploadDs( Object BranchID)
    {
            SqlDataReader reader = GetSupplierTargetDir_StockUploadSDR(  BranchID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTemplates_StockUploadSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("StockUpload.GetTemplates",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTemplates_StockUploadDs()
    {
            SqlDataReader reader = GetTemplates_StockUploadSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public string InsertAlternativePackShot_StockUpload( Object JewelID, Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        
        string id = data.ExecuteScalar("StockUpload.InsertAlternativePackShot",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertNewDiamondSupplier_old_StockUpload( Object BranchID, Object LotPrefix, Object IsExclusive)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@LotPrefix", SqlDbType.NVarChar, 50, LotPrefix);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
        
        string id = data.ExecuteScalar("StockUpload.InsertNewDiamondSupplier_old",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPackShot_StockUpload( Object xmlDoc, Object setTypeOfJewel, Object isFromPending)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
		pl.Add("@setTypeOfJewel", SqlDbType.VarChar, 50, setTypeOfJewel);
		pl.Add("@isFromPending", SqlDbType.Bit, 0, isFromPending);
        
        string id = data.ExecuteScalar("StockUpload.InsertPackShot",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPackShot_29052018_StockUpload( Object xmlDoc, Object setTypeOfJewel, Object isFromPending)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
		pl.Add("@setTypeOfJewel", SqlDbType.VarChar, 50, setTypeOfJewel);
		pl.Add("@isFromPending", SqlDbType.Bit, 0, isFromPending);
        
        string id = data.ExecuteScalar("StockUpload.InsertPackShot_29052018",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPackShot_Jared_ToDelete09072018_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        
        string id = data.ExecuteScalar("StockUpload.InsertPackShot_Jared_ToDelete09072018",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPackShotIntoTable_StockUpload( Object xmlDoc, Object setTypeOfJewel, Object isFromPending)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
		pl.Add("@setTypeOfJewel", SqlDbType.VarChar, 50, setTypeOfJewel);
		pl.Add("@isFromPending", SqlDbType.Bit, 0, isFromPending);
        
        string id = data.ExecuteScalar("StockUpload.InsertPackShotIntoTable",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPackShotLoopTable_StockUpload()
    {
        ParamList pl = new ParamList();
        
        string id = data.ExecuteScalar("StockUpload.InsertPackShotLoopTable",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPackShotTransp_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        
        string id = data.ExecuteScalar("StockUpload.InsertPackShotTransp",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPariPackShot_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        
        string id = data.ExecuteScalar("StockUpload.InsertPariPackShot",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPariPackShot_Jared_com_ToDelete09072018_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        
        string id = data.ExecuteScalar("StockUpload.InsertPariPackShot_Jared_com_ToDelete09072018",pl);
        
        data.Close();
        return id;
    }
    
    public string InsertPariPackShot_Jared_ToDelete09072018_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        
        string id = data.ExecuteScalar("StockUpload.InsertPariPackShot_Jared_ToDelete09072018",pl);
        
        data.Close();
        return id;
    }
    
    public void RemoveSupplier_StockUpload( Object BranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
        data.RunProc("StockUpload.RemoveSupplier",pl);
        
        data.Close();        
    }
    
    public void ReportSupplierStockChanged_StockUpload()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockUpload.ReportSupplierStockChanged",pl);
        
        data.Close();        
    }
    
    public string SaveTemplate_StockUpload( Object Name, Object Data)
    {
        ParamList pl = new ParamList();
		pl.Add("@Name", SqlDbType.NVarChar, 50, Name);
		pl.Add("@Data", SqlDbType.Xml, 0, Data);
        
        string id = data.ExecuteScalar("StockUpload.SaveTemplate",pl);
        
        data.Close();
        return id;
    }
    
    public string SaveTemplate_new_StockUpload( Object TemplateID, Object Data)
    {
        ParamList pl = new ParamList();
		pl.Add("@TemplateID", SqlDbType.NVarChar, 50, TemplateID);
		pl.Add("@Data", SqlDbType.Xml, 0, Data);
        
        string id = data.ExecuteScalar("StockUpload.SaveTemplate_new",pl);
        
        data.Close();
        return id;
    }
    
    public void SetMismachingImage_StockUpload( Object Pending3DImagesID, Object StoneID)
    {
        ParamList pl = new ParamList();
		pl.Add("@Pending3DImagesID", SqlDbType.Int, 0, Pending3DImagesID);
		pl.Add("@StoneID", SqlDbType.Int, 0, StoneID);
        data.RunProc("StockUpload.SetMismachingImage",pl);
        
        data.Close();        
    }
    
    public void SetPackshotSkuByJewelID_StockUpload( Object JewelID, Object VariationID)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelID", SqlDbType.Int, 0, JewelID);
		pl.Add("@VariationID", SqlDbType.Int, 0, VariationID);
        data.RunProc("StockUpload.SetPackshotSkuByJewelID",pl);
        
        data.Close();        
    }
    
    public void SetPackshotSkuByModel_StockUpload( Object ModelSku, Object PackModel)
    {
        ParamList pl = new ParamList();
		pl.Add("@ModelSku", SqlDbType.NVarChar, 50, ModelSku);
		pl.Add("@PackModel", SqlDbType.NVarChar, 50, PackModel);
        data.RunProc("StockUpload.SetPackshotSkuByModel",pl);
        
        data.Close();        
    }
    
    public void ShouldLoadRapaport_StockUpload()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockUpload.ShouldLoadRapaport",pl);
        
        data.Close();        
    }
    
    public void SyncPics_StockUpload( Object FilePah)
    {
        ParamList pl = new ParamList();
		pl.Add("@FilePah", SqlDbType.NVarChar, 265, FilePah);
        data.RunProc("StockUpload.SyncPics",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondInTheRoughUploadStatus_StockUpload( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
        data.RunProc("StockUpload.UpdateDiamondInTheRoughUploadStatus",pl);
        
        data.Close();        
    }
    
    public void UpdateGemCashOnJaredOnKay_StockUpload()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockUpload.UpdateGemCashOnJaredOnKay",pl);
        
        data.Close();        
    }
    
    public void UpdateGemsUploadStatus_StockUpload( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
        data.RunProc("StockUpload.UpdateGemsUploadStatus",pl);
        
        data.Close();        
    }
    
    public void UpdateHandPackShot_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        data.RunProc("StockUpload.UpdateHandPackShot",pl);
        
        data.Close();        
    }
    
    public void UpdateHasCert_StockUpload( Object CertsXml, Object CertType)
    {
        ParamList pl = new ParamList();
		pl.Add("@CertsXml", SqlDbType.Xml, 0, CertsXml);
		pl.Add("@CertType", SqlDbType.NVarChar, 50, CertType);
        data.RunProc("StockUpload.UpdateHasCert",pl);
        
        data.Close();        
    }
    
    public void UpdateHasCertificate_StockUpload( Object CertsXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@CertsXml", SqlDbType.Xml, 0, CertsXml);
        data.RunProc("StockUpload.UpdateHasCertificate",pl);
        
        data.Close();        
    }
    
    public void UpdateHasPinkCertificate_StockUpload( Object CertsXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@CertsXml", SqlDbType.Xml, 0, CertsXml);
        data.RunProc("StockUpload.UpdateHasPinkCertificate",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelImagesPackshots_StockUpload( Object DataXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
        data.RunProc("StockUpload.UpdateJewelImagesPackshots",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelPackshots_StockUpload( Object DataXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataXml", SqlDbType.Xml, 0, DataXml);
        data.RunProc("StockUpload.UpdateJewelPackshots",pl);
        
        data.Close();        
    }
    
    public void UpdateJewelryUploadStatus_StockUpload( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
        data.RunProc("StockUpload.UpdateJewelryUploadStatus",pl);
        
        data.Close();        
    }
    
    public void UpdatePackShot_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        data.RunProc("StockUpload.UpdatePackShot",pl);
        
        data.Close();        
    }
    
    public void UpdatePackshotValidation_StockUpload( Object StonesXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@StonesXml", SqlDbType.Xml, 0, StonesXml);
        data.RunProc("StockUpload.UpdatePackshotValidation",pl);
        
        data.Close();        
    }
    
    public void UpdatePictureIDs_StockUpload( Object PicturesXml)
    {
        ParamList pl = new ParamList();
		pl.Add("@PicturesXml", SqlDbType.Xml, 0, PicturesXml);
        data.RunProc("StockUpload.UpdatePictureIDs",pl);
        
        data.Close();        
    }
    
    public void UpdatePresetJewelryUploadStatus_StockUpload( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles, Object TemplateTypeID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
		pl.Add("@TemplateTypeID", SqlDbType.Int, 0, TemplateTypeID);
        data.RunProc("StockUpload.UpdatePresetJewelryUploadStatus",pl);
        
        data.Close();        
    }
    
    public void UpdatePresetRingsUploadStatus_StockUpload( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
        data.RunProc("StockUpload.UpdatePresetRingsUploadStatus",pl);
        
        data.Close();        
    }
    
    public void UpdateR2NetPrices_old_StockUpload( Object DiamondsDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondsDataTable", DiamondsDataTable);
        data.RunProc("StockUpload.UpdateR2NetPrices_old",pl);
        
        data.Close();        
    }
    
    public void UpdateRapaportPrices_StockUpload()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockUpload.UpdateRapaportPrices",pl);
        
        data.Close();        
    }
    
    public void UpdateRecoverPackshot_StockUpload( Object DiamondID, Object Has600)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@Has600", SqlDbType.Bit, 0, Has600);
        data.RunProc("StockUpload.UpdateRecoverPackshot",pl);
        
        data.Close();        
    }
    
    public void UpdateRenderedHandPackShot_StockUpload( Object xmlDoc)
    {
        ParamList pl = new ParamList();
		pl.Add("@xmlDoc", SqlDbType.Xml, 0, xmlDoc);
        data.RunProc("StockUpload.UpdateRenderedHandPackShot",pl);
        
        data.Close();        
    }
    
    public void UpdateStockDataFileDate_depricated_StockUpload( Object BranchID, Object LastUploadTime)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@LastUploadTime", SqlDbType.NVarChar, 50, LastUploadTime);
        data.RunProc("StockUpload.UpdateStockDataFileDate_depricated",pl);
        
        data.Close();        
    }
    
    public void UpdateUploadStatus_depricated_StockUpload( Object BranchID, Object BadRows, Object ProcessSucceed, Object FilesUploaded, Object RowsOnFiles)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@BadRows", SqlDbType.Int, 0, BadRows);
		pl.Add("@ProcessSucceed", SqlDbType.Bit, 0, ProcessSucceed);
		pl.Add("@FilesUploaded", SqlDbType.Bit, 0, FilesUploaded);
		pl.Add("@RowsOnFiles", SqlDbType.Int, 0, RowsOnFiles);
        data.RunProc("StockUpload.UpdateUploadStatus_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadDiamondInTheRough_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object UploadTime, Object FirstRow, Object LastRow)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
        data.RunProc("StockUpload.UploadDiamondInTheRough_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadDiamondInTheRoughData_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object FirstRow, Object LastRow,out Object UploadUniqueID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
        data.RunProc("StockUpload.UploadDiamondInTheRoughData_depricated",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadDiamondInTheRoughToR2Net_depricated_StockUpload( Object DiamondInTheRoughDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondInTheRoughDataTable", DiamondInTheRoughDataTable);
        data.RunProc("StockUpload.UploadDiamondInTheRoughToR2Net_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadDiamonds_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object UploadTime, Object FirstRow, Object LastRow, Object OverrideUpdateOdiroProjectDB)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.Add("@OverrideUpdateOdiroProjectDB", SqlDbType.Bit, 0, OverrideUpdateOdiroProjectDB);
        data.RunProc("StockUpload.UploadDiamonds_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadDiamondsData_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object FirstRow, Object LastRow,out Object UploadUniqueID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("StockUpload.UploadDiamondsData_depricated",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadGemstones_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object UploadTime, Object FirstRow, Object LastRow)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
        data.RunProc("StockUpload.UploadGemstones_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadGemstonesData_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object FirstRow, Object LastRow,out Object UploadUniqueID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
        data.RunProc("StockUpload.UploadGemstonesData_depricated",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadGemstonesToOdiroProject_depricated_StockUpload( Object GemstonesDataTable, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstonesDataTable", GemstonesDataTable);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("StockUpload.UploadGemstonesToOdiroProject_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadGemstonesToR2Net_depricated_StockUpload( Object GemstonesDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@GemstonesDataTable", GemstonesDataTable);
        data.RunProc("StockUpload.UploadGemstonesToR2Net_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadJewelry_StockUpload( Object UserID, Object FileName, Object JewelryXmlFile)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@FileName", SqlDbType.NVarChar, 256, FileName);
		pl.Add("@JewelryXmlFile", SqlDbType.Xml, 0, JewelryXmlFile);
        data.RunProc("StockUpload.UploadJewelry",pl);
        
        data.Close();        
    }
    
    public void UploadJewelryData_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object FirstRow, Object LastRow,out Object UploadUniqueID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
        data.RunProc("StockUpload.UploadJewelryData_depricated",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadJewelryToR2Net_depricated_StockUpload( Object JewelTypeID, Object JewelryDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@JewelTypeID", SqlDbType.Int, 0, JewelTypeID);
		pl.Add("@JewelryDataTable", JewelryDataTable);
        data.RunProc("StockUpload.UploadJewelryToR2Net_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadJewelryUpdateOnly_delete_depricated_StockUpload( Object UserID, Object JewelryXmlFile)
    {
        ParamList pl = new ParamList();
		pl.Add("@UserID", SqlDbType.Int, 0, UserID);
		pl.Add("@JewelryXmlFile", SqlDbType.Xml, 0, JewelryXmlFile);
        data.RunProc("StockUpload.UploadJewelryUpdateOnly_delete_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadJewelryUS_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object UploadTime, Object FirstRow, Object LastRow)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
        data.RunProc("StockUpload.UploadJewelryUS",pl);
        
        data.Close();        
    }
    
    public void UploadPresetJewelry_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object UploadTime, Object FirstRow, Object LastRow)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
        data.RunProc("StockUpload.UploadPresetJewelry_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadPresetJewelryData_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object FirstRow, Object LastRow,out Object UploadUniqueID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
        data.RunProc("StockUpload.UploadPresetJewelryData_depricated",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadPresetJewelryToR2Net_depricated_StockUpload( Object PresetJewelryDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@PresetJewelryDataTable", PresetJewelryDataTable);
        data.RunProc("StockUpload.UploadPresetJewelryToR2Net_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadPresetRings_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object UploadTime, Object FirstRow, Object LastRow)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@UploadTime", SqlDbType.NVarChar, 50, UploadTime);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
        data.RunProc("StockUpload.UploadPresetRings_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadPresetRingsData_depricated_StockUpload( Object CompanyID, Object BranchID, Object InventoryFilePath, Object IsExclusive, Object FirstRow, Object LastRow,out Object UploadUniqueID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CompanyID", SqlDbType.Int, 0, CompanyID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@InventoryFilePath", SqlDbType.NVarChar, 265, InventoryFilePath);
		pl.Add("@IsExclusive", SqlDbType.Bit, 0, IsExclusive);
		pl.Add("@FirstRow", SqlDbType.Int, 0, FirstRow);
		pl.Add("@LastRow", SqlDbType.Int, 0, LastRow);
		pl.AddOut("@UploadUniqueID", SqlDbType.UniqueIdentifier, 0);
        data.RunProc("StockUpload.UploadPresetRingsData_depricated",pl);
        
		UploadUniqueID= pl.GetParamValue("@UploadUniqueID");
        data.Close();        
    }
    
    public void UploadPresetRingsToR2Net_depricated_StockUpload( Object PresetRingsDataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@PresetRingsDataTable", PresetRingsDataTable);
        data.RunProc("StockUpload.UploadPresetRingsToR2Net_depricated",pl);
        
        data.Close();        
    }
    
    public void UploadRapaport_StockUpload( Object RapFilePah)
    {
        ParamList pl = new ParamList();
		pl.Add("@RapFilePah", SqlDbType.NVarChar, 256, RapFilePah);
        data.RunProc("StockUpload.UploadRapaport",pl);
        
        data.Close();        
    }
    
    public void uspLogError_StockUpload(out Object ErrorLogID)
    {
        ParamList pl = new ParamList();
		pl.AddOut("@ErrorLogID", SqlDbType.Int, 0);
        data.RunProc("StockUpload.uspLogError",pl);
        
		ErrorLogID= pl.GetParamValue("@ErrorLogID");
        data.Close();        
    }
    
    public void uspPrintError_StockUpload()
    {
        ParamList pl = new ParamList();
        data.RunProc("StockUpload.uspPrintError",pl);
        
        data.Close();        
    }
    
}
