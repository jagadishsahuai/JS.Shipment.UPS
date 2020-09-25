using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AdjustedHeightType : IAdjustedHeightType
	{
		public string Value { get; set; }
		public ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
	}
}
