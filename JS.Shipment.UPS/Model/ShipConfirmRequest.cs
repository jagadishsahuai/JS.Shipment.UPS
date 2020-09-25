using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipConfirmRequest: IShipConfirmRequest
    {
        public RequestType Request { get; set; }
        public ShipmentType Shipment { get; set; }
        public LabelSpecificationType LabelSpecification { get; set; }
        public ReceiptSpecificationType ReceiptSpecification { get; set; }
    }
}
