using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupGetPoliticalDivision1ListResponse: IPickupGetPoliticalDivision1ListResponse
    {
        public ResponseType Response { get; set; }
        /// <summary>
        /// The Political Division 1/State Field.
        /// Length: 1..50
        /// Required: No
        /// </summary>
        public string[] PoliticalDivision1 { get; set; }
    }
}