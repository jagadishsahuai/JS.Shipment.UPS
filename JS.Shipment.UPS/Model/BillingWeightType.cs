using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class BillingWeightType: IBillingWeightType
    {
        public BillingUnitOfMeasurementType UnitOfMeasurement { get; set; }
        public string Weight { get; set; }
    }
}