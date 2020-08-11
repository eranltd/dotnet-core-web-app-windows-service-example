using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CPAPIWatchService.HostedServices.DAL
{
    public class DataLayerProxy
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(DataLayerProxy));

        public DataLayerProxy()
        {
        }

        public bool NotifyAboutServiceStatus(XDocument resultXML, XDocument resultDataXML = null)
        {
            try
            {
                using (DataLayer dlam = new DataLayer())
                {
                    dlam.InsertReport_Monitor(resultXML.ToString(), resultDataXML?.ToString());
                    return true;
                }
            }
            catch (Exception ex) //we dont want our program to fail in case of fault attemp
            {
                _logger.Error(ex.ToString());
                return false;
            }
        }

        public string GetTopSuccessActions()
        {
            string result = default(string);
            try
            {
                using (DataLayer dlam = new DataLayer())
                {
                    result = dlam.GetTopSuccessActions_CertProcessorJSON();
                    return result;
                }
            }
            catch (Exception ex) //we dont want our program to fail in case of fault attemp
            {
                _logger.Error(ex.ToString());
                return result;
            }
        }
    }
}
