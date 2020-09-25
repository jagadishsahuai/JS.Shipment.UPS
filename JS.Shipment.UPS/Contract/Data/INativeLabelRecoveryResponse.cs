using JS.Shipment.UPS.Model;
using System.Collections.Generic;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativeLabelRecoveryResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        List<string> LabelFiles {get;set;}
        LabelRecoveryResponse LabelRecoveryResponse { get; set; }
    }
}
