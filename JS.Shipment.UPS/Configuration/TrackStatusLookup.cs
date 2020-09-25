using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Configuration
{
    public class TrackStatusLookup
    {
        public StatusType Status { get; set; }
        public int LocalStatusCode { get; set; }
    }
}
