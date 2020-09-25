using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativePickupGetServiceCenterFacilitiesResponse: INativePickupGetServiceCenterFacilitiesResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(PickupGetServiceCenterFacilitiesResponse?.Response?.ResponseStatus?.Code);
            }
        }
        public PickupGetServiceCenterFacilitiesResponse PickupGetServiceCenterFacilitiesResponse { get; set; }        
    }
}
