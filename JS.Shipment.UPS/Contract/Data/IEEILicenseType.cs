namespace JS.Shipment.UPS.Contract.Data
{
    public interface IEEILicenseType
	{
		string Number { get; set; }
		string Code { get; set; }
		string LicenseLineValue { get; set; }
		string ECCNNumber { get; set; }
	}
}
