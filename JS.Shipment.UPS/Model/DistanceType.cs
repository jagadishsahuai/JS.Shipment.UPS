using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DistanceType: IDistanceType
    {
        public string Value { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}