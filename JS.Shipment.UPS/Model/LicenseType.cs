using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LicenseType: ILicenseType
	{
		public string NumberField { get; set; }
		public string CodeField { get; set; }
		public string LicenseLineValueField { get; set; }
		public string ECCNNumberField { get; set; }
	}
}
