using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Collections.Generic;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativeLabelRecoveryResponse : INativeLabelRecoveryResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(LabelRecoveryResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public List<string> LabelFiles { get; set; }
        public LabelRecoveryResponse LabelRecoveryResponse { get; set; }
    }
}
