using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageWeightType: IPackageWeightType
	{
		public ShipUnitOfMeasurementType UnitOfMeasurement { get; set; }
		public string Weight { get; set; }
	}
}
