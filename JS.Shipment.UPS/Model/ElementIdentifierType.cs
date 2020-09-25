using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ElementIdentifierType: IElementIdentifierType
    {
        public string Code { get; set; }
        public string Value { get; set; }
    }
}