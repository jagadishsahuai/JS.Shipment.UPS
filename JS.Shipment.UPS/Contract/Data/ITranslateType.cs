namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITranslateType
    {
        string LanguageCode { get; set; }
        string DialectCode { get; set; }
        string Code { get; set; }
    }
}
