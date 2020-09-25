namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILicenseType
	{
		string NumberField { get; set; }
		string CodeField { get; set; }
		string LicenseLineValueField { get; set; }
		string ECCNNumberField { get; set; }
	}
}
