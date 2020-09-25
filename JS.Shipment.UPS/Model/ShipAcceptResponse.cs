using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipAcceptResponse: IShipAcceptResponse
    {
        public ResponseType Response { get; set; }
        public ShipmentResultsType ShipmentResults { get; set; }
    }    
}