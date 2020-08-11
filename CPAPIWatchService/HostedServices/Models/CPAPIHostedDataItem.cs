using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CPAPIWatchService.HostedServices.Models
{
    public class CPAPIHostedDataItem
    {
        [DataMember]
        public string LabName { get; set; }
        [DataMember]
        public string DiamondID { get; set; }
        [DataMember]
        public string ActionType { get; set; }


        /*Additional Info*/
        public bool Valid { get; set; }
        public string Error { get; set; }
        public Stopwatch StopWatch { get; set; } = new Stopwatch();
        /**/
    }
}
