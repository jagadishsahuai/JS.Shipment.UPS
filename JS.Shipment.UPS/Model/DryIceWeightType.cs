using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DryIceWeightType: IDryIceWeightType
	{
		public ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string Weight { get; set; }
	}
}
