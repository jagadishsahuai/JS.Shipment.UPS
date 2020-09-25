using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageAddressType
    {
        CommonCodeDescriptionType Type { get; set; }
        AddressType Address { get; set; }
    }
}
