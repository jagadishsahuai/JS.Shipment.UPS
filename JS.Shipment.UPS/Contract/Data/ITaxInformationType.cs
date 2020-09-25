namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITaxInformationType
    {
        string VatTaxID { get; set; }
        string TaxIDType { get; set; }
        string CertifiedElectronicMail { get; set; }
        string InterchangeSystemCode { get; set; }
    }
}
