namespace JS.Shipment.UPS.Contract.Data
{
    interface ITransactionReferenceType
	{
		string CustomerContext { get; set; }
		string TransactionIdentifier { get; set; }
	}
}
