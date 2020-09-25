using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupGetServiceCenterFacilitiesResponse
    {
        ResponseType Response { get; set; }
        ServiceCenterLocationsType ServiceCenterLocation { get; set; }
    }
}