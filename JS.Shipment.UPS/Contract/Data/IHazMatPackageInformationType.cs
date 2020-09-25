namespace JS.Shipment.UPS.Contract.Data
{
    public interface IHazMatPackageInformationType
	{
		string AllPackedInOneIndicator { get; set; }
		string OverPackedIndicator { get; set; }
		string QValue { get; set; }
		string OuterPackagingType { get; set; }
	}
}
