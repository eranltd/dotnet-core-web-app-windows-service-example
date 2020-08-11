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
//Functions for SegomaInterface schema
//--------------------------------------------------------------------------------
    public SqlDataReader GetDeleteLots_SegomaInterfaceSDR( Object BranchID, Object LotList, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@LotList", SqlDbType.NVarChar, 0, LotList);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        SqlDataReader reader;
        data.RunProc("SegomaInterface.GetDeleteLots",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDeleteLots_SegomaInterfaceDs( Object BranchID, Object LotList, Object Debug)
    {
            SqlDataReader reader = GetDeleteLots_SegomaInterfaceSDR(  BranchID,  LotList,  Debug);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondByCernum_SegomaInterfaceSDR( Object CertNum)
    {
        ParamList pl = new ParamList();
		pl.Add("@CertNum", SqlDbType.NVarChar, 50, CertNum);
        SqlDataReader reader;
        data.RunProc("SegomaInterface.GetDiamondByCernum",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondByCernum_SegomaInterfaceDs( Object CertNum)
    {
            SqlDataReader reader = GetDiamondByCernum_SegomaInterfaceSDR(  CertNum);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondDetails_SegomaInterfaceSDR( Object SupplierID, Object SupplierLot)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierID", SqlDbType.Int, 0, SupplierID);
		pl.Add("@SupplierLot", SqlDbType.NVarChar, 50, SupplierLot);
        SqlDataReader reader;
        data.RunProc("SegomaInterface.GetDiamondDetails",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondDetails_SegomaInterfaceDs( Object SupplierID, Object SupplierLot)
    {
            SqlDataReader reader = GetDiamondDetails_SegomaInterfaceSDR(  SupplierID,  SupplierLot);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamonds_SegomaInterfaceSDR( Object DataTable)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
        SqlDataReader reader;
        data.RunProc("SegomaInterface.GetDiamonds",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamonds_SegomaInterfaceDs( Object DataTable)
    {
            SqlDataReader reader = GetDiamonds_SegomaInterfaceSDR(  DataTable);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void UpdateDiamond_SegomaInterface( Object SupplierLot, Object ShapeID, Object Carat, Object ColorID, Object ClarityID, Object FancyColorID, Object ColorIntensityID, Object ColorModifierID, Object CutID, Object ColorName, Object CertNumber, Object LabID, Object BranchID, Object Debug,out Object DiamondID,out Object ProductID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierLot", SqlDbType.NVarChar, 50, SupplierLot);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@Carat", SqlDbType.Decimal, 0, Carat);
		pl.Add("@ColorID", SqlDbType.Int, 0, ColorID);
		pl.Add("@ClarityID", SqlDbType.Int, 0, ClarityID);
		pl.Add("@FancyColorID", SqlDbType.Int, 0, FancyColorID);
		pl.Add("@ColorIntensityID", SqlDbType.Int, 0, ColorIntensityID);
		pl.Add("@ColorModifierID", SqlDbType.NVarChar, 50, ColorModifierID);
		pl.Add("@CutID", SqlDbType.Int, 0, CutID);
		pl.Add("@ColorName", SqlDbType.NVarChar, 50, ColorName);
		pl.Add("@CertNumber", SqlDbType.NVarChar, 50, CertNumber);
		pl.Add("@LabID", SqlDbType.Int, 0, LabID);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
		pl.AddOut("@DiamondID", SqlDbType.Int, 0);
		pl.AddOut("@ProductID", SqlDbType.Int, 0);
        data.RunProc("SegomaInterface.UpdateDiamond",pl);
        
		DiamondID= pl.GetParamValue("@DiamondID");
		ProductID= pl.GetParamValue("@ProductID");
        data.Close();        
    }
    
    public void UpdateDiamondToOdiroProject_SegomaInterface( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("SegomaInterface.UpdateDiamondToOdiroProject",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondToR2Net_SegomaInterface( Object DataTable, Object BranchID, Object Debug)
    {
        ParamList pl = new ParamList();
		pl.Add("@DataTable", DataTable);
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@Debug", SqlDbType.Bit, 0, Debug);
        data.RunProc("SegomaInterface.UpdateDiamondToR2Net",pl);
        
        data.Close();        
    }
    
    public void UpdateProductStatus_SegomaInterface( Object ProductID, Object SegomaProductStatusId)
    {
        ParamList pl = new ParamList();
		pl.Add("@ProductID", SqlDbType.Int, 0, ProductID);
		pl.Add("@SegomaProductStatusId", SqlDbType.Int, 0, SegomaProductStatusId);
        data.RunProc("SegomaInterface.UpdateProductStatus",pl);
        
        data.Close();        
    }
    
    public void UpdateSegomaBranchID_SegomaInterface( Object BranchID, Object SegomaBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@BranchID", SqlDbType.Int, 0, BranchID);
		pl.Add("@SegomaBranchID", SqlDbType.NVarChar, 50, SegomaBranchID);
        data.RunProc("SegomaInterface.UpdateSegomaBranchID",pl);
        
        data.Close();        
    }
    
    public void UpdateSegomaRefCode_SegomaInterface( Object ProductID, Object SegomaRefCode, Object SegomaPhotoID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ProductID", SqlDbType.Int, 0, ProductID);
		pl.Add("@SegomaRefCode", SqlDbType.NVarChar, 50, SegomaRefCode);
		pl.Add("@SegomaPhotoID", SqlDbType.NVarChar, 50, SegomaPhotoID);
        data.RunProc("SegomaInterface.UpdateSegomaRefCode",pl);
        
        data.Close();        
    }
    
}
