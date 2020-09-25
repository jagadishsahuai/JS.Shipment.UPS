using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IResponseType
    {
        CodeDescriptionType ResponseStatus { get; set; }
        CodeDescriptionType[] Alert { get; set; }
        DetailType[] AlertDetail { get; set; }
        TransactionReferenceType TransactionReference { get; set; }
    }
}