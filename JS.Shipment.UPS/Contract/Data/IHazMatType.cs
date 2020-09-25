namespace JS.Shipment.UPS.Contract.Data
{
    public interface IHazMatType
	{
		string PackagingTypeQuantity { get; set; }
		string RecordIdentifier1 { get; set; }
		string RecordIdentifier2 { get; set; }
		string RecordIdentifier3 { get; set; }
		string SubRiskClass { get; set; }
		string ADRItemNumber { get; set; }
		string ADRPackingGroupLetter { get; set; }
		string TechnicalName { get; set; }
		string HazardLabelRequired { get; set; }
		string ClassDivisionNumber { get; set; }
		string ReferenceNumber { get; set; }
		string Quantity { get; set; }
		string UOM { get; set; }
		string PackagingType { get; set; }
		string IDNumber { get; set; }
		string ProperShippingName { get; set; }
		string AdditionalDescription { get; set; }
		string PackagingGroupType { get; set; }
		string PackagingInstructionCode { get; set; }
		string EmergencyPhone { get; set; }
		string EmergencyContact { get; set; }
		string ReportableQuantity { get; set; }
		string RegulationSet { get; set; }
		string TransportationMode { get; set; }
		string CommodityRegulatedLevelCode { get; set; }
		string TransportCategory { get; set; }
		string TunnelRestrictionCode { get; set; }
		string ChemicalRecordIdentifier { get; set; }
		string LocalTechnicalName { get; set; }
		string LocalProperShippingName { get; set; }
	}
}
