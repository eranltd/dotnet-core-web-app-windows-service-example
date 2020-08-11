using System;
using System.Data;
using System.Configuration;
using System.Xml;
using DataBaseService;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SysDataLayer
/// </summary>
public class DataLayer : DataLayerAuto, IDisposable
{

    public DataLayer()
        : base()
    {

    }
    public DataLayer(string connectionString)
    {
        data = new Database(connectionString);
    }

    public static DataLayer Instance
    {
        get { return new DataLayer(); }
    }



    //public void Close()
    //{
    //    data.Close();
    //}

    public DataSet GetUpdateSnetPhotoRefCode_Segoma(Object DataTable)
    {
        ParamList pl = new ParamList();
        pl.Add("@DataTable", DataTable);
        SqlDataReader reader;
        data.RunProc("Segoma.GetUpdateSnetPhotoRefCode", pl, out reader);

        DataSet ds = GetDataSet(reader);
        reader.Close();
        data.Close();
        return ds;        
    }
    
    public void UpdateRapaportPrices(int commandTimeout)
    {
        ParamList pl = new ParamList();

        data.RunProc("StockManagement.UpdateRapaportPrices", pl, commandTimeout);

        data.Close();
    }


   

    public DataSet GetPictureIDsDs1(Object PicturesXml)
    {
        SqlDataReader reader = GetPictureIDsSDR1(PicturesXml);
        DataSet ds = GetDataSet(reader);
        reader.Close();
        data.Close();
        return ds;


    }
    public SqlDataReader GetPictureIDsSDR1(Object PicturesXml)
    {
        ParamList pl = new ParamList();
        pl.Add("@PicturesXml", SqlDbType.Xml, 0, PicturesXml);
        SqlDataReader reader;
        data.RunProc("StockUpload.GetPictureIDs", pl, out reader, 120);

        return reader;
    }

    public DataSet UpdatePictureIDs1(Object PicturesXml)
    {
        ParamList pl = new ParamList();
        DataSet ds = null;
        pl.Add("@PicturesXml", SqlDbType.Xml, 0, PicturesXml);
        ds = data.GetDataSet("StockUpload.UpdatePictureIDs", pl, 240);

        data.Close();

        return ds;
    }

   


    public DataSet GetRecommendedInventory_RecommendedDiamondDs(Object CaratGroupID, Object ShapeID, Object ContactID, int CommandTimeout)
    {
        SqlDataReader reader = GetRecommendedInventory_RecommendedDiamondSDR(CaratGroupID, ShapeID, ContactID, CommandTimeout);
        DataSet ds = GetDataSet(reader);
        reader.Close();
        data.Close();
        return ds;

    }

    public SqlDataReader GetRecommendedInventory_RecommendedDiamondSDR(Object CaratGroupID, Object ShapeID, Object ContactID, int CommandTimeout)
    {
        ParamList pl = new ParamList();
        pl.Add("@CaratGroupID", SqlDbType.Int, 0, CaratGroupID);
        pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
        pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetRecommendedInventory", pl, out reader, CommandTimeout);

        return reader;
    }

    public new SqlDataReader  GetCertProcessList_dev_CertificateUploadSDR(Object ServerIndex)
    {
        ParamList pl = new ParamList();
        pl.Add("@ServerIndex", SqlDbType.Int, 0, ServerIndex);
        SqlDataReader reader;
        data.RunProc("CertificateUpload.GetCertProcessList_dev", pl, out reader,60);
        return reader;
    }

    
    public new string SaveSupplierCard_StockManagement(Object BranchTemplateID, Object IsOnJamesAllen, Object IsOnJared, Object IsOnKay, Object SegomaBranchID, Object Notes, Object Enabled, Object APIEnabled, Object FTPEnabled, Object Username, Object Password)
    {
        ParamList pl = new ParamList();
        pl.Add("@BranchTemplateID", SqlDbType.Int, 0, BranchTemplateID);
        pl.Add("@IsOnJamesAllen", SqlDbType.Bit, 0, IsOnJamesAllen);
        pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
        pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
        pl.Add("@SegomaBranchID", SqlDbType.NVarChar, 50, SegomaBranchID);
        pl.Add("@Notes", SqlDbType.NVarChar, 1000, Notes);
        pl.Add("@Enabled", SqlDbType.Bit, 0, Enabled);
        pl.Add("@APIEnabled", SqlDbType.Bit, 0, APIEnabled);
        pl.Add("@FTPEnabled", SqlDbType.Bit, 0, FTPEnabled);
        pl.Add("@Username", SqlDbType.NVarChar, 50, Username);
        pl.Add("@Password", SqlDbType.NVarChar, 50, Password);

        string id = data.ExecuteScalar("StockManagement.SaveSupplierCard", pl, 300);

        data.Close();
        return id;
    }

