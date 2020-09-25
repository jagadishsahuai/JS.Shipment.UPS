using JS.Shipment.UPS.Model;
using System.Collections.Generic;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativeVoidShipmentResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        bool IsDeleted { get; }
        [AutoMapper.IgnoreMap]
        bool IsPartiallyDeleted { get; }
        [AutoMapper.IgnoreMap]
        List<string> DeletedPackageTrackingNumberList { get; }
        [AutoMapper.IgnoreMap]
        string DeletedPackageTrackingNumbers { get; }
        [AutoMapper.IgnoreMap]
        List<string> AlreadyDeletedPackageTrackingNumberList { get; }
        [AutoMapper.IgnoreMap]
        string AlreadyDeletedPackageTrackingNumbers { get; }
        [AutoMapper.IgnoreMap]
        List<string> FailedDeletionPackageTrackingNumberList { get; }
        [AutoMapper.IgnoreMap]
        string FailedDeletionPackageTrackingNumbers { get; }
        VoidShipmentResponse VoidShipmentResponse { get; set; }
    }
}
