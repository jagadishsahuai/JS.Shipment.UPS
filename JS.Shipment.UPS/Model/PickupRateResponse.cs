using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupRateResponse: IPickupRateResponse
    {
        public ResponseType Response { get; set; }
        /// <summary>
        /// The result of rating an on-call pickup.
        /// Required: Yes
        /// </summary>
        public RateResultType RateResult { get; set; }
        /// <summary>
        /// Indicates if the pickup address qualifies for WST (Weekend Service Territory).
        /// Returned if the pickup date is Saturday and subversion greater or equal to 1607.
        /// Valid values:
        /// Y = WST
        /// N = Non - WST
        /// Length: 1
        /// Required: Cond 
        /// </summary>
        public string WeekendServiceTerritoryIndicator { get; set; }
    }
}