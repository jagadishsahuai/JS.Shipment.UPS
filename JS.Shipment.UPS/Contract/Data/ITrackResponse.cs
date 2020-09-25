using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITrackResponse
    {
        ResponseType Response { get; set; }
        ShipmentType[] Shipment { get; set; }
        string[] Disclaimer { get; set; }
    }
}