using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentActivityType: IShipmentActivityType
    {
        public AddressType ActivityLocation { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Trailer { get; set; }
    }
}