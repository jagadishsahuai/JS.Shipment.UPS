using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentResponse
    {
        ResponseType Response { get; set; }
        ShipmentResultsType ShipmentResults { get; set; }
    }
}
