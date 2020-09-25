using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipRequest
    {
        RequestType Request { get; set; }
        ShipmentType Shipment { get; set; }
        LabelSpecificationType LabelSpecification { get; set; }
    }
}
