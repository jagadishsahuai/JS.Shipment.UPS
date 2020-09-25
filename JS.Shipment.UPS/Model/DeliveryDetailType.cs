using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DeliveryDetailType: IDeliveryDetailType
    {
        public CommonCodeDescriptionType Type { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}