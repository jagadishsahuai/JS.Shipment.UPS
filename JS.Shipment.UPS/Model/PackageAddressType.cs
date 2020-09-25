using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageAddressType: IPackageAddressType
    {
        public CommonCodeDescriptionType Type { get; set; }
        public AddressType Address { get; set; }
    }
}