using CPAPIWatchService.HostedServices.BLL;
using CPAPIWatchService.HostedServices.DAL;
using CPAPIWatchService.HostedServices.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CPAPIWatchService.HostedServices
{
    internal class CPAPIHostedService : IHostedService, IDisposable
    {
        private readonly ILogger _logger;
        private Timer _timer;

        private static readonly log4net.ILog log = log4net.LogManager
           .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public CPAPIHostedService(ILogger<CPAPIHostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CP API Timed Background Service is starting.");
            log.Info("CP API Timed Background Service is starting.");


            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromHours(1));



            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            List<CPAPIHostedDataItem> dataItems = default(List<CPAPIHostedDataItem>);
            XDocument resultData = null;
            _logger.LogInformation("Checking...CP API");
            log.Info("Checking...CP API");

            //check using BLL -> Logic
            //if true-> update monitor service -> null -> don't update monitor service.

            if (CPIAPIHosted.AllLabsValid(out dataItems))
            {
                resultData = GetXMLFromCPIHostedDataItem(dataItems);
                //update monitor service.
                new DataLayerProxy().NotifyAboutServiceStatus(GenerateReportXML(Monitor.ServiceStatus.Success,dataItems, "CPIAPI Working Perfectly"), resultData);
                _logger.LogInformation("CP API Working Perfectly.");
                log.Info("CP API Working Perfectly.");

            }
            else
            {
                resultData = GetXMLFromCPIHostedDataItem(dataItems);
                new DataLayerProxy().NotifyAboutServiceStatus(GenerateReportXML(Monitor.ServiceStatus.Error,dataItems, "CPIAPI is not available."), resultData);
                _logger.LogInformation("CP API is not Working.");
                log.Info("CP API is not Working.");


            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CP API Timed Background Service is stopping.");
            log.Info("CP API Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        #region Helper Methods


        private XDocument GetXMLFromCPIHostedDataItem(List<CPAPIHostedDataItem> dataItems)
        {

            // Build the document
            XElement xdoc = new XElement("LabsHealth");


            var grp =
                // This is the root of the document
                // new XElement("LabsHealthy",
                from dataItem in dataItems
                    //group dataItem by dataItem.LabName,dataItem. into LabItem

                group dataItem by new

                { dataItem.LabName } into LabGroup
                select LabGroup;


            //It will iterate through each group
            foreach (var group in grp)
            {
                var DownloadDiamondCertElement = group.First();
                var UpdateDiamondPropsElement = group.Skip(1).First();


                XElement PDF =  //UpdateDiamondProps
                        new XElement("DownloadDiamondCert", new XAttribute("ID", DownloadDiamondCertElement.GetHashCode()),
                        new XElement("LabName", DownloadDiamondCertElement.LabName),
                        new XElement("DiamondID", DownloadDiamondCertElement.DiamondID),
                        new XElement("ActionType", DownloadDiamondCertElement.ActionType),
                        new XElement("Valid", DownloadDiamondCertElement.Valid),
                        new XElement("Error", DownloadDiamondCertElement.Error),
                        new XElement("Duration", UpdateDiamondPropsElement.StopWatch.Elapsed.TotalSeconds)
                );

                XElement LabData =  //UpdateDiamondProps
                        new XElement("UpdateDiamondProps", new XAttribute("ID", UpdateDiamondPropsElement.GetHashCode()),
                        new XElement("LabName", UpdateDiamondPropsElement.LabName),
                        new XElement("DiamondID", UpdateDiamondPropsElement.DiamondID),
                        new XElement("ActionType", UpdateDiamondPropsElement.ActionType),
                        new XElement("Valid", UpdateDiamondPropsElement.Valid),
                        new XElement("Error", UpdateDiamondPropsElement.Error),
                        new XElement("Duration",UpdateDiamondPropsElement.StopWatch.Elapsed.TotalSeconds)
                );
                xdoc.Add(new XElement(group.Key.LabName,PDF,LabData));
            }
            return new XDocument(xdoc);
    }

        private XDocument GenerateReportXML(Monitor.ServiceStatus serviceStatus,List<CPAPIHostedDataItem> dataItems = null, string errorDescription = "", string notes = "")
        {

            XDocument xDoc = new XDocument(
                            new XElement("Report",
                                            new XAttribute("MonitorServiceID", 68),
                                            new XAttribute("Status", serviceStatus),
                                            new XAttribute("ErrorDescription", errorDescription),
                                            new XAttribute("Notes", notes)
                                            ));
            return xDoc;
        }

        public static string GenerateLabHealthData(List<CPAPIHostedDataItem> dataItems)
        {
            var json = JsonConvert.SerializeObject(dataItems);
            return json;
        }

        public static class Monitor
        {
            public enum ServiceStatus
            {
                Error = -1,
                Unknown = 0,
                Interrupted = 1,
                Working = 2,
                Success = 3
            }

        }
        #endregion
    }

}
