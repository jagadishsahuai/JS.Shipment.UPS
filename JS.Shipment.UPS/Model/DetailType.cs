using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DetailType: IDetailType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ElementLevelInformationType ElementLevelInformation { get; set; }
    }
}