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
//Functions for CertProcessor schema
//--------------------------------------------------------------------------------
    public String GetActionsListJSON_CertProcessorJSON( Object LabName, Object ActionTypeName, Object ActionStatusName)
    {
        ParamList pl = new ParamList();
		pl.Add("@LabName", SqlDbType.NVarChar, 100, LabName);
		pl.Add("@ActionTypeName", SqlDbType.NVarChar, 100, ActionTypeName);
		pl.Add("@ActionStatusName", SqlDbType.NVarChar, 20, ActionStatusName);
        
        return data.GetJSON("CertProcessor.GetActionsListJSON",pl);        
    }
    
    public String GetAggrTableStatisticsPerLabJSON_CertProcessorJSON( Object IntervalID)
    {
        ParamList pl = new ParamList();
		pl.Add("@IntervalID", SqlDbType.Int, 0, IntervalID);
        
        return data.GetJSON("CertProcessor.GetAggrTableStatisticsPerLabJSON",pl);        
    }
    
    public SqlDataReader GetCertProcessListActions_CertProcessorSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("CertProcessor.GetCertProcessListActions",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCertProcessListActions_CertProcessorDs()
    {
            SqlDataReader reader = GetCertProcessListActions_CertProcessorSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCertProcessListActions_16_04_2019_CertProcessorSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("CertProcessor.GetCertProcessListActions_16_04_2019",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCertProcessListActions_16_04_2019_CertProcessorDs()
    {
            SqlDataReader reader = GetCertProcessListActions_16_04_2019_CertProcessorSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetCertProcessListActions_16_04_2019_new_CertProcessorSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("CertProcessor.GetCertProcessListActions_16_04_2019_new",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetCertProcessListActions_16_04_2019_new_CertProcessorDs()
    {
            SqlDataReader reader = GetCertProcessListActions_16_04_2019_new_CertProcessorSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public XmlReader GetLabXML_CertProcessor( Object DiamondID)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
        XmlReader reader;
        data.RunProc("CertProcessor.GetLabXML",pl, out reader);
        
        return reader;
    }
    
    public String GetParserValidationDescriptionErrorsJSON_CertProcessorJSON( Object frmDate)
    {
        ParamList pl = new ParamList();
		pl.Add("@frmDate", SqlDbType.Date, 0, frmDate);
        
        return data.GetJSON("CertProcessor.GetParserValidationDescriptionErrorsJSON",pl);        
    }
    
    public String GetTopCertErrorsJSON_CertProcessorJSON( Object IntervalID)
    {
        ParamList pl = new ParamList();
		pl.Add("@IntervalID", SqlDbType.Int, 0, IntervalID);
        
        return data.GetJSON("CertProcessor.GetTopCertErrorsJSON",pl);        
    }
    
    public String GetTopExecutionsJSON_CertProcessorJSON( Object IntervalID)
    {
        ParamList pl = new ParamList();
		pl.Add("@IntervalID", SqlDbType.Int, 0, IntervalID);
        
        return data.GetJSON("CertProcessor.GetTopExecutionsJSON",pl);        
    }

    public String GetTopSuccessActions_CertProcessorJSON()
    {
        ParamList pl = new ParamList();
  
        return data.GetJSON("CertProcessor.GetTopSuccessActions", pl);
    }

    public SqlDataReader GetTopSuccessActions_CertProcessorSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("CertProcessor.GetTopSuccessActions",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTopSuccessActions_CertProcessorDs()
    {
            SqlDataReader reader = GetTopSuccessActions_CertProcessorSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public SqlDataReader GetTopSuccessActionsSharon_CertProcessorSDR()
    {
        ParamList pl = new ParamList();
        SqlDataReader reader;
        data.RunProc("CertProcessor.GetTopSuccessActionsSharon",pl, out reader);
        
        return reader;
    }
    
    public DataSet GetTopSuccessActionsSharon_CertProcessorDs()
    {
            SqlDataReader reader = GetTopSuccessActionsSharon_CertProcessorSDR();
            DataSet ds = GetDataSet(reader); 
            reader.Close();
            data.Close();
            return ds;
           
    }
    
    public String GetTopUnCoveredCertificatesJSON_CertProcessorJSON( Object frmDate)
    {
        ParamList pl = new ParamList();
		pl.Add("@frmDate", SqlDbType.Date, 0, frmDate);
        
        return data.GetJSON("CertProcessor.GetTopUnCoveredCertificatesJSON",pl);        
    }
    
    public void RefreshReportUpdateForSupplier_CertProcessor( Object SupplierBranchID)
    {
        ParamList pl = new ParamList();
		pl.Add("@SupplierBranchID", SqlDbType.Int, 0, SupplierBranchID);
        data.RunProc("CertProcessor.RefreshReportUpdateForSupplier",pl);
        
        data.Close();        
    }
    
    public void ResetCertificaLabDataForDimentionGroup_CertProcessor( Object CertificateDimensions)
    {
        ParamList pl = new ParamList();
		pl.Add("@CertificateDimensions", SqlDbType.NVarChar, 50, CertificateDimensions);
        data.RunProc("CertProcessor.ResetCertificaLabDataForDimentionGroup",pl);
        
        data.Close();        
    }
    
    public void UpdateLabXML_CertProcessor( Object DiamondID, Object LabXML)
    {
        ParamList pl = new ParamList();
		pl.Add("@DiamondID", SqlDbType.Int, 0, DiamondID);
		pl.Add("@LabXML", SqlDbType.Xml, 0, LabXML);
        data.RunProc("CertProcessor.UpdateLabXML",pl);
        
        data.Close();        
    }
    
}
