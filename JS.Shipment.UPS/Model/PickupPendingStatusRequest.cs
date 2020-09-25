using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupPendingStatusRequest: IPickupPendingStatusRequest
    {
        public RequestType Request { get; set; }
        /// <summary>
        /// Specify the type of pending pickup. 
        /// 01 = On-Call Pickup 
        /// 02 = Smart Pickup 
        /// 03 = Both Smart Pickup and On-Call Pickup
        /// Length: 2
        /// Required: Yes
        /// </summary>
        public string PickupType { get; set; }
        /// <summary>
        /// The specific account number belongs to the shipper
        /// Length: 6 or 10
        /// Required: Yes
        /// </summary>
        public string AccountNumber { get; set; }
    }
}
