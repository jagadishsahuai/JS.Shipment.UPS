using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativePickupPendingStatusResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        PickupPendingStatusResponse PickupPendingStatusResponse { get; set; }
    }
}
