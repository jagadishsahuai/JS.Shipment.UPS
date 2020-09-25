using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class VoidShipmentResponse: IVoidShipmentResponse
    {
        public ResponseType Response { get; set; }
        public VoidShipmentResponseSummaryResult SummaryResult { get; set; }
        public PackageLevelResult[] PackageLevelResult { get; set; }
    }
}