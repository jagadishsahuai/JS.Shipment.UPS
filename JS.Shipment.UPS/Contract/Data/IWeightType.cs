using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IWeightType
    {
        UnitOfMeasurementType UnitOfMeasurement { get; set; }
        string Weight { get; set; }
    }
}
