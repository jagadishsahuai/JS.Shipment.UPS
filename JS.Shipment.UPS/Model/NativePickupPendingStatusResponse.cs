using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativePickupPendingStatusResponse : INativePickupPendingStatusResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message {get;set;}
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(PickupPendingStatusResponse?.Response?.ResponseStatus?.Code);
            }
        }
        public PickupPendingStatusResponse PickupPendingStatusResponse { get; set; }
    }
}
