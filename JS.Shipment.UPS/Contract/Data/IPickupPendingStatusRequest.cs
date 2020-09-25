using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupPendingStatusRequest
    {
        RequestType Request { get; set; }
        string PickupType { get; set; }
        string AccountNumber { get; set; }
    }
}
