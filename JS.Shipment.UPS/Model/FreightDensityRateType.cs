using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FreightDensityRateType: IFreightDensityRateType
    {
        public string Density { get; set; }
        public string TotalCubicFeet { get; set; }
    }
}