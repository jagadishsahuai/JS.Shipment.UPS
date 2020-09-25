using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ServiceCenterType: IServiceCenterType
    {
        public CommonCodeDescriptionType Type { get; set; }
        public AddressType Address { get; set; }
    }
}