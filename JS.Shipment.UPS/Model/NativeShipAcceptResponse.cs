using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativeShipAcceptResponse : INativeShipAcceptResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(ShipAcceptResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public string MasterTrackingReferenceNumber
        {
            get
            {
                return ShipAcceptResponse?.ShipmentResults?.ShipmentIdentificationNumber;
            }
        }
        [AutoMapper.IgnoreMap]
        public string PackageTrackingReferenceNumbers
        {
            get
            {
                return string.Join(AppConstants.PACKAGE_TRACKING_NUMBER_DELIMETER, PackageTrackingReferenceNumberList);
            }
        }
        [AutoMapper.IgnoreMap]
        public List<string> PackageTrackingReferenceNumberList
        {
            get
            {
                return ShipAcceptResponse?.ShipmentResults?.PackageResults?.Select(x => x.TrackingNumber).ToList();
            }
        }
        [AutoMapper.IgnoreMap]
        public ShipmentChargesType ShipmentCharges
        {
            get
            {
                return ShipAcceptResponse?.ShipmentResults?.ShipmentCharges;
            }
        }
        public ShipAcceptResponse ShipAcceptResponse { get; set; }
    }
}
