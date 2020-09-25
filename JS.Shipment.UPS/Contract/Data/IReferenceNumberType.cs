namespace JS.Shipment.UPS.Contract.Data
{
    public interface IReferenceNumberType
	{
		string BarCodeIndicator { get; set; }
		string Code { get; set; }
		string Value { get; set; }
	}
}
