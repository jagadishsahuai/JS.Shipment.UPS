using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class VoidShipmentResponseSummaryResult: IVoidShipmentResponseSummaryResult
    {
        public CodeDescriptionType Status { get; set; }
    }
}