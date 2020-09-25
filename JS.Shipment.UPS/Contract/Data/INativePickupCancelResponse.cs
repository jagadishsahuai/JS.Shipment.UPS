using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativePickupCancelResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        PickupCancelResponse PickupCancelResponse { get; set; }
    }
}
