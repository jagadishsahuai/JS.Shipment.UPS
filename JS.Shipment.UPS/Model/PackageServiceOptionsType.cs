using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageServiceOptionsType: IPackageServiceOptionsType
	{
		public DeliveryConfirmationType DeliveryConfirmation { get; set; }
		public PackageDeclaredValueType DeclaredValue { get; set; }
		public PSOCODType COD { get; set; }
		public PackageServiceOptionsAccessPointCODType AccessPointCOD { get; set; }
		public VerbalConfirmationType VerbalConfirmation { get; set; }
		public string ShipperReleaseIndicator { get; set; }
		public PSONotificationType Notification { get; set; }
		public HazMatType[] HazMat { get; set; }
		public DryIceType DryIce { get; set; }
		public string UPSPremiumCareIndicator { get; set; }
		public string ProactiveIndicator { get; set; }
		public string PackageIdentifier { get; set; }
		public string ClinicalTrialsID { get; set; }
		public string RefrigerationIndicator { get; set; }
	}
}
