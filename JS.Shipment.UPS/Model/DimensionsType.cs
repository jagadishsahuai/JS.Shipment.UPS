using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DimensionsType: IDimensionsType
	{
		public ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string Length { get; set; }
		public string Width { get; set; }
		public string Height { get; set; }
	}
}
