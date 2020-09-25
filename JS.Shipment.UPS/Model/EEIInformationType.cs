using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class EEIInformationType: IEEIInformationType
	{
		public string ExportInformation { get; set; }
		public EEILicenseType License { get; set; }
		public DDTCInformationType DDTCInformation { get; set; }
	}
}
