using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IAlternateDeliveryAddressType
    {
        string Name { get; set; }
        string AttentionName { get; set; }
        string UPSAccessPointID { get; set; }
        ADLAddressType Address { get; set; }
    }
}