using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class HandlingUnitsDimensionsType: IHandlingUnitsDimensionsType
	{
		public ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string Length { get; set; }
		public string Width { get; set; }
		public string Height { get; set; }
	}
}
