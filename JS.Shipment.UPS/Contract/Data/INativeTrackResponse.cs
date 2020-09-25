using JS.Shipment.UPS.Model;
using System.Collections.Generic;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativeTrackResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        IDictionary<string, CommonCodeDescriptionType> CurrentShipmentStatuses { get; }
        [AutoMapper.IgnoreMap]
        IDictionary<string, ActivityType[]> PackageActivities { get; }
        [AutoMapper.IgnoreMap]
        IDictionary<string, ActivityType> PackageLastActivity { get; }
        TrackResponse TrackResponse { get; set; }
        
    }
}
