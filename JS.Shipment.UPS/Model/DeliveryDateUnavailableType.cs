using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DeliveryDateUnavailableType: IDeliveryDateUnavailableType
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }
}