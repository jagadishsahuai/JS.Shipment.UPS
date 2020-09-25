using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    /// <summary>
    /// This request is for client to get a list of valid Political Division 1s/State field for a specific country or territory.
    /// </summary>
    public class PickupGetPoliticalDivision1ListRequest: IPickupGetPoliticalDivision1ListRequest
    {
        public RequestType Request { get; set; }
        /// <summary>
        /// Specifies the country or territory for which the list of Political Division 1 will be returned if available.
        /// Length: 2
        /// Required: Yes
        /// </summary>
        public string CountryCode { get; set; }
    }
}
