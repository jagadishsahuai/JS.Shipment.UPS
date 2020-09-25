using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupGetServiceCenterFacilitiesRequest
    {
        RequestType Request { get; set; }
        PickupPieceServiceType[] PickupPiece { get; set; }
        OriginAddressType OriginAddress { get; set; }
        DestinationAddressType DestinationAddress { get; set; }
        string Locale { get; set; }
        string ProximitySearchIndicator { get; set; }
    }
}
