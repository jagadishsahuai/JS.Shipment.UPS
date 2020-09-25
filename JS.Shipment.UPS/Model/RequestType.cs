using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class RequestType : IRequestType
	{
		public string[] RequestOption { get; set; }
		public string SubVersion { get; set; }
		public TransactionReferenceType TransactionReference { get; set; }
	}
}
