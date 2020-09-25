using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ChargeDetailType: IChargeDetailType
    {
        public string ChargeCode { get; set; }
        public string ChargeDescription { get; set; }
        public string ChargeAmount { get; set; }
        public string IncentedAmount { get; set; }
        public string TaxAmount { get; set; }
    }
}