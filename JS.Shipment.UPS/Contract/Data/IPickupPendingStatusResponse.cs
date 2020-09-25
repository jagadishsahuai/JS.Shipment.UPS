using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupPendingStatusResponse
    {
        ResponseType Response { get; set; }
        PendingStatusType[] PendingStatus { get; set; }
    }
}
