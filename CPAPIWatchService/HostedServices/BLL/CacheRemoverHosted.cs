using CPAPIWatchService.HostedServices.DAL;
using CPAPIWatchService.HostedServices.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CPAPIWatchService.HostedServices.BLL
{
    public class CacheRemoverHosted
    {
        private static readonly log4net.ILog log = log4net.LogManager
   .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static void Run(out long BytesSize)
        {
            BytesSize = 0;
            var json = CacheRemoverHosterServiceDAL.GetDiamondsCertificatesForSaleJSON();
            var CertificatesFromDB = JsonConvert.DeserializeObject<List<CertNumberItem>>(json).Select(item => (@"C:\PDF\" + item.CertNumber + "CER.pdf"));
            ///intersect with files at C:\PDF...
            ///Set a variable to the PDF path.
            try
            {
                string docPath = "C:\\PDF";

                //take only files from oldest date < half a year

                DirectoryInfo di = new DirectoryInfo(docPath);
                var files = di.GetFiles();

                var filesOrderedBy = files.Where(item => item.CreationTime.Date.Month < DateTime.Now.AddMonths(-6).Month).
                    OrderByDescending(file => file.CreationTime).ToList();

                var diffFiles = filesOrderedBy.Select(item => item.FullName).Except(CertificatesFromDB).ToList();  //.Take(100);
                BytesSize = diffFiles.Aggregate(Int64.Parse("0"), (acc, x) => new FileInfo(x).Length + acc);

                foreach(var filePath in diffFiles)
                {
                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (Exception e)
                    {
                        log.Error(e.Message);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                log.Error(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                log.Error(ex.Message);
            }




        }
    }
}
