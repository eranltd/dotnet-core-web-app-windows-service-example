using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CPAPIWatchService.HostedServices.DAL
{
    public class CacheRemoverHosterServiceDAL
    {
        public static string GetDiamondsCertificatesForSaleJSON()
        {
            string connectionString = @"data source = sql.VMCLUSTER2.LOCAL; initial catalog = CertProcessor; Integrated Security = true; MultipleActiveResultSets = True; App = CertsProcessor; User ID = VMCLUSTER2\CertProcessorService; Password = E8Gi0Le5Xy6Wa3";
            string sprocname = "[dbo].[GetDiamondsCertificatesForSaleJSON]";
            string jsonOutputParam = "@jsonOutput";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sprocname, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Create output parameter. "-1" is used for nvarchar(max)
                    cmd.Parameters.Add(jsonOutputParam, SqlDbType.NVarChar, -1).Direction = ParameterDirection.Output;

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Get the values
                    string json = cmd.Parameters[jsonOutputParam].Value.ToString();

                    return json;
                }
            }

        }
    }
}
