using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipConfirmRequest: IShipRequest
    {
        //RequestType Request { get; set; }
        //ShipmentType Shipment { get; set; }
        //LabelSpecificationType LabelSpecification { get; set; }
        ReceiptSpecificationType ReceiptSpecification { get; set; }
    }
}
