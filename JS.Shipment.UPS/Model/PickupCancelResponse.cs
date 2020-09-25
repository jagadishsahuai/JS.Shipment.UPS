using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupCancelResponse: IPickupCancelResponse
    {
        public ResponseType Response { get; set; }
        /// <summary>
        /// The type of pickup that has been cancelled. 01 = On Call Pickup
        /// Length: 2
        /// Required: Yes
        /// </summary>
        public string PickupType { get; set; }
        /// <summary>
        /// The status of Smart Pickup that has been cancelled.
        /// Required: Cond
        /// </summary>
        public StatusCodeDescriptionType GWNStatus { get; set; }
    }
}