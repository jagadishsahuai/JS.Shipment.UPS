using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDeliveryDetailType
    {
        CommonCodeDescriptionType Type { get; set; }
        string Date { get; set; }
        string Time { get; set; }
    }
}
