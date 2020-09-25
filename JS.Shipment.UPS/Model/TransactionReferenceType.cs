using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TransactionReferenceType : ITransactionReferenceType
	{
		public string CustomerContext { get; set ; }
		public string TransactionIdentifier { get; set; }
	}
}
