using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CPAPIWatchService.HostedServices.Models
{
    public class CertNumberItem
    {
        [DataMember]
        public string CertNumber { get; set; }

    }
}
