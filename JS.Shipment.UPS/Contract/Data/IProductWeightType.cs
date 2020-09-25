using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IProductWeightType
	{
		UnitOfMeasurementType UnitOfMeasurement { get; set; }
		string Weight { get; set; }
	}
}
