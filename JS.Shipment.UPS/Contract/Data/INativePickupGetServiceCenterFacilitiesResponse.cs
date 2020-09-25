using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativePickupGetServiceCenterFacilitiesResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        PickupGetServiceCenterFacilitiesResponse PickupGetServiceCenterFacilitiesResponse { get; set; }
    }
}
