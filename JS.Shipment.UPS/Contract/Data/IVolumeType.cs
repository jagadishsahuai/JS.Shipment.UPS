using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IVolumeType
    {
        UnitOfMeasurementType UnitOfMeasurement { get; set; }
        string Value { get; set; }
    }
}
