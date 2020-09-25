using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageWeightType
	{
		ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
		string Weight { get; set; }
	}
}
