using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IElementLevelInformationType
    {
        string Level { get; set; }
        ElementIdentifierType[] ElementIdentifier { get; set; }
    }
}