    public new SqlDataReader GetDiamondStock_PastramaSDR(Object Query, Object PageSize, Object PageNumber)
    {
        ParamList pl = new ParamList();
        pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
        pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
        pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;

        data.RunProc("Pastrama.GetDiamondStock", pl, out reader, 60);

        return reader;
    }
       

    public new object GetTaskChartDatasource_R2D2JSON(Object FromDate, Object ToDate, Object Tasks, Object Interval)
    {
        ParamList pl = new ParamList();
        pl.Add("@FromDate", SqlDbType.Date, 0, FromDate);
        pl.Add("@ToDate", SqlDbType.Date, 0, ToDate);
        pl.Add("@Tasks", SqlDbType.NVarChar, 50, Tasks);
        pl.Add("@Interval", SqlDbType.Char, 1, Interval);


        object result = data.GetJSON("R2D2.GetTaskChartDatasource", pl, 120);

        return result;
    }

    public SqlDataReader GetR2D2TaskRequest_R2D2SDR(Object Query, Object PageSize, Object PageNumber, int CommandTimeout = 60)
    {
        ParamList pl = new ParamList();
        pl.Add("@Query", SqlDbType.NVarChar, 1000, Query);
        pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
        pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        SqlDataReader reader;
        data.RunProc("R2D2.GetR2D2TaskRequest", pl, out reader, CommandTimeout);

        return reader;
    }

    public new XmlReader GetDiamondsForRecommandationXml_RecommendedDiamond(Object PageSize, Object PageNumber, Object ShapeList, Object CutList, Object ColorList, Object ClarityList, Object PolishList, Object SymmetryList, Object CaratFrom, Object CaratTo, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object OrderBy, Object MoreOp, Object FlourList, Object FluorList, Object LabList, Object IDs, Object Src, Object SupplierID, Object IsOnKay, Object IsOnJared, Object IsOnJamesAllen, Object FromDate, Object ToDate, Object ContactID)
    {
        ParamList pl = new ParamList();
        pl.Add("@PageSize", SqlDbType.Int, 0, PageSize);
        pl.Add("@PageNumber", SqlDbType.Int, 0, PageNumber);
        pl.Add("@ShapeList", SqlDbType.NVarChar, 50, ShapeList);
        pl.Add("@CutList", SqlDbType.NVarChar, 50, CutList);
        pl.Add("@ColorList", SqlDbType.NVarChar, 50, ColorList);
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
        pl.Add("@FlourList", SqlDbType.NVarChar, 50, FlourList);
        pl.Add("@FluorList", SqlDbType.NVarChar, 50, FluorList);
        pl.Add("@LabList", SqlDbType.NVarChar, 50, LabList);
        pl.Add("@IDs", SqlDbType.NVarChar, 2048, IDs);
        pl.Add("@Src", SqlDbType.NVarChar, 50, Src);
        pl.Add("@SupplierID", SqlDbType.Int, 0, SupplierID);
        pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
        pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
        pl.Add("@IsOnJamesAllen", SqlDbType.Bit, 0, IsOnJamesAllen);
        pl.Add("@FromDate", SqlDbType.DateTime, 0, FromDate);
        pl.Add("@ToDate", SqlDbType.DateTime, 0, ToDate);

        pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        XmlReader reader;
        data.RunProc("RecommendedDiamond.GetDiamondsForRecommandationXml", pl, out reader, 60);

        return reader;
    }

    public void Dispose()
    {
        if (data != null)
            data.Close();

        data = null;
    }

    public SqlConnection GetDBConnection()
    {
        return data.GetDBConnection();
    }

    
}
