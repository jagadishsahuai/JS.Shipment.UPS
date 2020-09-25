using JS.Shipment.UPS.Model;
using System.Collections.Generic;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativeShipmentResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        string MasterTrackingReferenceNumber { get; }
        [AutoMapper.IgnoreMap]
        string PackageTrackingReferenceNumbers { get; }
        [AutoMapper.IgnoreMap]
        List<string> PackageTrackingReferenceNumberList { get; }
        [AutoMapper.IgnoreMap]
        ShipmentChargesType ShipmentCharges { get; }
        ShipmentResponse ShipmentResponse { get; set; }
    }
}
