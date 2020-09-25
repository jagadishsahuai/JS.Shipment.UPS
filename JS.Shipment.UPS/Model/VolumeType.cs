using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class VolumeType: IVolumeType
    {
        public UnitOfMeasurementType UnitOfMeasurement { get; set; }
        public string Value { get; set; }
    }
}