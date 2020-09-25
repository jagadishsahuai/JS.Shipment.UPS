using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentAddressType: IShipmentAddressType
    {
        public CommonCodeDescriptionType Type { get; set; }
        public AddressType Address { get; set; }
    }
}
