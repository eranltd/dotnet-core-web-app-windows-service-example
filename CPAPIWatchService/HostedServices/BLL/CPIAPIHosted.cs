using CPAPIWatchService.HostedServices.DAL;
using CPAPIWatchService.HostedServices.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CPAPIWatchService.HostedServices.BLL
{
    public class CPIAPIHosted
    {


        public static bool AllLabsValid(out List<CPAPIHostedDataItem> dataItems)
        {
            dataItems = null;

            try
            {
                //get top successfull diamond download certificate from DB
                string topSuccessJSON = new DataLayerProxy().GetTopSuccessActions();
                if (topSuccessJSON != null && !topSuccessJSON.Equals("[]"))
                {
                    JArray jArray = JArray.Parse(topSuccessJSON);
                    dataItems = jArray.ToObject<List<CPAPIHostedDataItem>>();

                    //try to fetch it again, using WebClient.
                    foreach (var item in dataItems)
                    {
                        if (IsStreamValidAsync(item).Result == false)
                        {

                            //do something with that data...
                            return false;
                        }
                    }


                    return true;

                }
            }
            catch (Exception)
            {
                return false;
            }





            //covered and Uncovered Version.
            return false;
        }

        public static async Task<bool> IsStreamValidAsync(CPAPIHostedDataItem item)
        {
            const string DownloadDiamondCertURL = "http://172.27.5.26:9200/CertProcessorService/LabAPI/rest/GetDiamondCertificateFromLab/{0}";
            const string UpdateDiamondPropsURL = "http://172.27.5.26:9200/CertProcessorService/LabAPI/rest/GetDiamondDataFromLab/{0}";

            //check DiamondCert
            switch (item.ActionType)
            {
                case "DownloadDiamondCert":
                    {
                        return await TryFetchDataFromLab(item, DownloadDiamondCertURL);

                    }

                //check StoneProps
                case "UpdateDiamondProps":
                    {

                        return await TryFetchDataFromLab(item, UpdateDiamondPropsURL);

                    }

                default:
                    return false;
            }


        }

        private static async Task<bool> TryFetchDataFromLab(CPAPIHostedDataItem item, string URL)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(String.Format(URL, item.DiamondID)))
                    {
                        item.StopWatch.Start();
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        item.StopWatch.Stop();


                        if (apiResponse.Length < 50)
                        {
                            item.Error = apiResponse;
                            item.Valid = false;
                            return false;
                            //read exception
                        }
                        else
                        {
                            item.Valid = true;
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
