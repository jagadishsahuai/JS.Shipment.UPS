using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativeShipConfirmResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        string MasterTrackingReferenceNumber { get; }
        [AutoMapper.IgnoreMap]
        string ShipmentDigest { get; }
        [AutoMapper.IgnoreMap]
        ShipmentChargesType ShipmentCharges { get; }
        ShipConfirmResponse ShipConfirmResponse { get; set; }
    }
}
