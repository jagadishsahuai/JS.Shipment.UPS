using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IHandlingUnitsType
	{
		string Quantity { get; set; }
		ShipUnitOfMeasurementType Type { get; set; }
		HandlingUnitsDimensionsType Dimensions { get; set; }
	}
}
