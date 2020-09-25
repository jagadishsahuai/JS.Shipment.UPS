using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageType: IPackageType
	{
		public string Description { get; set; }
		public string PalletDescription { get; set; }
		public string NumOfPieces { get; set; }
		public string UnitPrice { get; set; }
		public PackagingType Packaging { get; set; }
		public DimensionsType Dimensions { get; set; }
		public PackageWeightType DimWeight { get; set; }
		public PackageWeightType PackageWeight { get; set; }
		public string LargePackageIndicator { get; set; }
		public ReferenceNumberType[] ReferenceNumber { get; set; }
		public string AdditionalHandlingIndicator { get; set; }
		public PackageServiceOptionsType PackageServiceOptions { get; set; }
		public CommodityType Commodity { get; set; }
		public HazMatPackageInformationType HazMatPackageInformation { get; set; }
	}
}
