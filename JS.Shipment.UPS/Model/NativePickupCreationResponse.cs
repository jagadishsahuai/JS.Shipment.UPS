using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativePickupCreationResponse : INativePickupCreationResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(PickupCreationResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public string PickupConfirmationNumber { get { return PickupCreationResponse?.PRN; } }
        [AutoMapper.IgnoreMap]
        public StatusCodeDescriptionType RateStatus { get { return PickupCreationResponse?.RateStatus; } }
        [AutoMapper.IgnoreMap]
        public RateResultType RateResult { get { return PickupCreationResponse?.RateResult; } }
        [AutoMapper.IgnoreMap]
        public ChargeDetailType[] ChargeDetails { get { return RateResult?.ChargeDetail; } }
        public PickupCreationResponse PickupCreationResponse { get; set; }
    }
}
