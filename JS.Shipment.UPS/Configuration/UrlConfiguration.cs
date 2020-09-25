using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Configuration
{
    public class UrlConfiguration
    {
        public EndPointConfiguration TestEndPoint { get; set; }
        public EndPointConfiguration ProductionEndPoint { get; set; }
    }
}
