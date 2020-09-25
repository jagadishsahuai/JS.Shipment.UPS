using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ResponseType: IResponseType
    {
        public CodeDescriptionType ResponseStatus { get; set; }
        public CodeDescriptionType[] Alert { get; set; }
        public DetailType[] AlertDetail { get; set; }
        public TransactionReferenceType TransactionReference { get; set; }
    }
}
