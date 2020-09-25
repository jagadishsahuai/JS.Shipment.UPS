using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CodeDescriptionValueType: ICodeDescriptionValueType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}