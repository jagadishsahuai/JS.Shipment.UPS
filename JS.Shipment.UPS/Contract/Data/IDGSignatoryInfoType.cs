namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDGSignatoryInfoType
	{
		string Name { get; set; }
		string Title { get; set; }
		string place { get; set; }
		string Date { get; set; }
		string ShipperDeclaration { get; set; }
		string UploadOnlyIndicator { get; set; }
	}
}
