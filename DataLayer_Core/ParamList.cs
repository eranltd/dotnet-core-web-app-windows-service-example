using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// SqlParameter list
/// </summary>
public class ParamList
{
    private List<SqlParameter> prams = new List<SqlParameter>();


    /// <summary>
    /// Add input SqlParameter 
    /// </summary>
    /// <param name="paramName">Name of param.</param>
    /// <param name="dbType">Param type.</param>
    /// <param name="size">Param size. use 0 for unknown size.</param>
    /// <param name="value">Param value.</param>
    public void Add(string paramName, SqlDbType dbType, int size, object value)
    {

        // removed by yaniv on 15.02.2016, reason - will not save string.empty in case we want to clear notes for example.
        //if (value != null && !string.IsNullOrEmpty(value.ToString()))

        if (value != DBNull.Value)
            prams.Add(MakeInParam(paramName, dbType, size, value));
    }

    public void Add(string paramName, object value)
    {
        if (value != null && !string.IsNullOrEmpty(value.ToString()))
            prams.Add(new SqlParameter(paramName, value));
    }

    /// <summary>
    /// Make Output SqlParameter.
    /// </summary>
    /// <param name="paramName">Name of param.</param>
    /// <param name="dbType">Param type.</param>
    /// <param name="size">Param size.</param>
    public void AddOut(string paramName, SqlDbType dbType, int size)
    {
        prams.Add(MakeOutParam(paramName, dbType, size));
    }

    /// <summary>
    /// Convert the list to SqlParameter array
    /// </summary>
    /// <returns>SqlParameter[] fo the list</returns>
    public SqlParameter[] ToArray()
    {
        return prams.ToArray();
    }

    public string getKeyForCache()
    {
        string key = string.Empty;
        for (int i = 0; i < this.prams.Count; i++)
        {
            key += this.prams[i].ParameterName + "=" + this.prams[i].Value.ToString();
        }
        return key;
    }

    /// <summary>
    /// Make input param.
    /// </summary>
    /// <param name="paramName">Name of param.</param>
    /// <param name="dbType">Param type.</param>
    /// <param name="size">Param size.</param>
    /// <param name="value">Param value.</param>
    /// <returns>New parameter.</returns>
    public SqlParameter MakeInParam(string paramName, SqlDbType dbType, int size, object value)
    {
        return MakeParam(paramName, dbType, size, ParameterDirection.Input, value);
    }

    /// <summary>
    /// Make Output param.
    /// </summary>
    /// <param name="paramName">Name of param.</param>
    /// <param name="dbType">Param type.</param>
    /// <param name="size">Param size.</param>
    /// <returns>New parameter.</returns>
    public SqlParameter MakeOutParam(string paramName, SqlDbType dbType, int size)
    {
        return MakeParam(paramName, dbType, size, ParameterDirection.Output, null);
    }

    /// <summary>
    /// Make stored procedure param.
    /// </summary>
    /// <param name="paramName">Name of param.</param>
    /// <param name="dbType">Param type.</param>
    /// <param name="size">Param size.</param>
    /// <param name="direction">Parm direction.</param>
    /// <param name="value">Param value.</param>
    /// <returns>New parameter.</returns>
    public SqlParameter MakeParam(string paramName, SqlDbType dbType, Int32 size, ParameterDirection direction, object value)
    {
        SqlParameter param;

        if (size > 0)
            param = new SqlParameter(paramName, dbType, size);
        else
            param = new SqlParameter(paramName, dbType);

        param.Direction = direction;
        if (!(direction == ParameterDirection.Output && value == null))
            param.Value = value;

        return param;
    }

    public object GetParamValue(string paramName)
    {
        for (int i = 0; i < prams.Count; i++)
        {
            if (prams[i].ParameterName == paramName)
                return prams[i];
        }
        return null;
    }
}
