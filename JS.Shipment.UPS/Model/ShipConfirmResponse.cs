using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipConfirmResponse: IShipConfirmResponse
    {
        public ResponseType Response { get; set; }
        public ShipmentResultsType ShipmentResults { get; set; }
    }
}