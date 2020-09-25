using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DDTCInformationType: IDDTCInformationType
	{
		public string ITARExemptionNumber { get; set; }
		public string USMLCategoryCode { get; set; }
		public string EligiblePartyIndicator { get; set; }
		public string RegistrationNumber { get; set; }
		public string Quantity { get; set; }
		public UnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string SignificantMilitaryEquipmentIndicator { get; set; }
		public string ACMNumber { get; set; }
	}
}
