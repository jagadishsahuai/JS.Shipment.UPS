using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageType
	{
		string Description { get; set; }
		string PalletDescription { get; set; }
		string NumOfPieces { get; set; }
		string UnitPrice { get; set; }
		PackagingType Packaging { get; set; }
		DimensionsType Dimensions { get; set; }
		PackageWeightType DimWeight { get; set; }
		PackageWeightType PackageWeight { get; set; }
		string LargePackageIndicator { get; set; }
		ReferenceNumberType[] ReferenceNumber { get; set; }
		string AdditionalHandlingIndicator { get; set; }
		PackageServiceOptionsType PackageServiceOptions { get; set; }
		CommodityType Commodity { get; set; }
		HazMatPackageInformationType HazMatPackageInformation { get; set; }
	}
}
