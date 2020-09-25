using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Model
{
    public class PickupRateRequest: IPickupRateRequest
    {
        public RequestType Request { get; set; }
        public ShipperAccountType ShipperAccount { get; set; }
        public PickupRateAddressType PickupAddress { get; set; }
        public string AlternateAddressIndicator { get; set; }
        public string ServiceDateOption { get; set; }
        public PickupDateInfoType PickupDateInfo { get; set; }
        public string TaxInformationIndicator { get; set; }
        public string UserLevelDiscountIndicator { get; set; }
    }
}
