using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IBillingWeightType
    {
        BillingUnitOfMeasurementType UnitOfMeasurement { get; set; }
        string Weight { get; set; }
    }
}
