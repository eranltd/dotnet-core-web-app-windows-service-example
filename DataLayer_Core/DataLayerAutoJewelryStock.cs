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
//Functions for JewelryStock schema
//--------------------------------------------------------------------------------
    public XmlReader GetRingSizeXml_JewelryStock()
    {
        ParamList pl = new ParamList();
        XmlReader reader;
        data.RunProc("JewelryStock.GetRingSizeXml",pl, out reader);
        
        return reader;
    }
    
}
