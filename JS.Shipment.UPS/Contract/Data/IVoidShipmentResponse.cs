using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IVoidShipmentResponse
    {
        ResponseType Response { get; set; }
        VoidShipmentResponseSummaryResult SummaryResult { get; set; }
        PackageLevelResult[] PackageLevelResult { get; set; }
    }
}
