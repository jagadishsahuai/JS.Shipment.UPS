using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Configuration
{
    public class EndPointConfiguration
    {
        public string ShipServiceUrl { get; set; }
        public string VoidServiceUrl { get; set; }        
        public string PickupServiceUrl { get; set; }
        public string TrackServiceUrl { get; set; }
        public string LabelRecoveryServiceUrl { get; set; }
    }
}
