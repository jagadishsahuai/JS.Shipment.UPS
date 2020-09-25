using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupPendingStatusResponse: IPickupPendingStatusResponse
    {
        public ResponseType Response { get; set; }
        /// <summary>
        /// The result of retrieving pending pickups.
        /// Required: Yes
        /// </summary>
        public PendingStatusType[] PendingStatus { get; set; }
    }
}