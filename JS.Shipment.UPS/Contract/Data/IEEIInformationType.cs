using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IEEIInformationType
	{
		string ExportInformation { get; set; }
		EEILicenseType License { get; set; }
		DDTCInformationType DDTCInformation { get; set; }
	}
}
