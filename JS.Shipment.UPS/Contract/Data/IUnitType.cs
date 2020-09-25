using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IUnitType
	{
		string Number { get; set; }
		UnitOfMeasurementType UnitOfMeasurement { get; set; }
		string Value { get; set; }
	}
}
