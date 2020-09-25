using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TranslateType: ITranslateType
    {
        public string LanguageCode { get; set; }
        public string DialectCode { get; set; }
        public string Code { get; set; }
    }
}