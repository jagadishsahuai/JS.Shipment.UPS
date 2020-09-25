using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativePickupCancelResponse: INativePickupCancelResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(PickupCancelResponse?.Response?.ResponseStatus?.Code);
            }
        }
        public PickupCancelResponse PickupCancelResponse { get; set; }        
    }
}
