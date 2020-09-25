using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IAdjustedHeightType
	{
		string Value { get; set; }
		ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
	}
}
