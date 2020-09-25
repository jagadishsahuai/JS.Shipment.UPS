using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class HazMatType: IHazMatType
	{
		public string PackagingTypeQuantity { get; set; }
		public string RecordIdentifier1 { get; set; }
		public string RecordIdentifier2 { get; set; }
		public string RecordIdentifier3 { get; set; }
		public string SubRiskClass { get; set; }
		public string ADRItemNumber { get; set; }
		public string ADRPackingGroupLetter { get; set; }
		public string TechnicalName { get; set; }
		public string HazardLabelRequired { get; set; }
		public string ClassDivisionNumber { get; set; }
		public string ReferenceNumber { get; set; }
		public string Quantity { get; set; }
		public string UOM { get; set; }
		public string PackagingType { get; set; }
		public string IDNumber { get; set; }
		public string ProperShippingName { get; set; }
		public string AdditionalDescription { get; set; }
		public string PackagingGroupType { get; set; }
		public string PackagingInstructionCode { get; set; }
		public string EmergencyPhone { get; set; }
		public string EmergencyContact { get; set; }
		public string ReportableQuantity { get; set; }
		public string RegulationSet { get; set; }
		public string TransportationMode { get; set; }
		public string CommodityRegulatedLevelCode { get; set; }
		public string TransportCategory { get; set; }
		public string TunnelRestrictionCode { get; set; }
		public string ChemicalRecordIdentifier { get; set; }
		public string LocalTechnicalName { get; set; }
		public string LocalProperShippingName { get; set; }
	}
}
