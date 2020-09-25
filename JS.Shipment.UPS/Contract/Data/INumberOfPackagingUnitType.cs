using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INumberOfPackagingUnitType
    {
        CommonCodeDescriptionType Type { get; set; }
        string Value { get; set; }
    }
}
