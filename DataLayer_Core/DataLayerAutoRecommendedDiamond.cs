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
//Functions for RecommendedDiamond schema
//--------------------------------------------------------------------------------
    public void AddRecommendedDiamond_RecommendedDiamond( Object DiamondID, Object CaratGroupID, Object ShapeID, Object IsOnKay, Object IsOnJared, Object IsOnJamesAllen, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@CaratGroupID", SqlDbType.Int, 0, CaratGroupID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@IsOnKay", SqlDbType.Bit, 0, IsOnKay);
		pl.Add("@IsOnJared", SqlDbType.Bit, 0, IsOnJared);
		pl.Add("@IsOnJamesAllen", SqlDbType.Bit, 0, IsOnJamesAllen);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        data.RunProc("RecommendedDiamond.AddRecommendedDiamond",pl);
        
        data.Close();        
    }
    
    public void DelteteRecommendedInventory_old_RecommendedDiamond( Object RecommendedInventoryIDList)
    {
        ParamList pl = new ParamList();
		pl.Add("@RecommendedInventoryIDList", SqlDbType.NVarChar, 100, RecommendedInventoryIDList);
        data.RunProc("RecommendedDiamond.DelteteRecommendedInventory_old",pl);
        
        data.Close();        
    }
    
    public SqlDataReader GetAllRecommendedDiamonds_RecommendedDiamondSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetAllRecommendedDiamonds",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetAllRecommendedDiamonds_RecommendedDiamondDs( Object ContactID)
    {
            SqlDataReader reader = GetAllRecommendedDiamonds_RecommendedDiamondSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetDiamondsForRcommandationXml_old_RecommendedDiamondSDR( Object PageSize, Object PageNumber, Object ShapeList, Object CutList, Object ColorList, Object ClarityList, Object PolishList, Object SymmetryList, Object CaratFrom, Object CaratTo, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object OrderBy, Object MoreOp, Object FlourList, Object FluorList, Object LabList, Object IDs, Object Src, Object SupplierID)
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
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetDiamondsForRcommandationXml_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetDiamondsForRcommandationXml_old_RecommendedDiamondDs( Object PageSize, Object PageNumber, Object ShapeList, Object CutList, Object ColorList, Object ClarityList, Object PolishList, Object SymmetryList, Object CaratFrom, Object CaratTo, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object OrderBy, Object MoreOp, Object FlourList, Object FluorList, Object LabList, Object IDs, Object Src, Object SupplierID)
    {
            SqlDataReader reader = GetDiamondsForRcommandationXml_old_RecommendedDiamondSDR(  PageSize,  PageNumber,  ShapeList,  CutList,  ColorList,  ClarityList,  PolishList,  SymmetryList,  CaratFrom,  CaratTo,  PriceFrom,  PriceTo,  DepthFrom,  DepthTo,  TableFrom,  TableTo,  OrderBy,  MoreOp,  FlourList,  FluorList,  LabList,  IDs,  Src,  SupplierID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetDiamondsForRecommandationXml_RecommendedDiamond( Object PageSize, Object PageNumber, Object ShapeList, Object CutList, Object ColorList, Object ClarityList, Object PolishList, Object SymmetryList, Object CaratFrom, Object CaratTo, Object PriceFrom, Object PriceTo, Object DepthFrom, Object DepthTo, Object TableFrom, Object TableTo, Object OrderBy, Object MoreOp, Object FlourList, Object FluorList, Object LabList, Object IDs, Object Src, Object SupplierID, Object IsOnKay, Object IsOnJared, Object IsOnJamesAllen, Object FromDate, Object ToDate, Object ContactID)
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
        data.RunProc("RecommendedDiamond.GetDiamondsForRecommandationXml",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetInitData_RecommendedDiamondSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetInitData",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetInitData_RecommendedDiamondDs()
    {
            SqlDataReader reader = GetInitData_RecommendedDiamondSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetPresetRings_RecommendedDiamondSDR( Object CaratGroupID, Object ShapeID, Object RingStyleID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CaratGroupID", SqlDbType.Int, 0, CaratGroupID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@RingStyleID", SqlDbType.Int, 0, RingStyleID);
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetPresetRings",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetPresetRings_RecommendedDiamondDs( Object CaratGroupID, Object ShapeID, Object RingStyleID)
    {
            SqlDataReader reader = GetPresetRings_RecommendedDiamondSDR(  CaratGroupID,  ShapeID,  RingStyleID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetRecommendedDiamondXML_RecommendedDiamond( Object DiamondID, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        XmlReader reader;
        data.RunProc("RecommendedDiamond.GetRecommendedDiamondXML",pl, out reader);
        
        return reader;
    }
    
    public SqlDataReader GetRecommendedInventory_RecommendedDiamondSDR( Object CaratGroupID, Object ShapeID, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CaratGroupID", SqlDbType.Int, 0, CaratGroupID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetRecommendedInventory",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRecommendedInventory_RecommendedDiamondDs( Object CaratGroupID, Object ShapeID, Object ContactID)
    {
            SqlDataReader reader = GetRecommendedInventory_RecommendedDiamondSDR(  CaratGroupID,  ShapeID,  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRecommendedInventory_old_RecommendedDiamondSDR( Object CaratGroupID, Object ShapeID, Object RecommendedInventoryID)
    {
        ParamList pl = new ParamList();
		pl.Add("@CaratGroupID", SqlDbType.Int, 0, CaratGroupID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@RecommendedInventoryID", SqlDbType.Int, 0, RecommendedInventoryID);
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetRecommendedInventory_old",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRecommendedInventory_old_RecommendedDiamondDs( Object CaratGroupID, Object ShapeID, Object RecommendedInventoryID)
    {
            SqlDataReader reader = GetRecommendedInventory_old_RecommendedDiamondSDR(  CaratGroupID,  ShapeID,  RecommendedInventoryID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetRecommenderProfile_RecommendedDiamondSDR( Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        SqlDataReader reader;
        data.RunProc("RecommendedDiamond.GetRecommenderProfile",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetRecommenderProfile_RecommendedDiamondDs( Object ContactID)
    {
            SqlDataReader reader = GetRecommenderProfile_RecommendedDiamondSDR(  ContactID);
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public void RemoveRecommendedDiamond_RecommendedDiamond( Object DiamondList, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondList", SqlDbType.NVarChar, 0, DiamondList);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        data.RunProc("RecommendedDiamond.RemoveRecommendedDiamond",pl);
        
        data.Close();        
    }
    
    public string SaveRecommendedInventory_RecommendedDiamond( Object RecommendedInventoryID, Object CaratGroupID, Object ShapeID, Object Lot)
    {
        ParamList pl = new ParamList();
		pl.Add("@RecommendedInventoryID", SqlDbType.Int, 0, RecommendedInventoryID);
		pl.Add("@CaratGroupID", SqlDbType.Int, 0, CaratGroupID);
		pl.Add("@ShapeID", SqlDbType.Int, 0, ShapeID);
		pl.Add("@Lot", SqlDbType.NVarChar, 50, Lot);
        
        string id = data.ExecuteScalar("RecommendedDiamond.SaveRecommendedInventory",pl);
        
        data.Close();
        return id;
    }
    
    public void SetIgnore_old_RecommendedDiamond( Object Ignore, Object Lot)
    {
        ParamList pl = new ParamList();
		pl.Add("@Ignore", SqlDbType.Bit, 0, Ignore);
		pl.Add("@Lot", SqlDbType.NVarChar, 50, Lot);
        data.RunProc("RecommendedDiamond.SetIgnore_old",pl);
        
        data.Close();        
    }
    
    public void SetIgnoredStatus_RecommendedDiamond( Object DiamondID, Object Ignore, Object ContactID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@Ignore", SqlDbType.Int, 0, Ignore);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
        data.RunProc("RecommendedDiamond.SetIgnoredStatus",pl);
        
        data.Close();        
    }
    
    public void SetPriority_RecommendedDiamond( Object DiamiondList)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamiondList", SqlDbType.NVarChar, 0, DiamiondList);
        data.RunProc("RecommendedDiamond.SetPriority",pl);
        
        data.Close();        
    }
    
    public void UpdateDiamondSuggestion_RecommendedDiamond( Object DiamondID, Object ContactID, Object SuggestionIDs, Object CustomSuggestion)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@SuggestionIDs", SqlDbType.NVarChar, 50, SuggestionIDs);
		pl.Add("@CustomSuggestion", SqlDbType.NVarChar, 50, CustomSuggestion);
        data.RunProc("RecommendedDiamond.UpdateDiamondSuggestion",pl);
        
        data.Close();        
    }
    
    public void UpdatePosition_RecommendedDiamond( Object Xml)
    {
        ParamList pl = new ParamList();
		pl.Add("@Xml", SqlDbType.Xml, 0, Xml);
        data.RunProc("RecommendedDiamond.UpdatePosition",pl);
        
        data.Close();        
    }
    
    public void UpdateRecommenderProfile_RecommendedDiamond( Object ContactID, Object FirstName, Object LastName, Object Description, Object Focus, Object Picture)
    {
        ParamList pl = new ParamList();
		pl.Add("@ContactID", SqlDbType.Int, 0, ContactID);
		pl.Add("@FirstName", SqlDbType.NVarChar, 50, FirstName);
		pl.Add("@LastName", SqlDbType.NVarChar, 50, LastName);
		pl.Add("@Description", SqlDbType.NVarChar, 1000, Description);
		pl.Add("@Focus", SqlDbType.NVarChar, 100, Focus);
		pl.Add("@Picture", SqlDbType.NVarChar, 0, Picture);
        data.RunProc("RecommendedDiamond.UpdateRecommenderProfile",pl);
        
        data.Close();        
    }
    
}
