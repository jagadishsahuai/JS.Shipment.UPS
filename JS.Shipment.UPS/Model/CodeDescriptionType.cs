using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CodeDescriptionType: ICodeDescriptionType
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}