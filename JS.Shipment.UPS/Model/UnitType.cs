using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class UnitType: IUnitType
	{
		public string Number { get; set; }
		public UnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string Value { get; set; }
	}
}
