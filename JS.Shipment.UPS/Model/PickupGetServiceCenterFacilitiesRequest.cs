using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupGetServiceCenterFacilitiesRequest: IPickupGetServiceCenterFacilitiesRequest
    {
        public RequestType Request { get; set; }
        public PickupPieceServiceType[] PickupPiece { get; set; }
        public OriginAddressType OriginAddress { get; set; }
        public DestinationAddressType DestinationAddress { get; set; }
        public string Locale { get; set; }
        public string ProximitySearchIndicator { get; set; }
    }
}
