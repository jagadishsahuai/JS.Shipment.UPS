using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentActivityType
    {
        AddressType ActivityLocation { get; set; }
        string Description { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        string Trailer { get; set; }
    }
}
