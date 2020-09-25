using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupCancelResponse
    {
        ResponseType Response { get; set; }
        string PickupType { get; set; }
        StatusCodeDescriptionType GWNStatus { get; set; }
    }
}
