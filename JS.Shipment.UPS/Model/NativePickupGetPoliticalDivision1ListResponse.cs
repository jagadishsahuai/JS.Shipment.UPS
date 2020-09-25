using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativePickupGetPoliticalDivision1ListResponse: INativePickupGetPoliticalDivision1ListResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(PickupGetPoliticalDivision1ListResponse?.Response?.ResponseStatus?.Code);
            }
        }
        public PickupGetPoliticalDivision1ListResponse PickupGetPoliticalDivision1ListResponse { get; set; }
    }
}
