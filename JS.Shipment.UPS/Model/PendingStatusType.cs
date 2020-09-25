using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PendingStatusType: IPendingStatusType
    {
        /// <summary>
        /// Specify the type of pending pickup.
        /// 01 = On Call Pickup
        /// Length: 2
        /// Required: Yes
        /// </summary>
        public string PickupType { get; set; }
        /// <summary>
        /// Local service date Format: yyyyMMdd yyyy = Year applicable MM = 01– 12 dd = 01– 31
        /// Length: 8
        /// Required: Yes
        /// </summary>
        public string ServiceDate { get; set; }
        /// <summary>
        /// Returned PRN
        /// Length: 11
        /// Required: Yes
        /// </summary>
        public string PRN { get; set; }
        /// <summary>
        /// Status code for Smart Pickup.
        /// Length: 2
        /// Required: Cond
        /// </summary>
        public string GWNStatusCode { get; set; }
        /// <summary>
        /// A unique string identifier to identify a success pre-notification processing. Only available if end result is success.
        /// Length: 3
        /// Required: Cond
        /// </summary>
        public string OnCallStatusCode { get; set; }
        /// <summary>
        /// The status for on-call pickup. PickupPendingStatusResponse will only display incomplete status for today and tomorrow only. 
        /// 002 and 012 are the most common responses. 
        /// 001 = Received at dispatch 
        /// 002 = Dispatched to driver 
        /// 003 = Order successfully completed 
        /// 004 = Order unsuccessfully completed 
        /// 005 = Missed commit – Updated ETA supplied by driver 
        /// 008 = Order has invalid order status 
        /// 012 = Your pickup request is being processed
        /// PickupPendingStatusResponse/PendingStatus/PickupStatusMessage
        /// Length: 1..500
        /// Required: Yes
        /// </summary>
        public string PickupStatusMessage { get; set; }
        /// <summary>
        /// Pickup billing classification for on-call 
        /// 01 = Regular 
        /// 02 = Return
        /// Length: 2
        /// Required: Cond
        /// </summary>
        public string BillingCode { get; set; }
        /// <summary>
        /// On call pickup contact name
        /// Length: 1..22
        /// Required: No
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// Customer provided reference number for on-call pickup
        /// Length: 1..35
        /// Required: Cond
        /// </summary>
        public string ReferenceNumber { get; set; }
    }
}