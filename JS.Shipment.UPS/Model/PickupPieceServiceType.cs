using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupPieceServiceType: IPickupPieceServiceType
    {
        public string ServiceCode { get; set; }
        public string Quantity { get; set; }
        public string DestinationCountryCode { get; set; }
        public string ContainerCode { get; set; }
    }
}