using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ProductType: IProductType
	{
		public string[] Description { get; set; }
		public UnitType Unit { get; set; }
		public string CommodityCode { get; set; }
		public string PartNumber { get; set; }
		public string OriginCountryCode { get; set; }
		public string JointProductionIndicator { get; set; }
		public string NetCostCode { get; set; }
		public NetCostDateType NetCostDateRange { get; set; }
		public string PreferenceCriteria { get; set; }
		public string ProducerInfo { get; set; }
		public string MarksAndNumbers { get; set; }
		public string NumberOfPackagesPerCommodity { get; set; }
		public ProductWeightType ProductWeight { get; set; }
		public string VehicleID { get; set; }
		public ScheduleBType ScheduleB { get; set; }
		public string ExportType { get; set; }
		public string SEDTotalValue { get; set; }
		public string[] ExcludeFromForm { get; set; }
		public string ProductCurrencyCode { get; set; }
		public PackageAssociatedType[] PackingListInfo { get; set; }
		public EEIInformationType EEIInformation { get; set; }
	}
}
