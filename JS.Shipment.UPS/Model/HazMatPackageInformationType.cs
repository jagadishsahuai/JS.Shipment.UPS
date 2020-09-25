using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class HazMatPackageInformationType: IHazMatPackageInformationType
	{
		public string AllPackedInOneIndicator { get; set; }
		public string OverPackedIndicator { get; set; }
		public string QValue { get; set; }
		public string OuterPackagingType { get; set; }
	}
}
