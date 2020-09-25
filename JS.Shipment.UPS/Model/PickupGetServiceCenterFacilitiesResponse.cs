using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupGetServiceCenterFacilitiesResponse: IPickupGetServiceCenterFacilitiesResponse
    {
        public ResponseType Response { get; set; }
        public ServiceCenterLocationsType ServiceCenterLocation { get; set; }
    }
}