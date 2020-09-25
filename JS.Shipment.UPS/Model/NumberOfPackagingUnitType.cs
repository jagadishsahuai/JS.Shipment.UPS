using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class NumberOfPackagingUnitType: INumberOfPackagingUnitType
    {
        public CommonCodeDescriptionType Type { get; set; }
        public string Value { get; set; }
    }
}