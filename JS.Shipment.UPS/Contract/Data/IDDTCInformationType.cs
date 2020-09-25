using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDDTCInformationType
	{
		string ITARExemptionNumber { get; set; }
		string USMLCategoryCode { get; set; }
		string EligiblePartyIndicator { get; set; }
		string RegistrationNumber { get; set; }
		string Quantity { get; set; }
		UnitOfMeasurementType UnitOfMeasurement { get; set; }
		string SignificantMilitaryEquipmentIndicator { get; set; }
		string ACMNumber { get; set; }
	}
}
