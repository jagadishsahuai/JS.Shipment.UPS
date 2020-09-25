using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IHandlingUnitsDimensionsType
	{
		ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
		string Length { get; set; }
		string Width { get; set; }
		string Height { get; set; }
	}
}
