using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class EEILicenseType: IEEILicenseType
	{
		public string Number { get; set; }
		public string Code { get; set; }
		public string LicenseLineValue { get; set; }
		public string ECCNNumber { get; set; }
	}
}
