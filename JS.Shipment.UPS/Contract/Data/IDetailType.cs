using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDetailType
    {
        string Code { get; set; }
        string Description { get; set; }
        ElementLevelInformationType ElementLevelInformation { get; set; }
    }
}
