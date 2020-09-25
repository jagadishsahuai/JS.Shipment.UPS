using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ElementLevelInformationType: IElementLevelInformationType
    {
        public string Level { get; set; }
        public ElementIdentifierType[] ElementIdentifier { get; set; }
    }    
}