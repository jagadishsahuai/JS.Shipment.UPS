using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IVoidShipmentResponseSummaryResult
    {
        CodeDescriptionType Status { get; set; }
    }
}
