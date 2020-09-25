using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupCancelRequest
    {
        RequestType Request { get; set; }
        string CancelBy { get; set; }
        string PRN { get; set; }
    }
}
