using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using JS.Shipment.UPS.Constant;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativeTrackResponse : INativeTrackResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(TrackResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public IDictionary<string, CommonCodeDescriptionType> CurrentShipmentStatuses
        {
            get
            {
                return new Dictionary<string, CommonCodeDescriptionType>(TrackResponse?.Shipment.Select(shipment => new KeyValuePair<string, CommonCodeDescriptionType>(shipment.InquiryNumber?.Value, shipment.CurrentStatus)));
            }
        }
        [AutoMapper.IgnoreMap]
        public IDictionary<string, ActivityType[]> PackageActivities
        {
            get
            {
                return new Dictionary<string, ActivityType[]>(TrackResponse?.Shipment.FirstOrDefault()?.Package.Select(x => new KeyValuePair<string, ActivityType[]>(x.TrackingNumber, x.Activity.OrderBy(y=>y.Date+y.Time).ToArray())));
            }
        }
        [AutoMapper.IgnoreMap]
        public IDictionary<string, ActivityType> PackageLastActivity
        {
            get
            {
                return new Dictionary<string, ActivityType>(PackageActivities.Select(x => new KeyValuePair<string, ActivityType>(x.Key, x.Value.Where(y => y.Date == x.Value.OrderByDescending(z => z.Date + z.Time).FirstOrDefault().Date && y.Time == x.Value.OrderByDescending(z => z.Date + z.Time).FirstOrDefault().Time).FirstOrDefault())));
            }
        }
        public TrackResponse TrackResponse { get; set; }
    }
}
