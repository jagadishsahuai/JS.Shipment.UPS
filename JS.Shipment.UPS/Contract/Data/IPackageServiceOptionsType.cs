using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageServiceOptionsType
	{
		DeliveryConfirmationType DeliveryConfirmation { get; set; }
		PackageDeclaredValueType DeclaredValue { get; set; }
		PSOCODType COD { get; set; }
		PackageServiceOptionsAccessPointCODType AccessPointCOD { get; set; }
		VerbalConfirmationType VerbalConfirmation { get; set; }
		string ShipperReleaseIndicator { get; set; }
		PSONotificationType Notification { get; set; }
		HazMatType[] HazMat { get; set; }
		DryIceType DryIce { get; set; }
		string UPSPremiumCareIndicator { get; set; }
		string ProactiveIndicator { get; set; }
		string PackageIdentifier { get; set; }
		string ClinicalTrialsID { get; set; }
		string RefrigerationIndicator { get; set; }
	}
}
