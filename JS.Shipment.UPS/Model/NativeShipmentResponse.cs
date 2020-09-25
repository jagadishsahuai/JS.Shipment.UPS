using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativeShipmentResponse : INativeShipmentResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(ShipmentResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public string MasterTrackingReferenceNumber
        {
            get
            {
                return ShipmentResponse?.ShipmentResults?.ShipmentIdentificationNumber;
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
                return ShipmentResponse?.ShipmentResults?.PackageResults?.Select(x => x.TrackingNumber).ToList();
            }
        }
        [AutoMapper.IgnoreMap]
        public ShipmentChargesType ShipmentCharges
        {
            get
            {
                return ShipmentResponse?.ShipmentResults?.ShipmentCharges;
            }
        }
        public ShipmentResponse ShipmentResponse { get; set; }        
    }
}
