using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IProductType
	{
		string[] Description { get; set; }
		UnitType Unit { get; set; }
		string CommodityCode { get; set; }
		string PartNumber { get; set; }
		string OriginCountryCode { get; set; }
		string JointProductionIndicator { get; set; }
		string NetCostCode { get; set; }
		NetCostDateType NetCostDateRange { get; set; }
		string PreferenceCriteria { get; set; }
		string ProducerInfo { get; set; }
		string MarksAndNumbers { get; set; }
		string NumberOfPackagesPerCommodity { get; set; }
		ProductWeightType ProductWeight { get; set; }
		string VehicleID { get; set; }
		ScheduleBType ScheduleB { get; set; }
		string ExportType { get; set; }
		string SEDTotalValue { get; set; }
		string[] ExcludeFromForm { get; set; }
		string ProductCurrencyCode { get; set; }
		PackageAssociatedType[] PackingListInfo { get; set; }
		EEIInformationType EEIInformation { get; set; }
	}
}
