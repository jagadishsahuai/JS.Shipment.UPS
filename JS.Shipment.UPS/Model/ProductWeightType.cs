using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ProductWeightType : IProductWeightType
	{
		public UnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string Weight { get; set; }
	}
}
