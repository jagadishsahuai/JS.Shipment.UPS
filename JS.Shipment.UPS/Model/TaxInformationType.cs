using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TaxInformationType : ITaxInformationType
    {
        public string VatTaxID { get; set; }
        public string TaxIDType { get; set; }
        public string CertifiedElectronicMail { get; set; }
        public string InterchangeSystemCode { get; set; }
    }
}