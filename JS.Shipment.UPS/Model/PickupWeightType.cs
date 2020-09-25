using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupWeightType: IPickupWeightType
    {
        public string Weight { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}
