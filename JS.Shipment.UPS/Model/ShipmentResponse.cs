using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentResponse: IShipmentResponse
    {
        public ResponseType Response { get; set; }
        public ShipmentResultsType ShipmentResults { get; set; }
    }
}