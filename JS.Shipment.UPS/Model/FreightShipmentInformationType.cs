using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FreightShipmentInformationType : IFreightShipmentInformationType
	{
		public FreightDensityInfoType FreightDensityInfo { get; set; }
		public string DensityEligibleIndicator { get; set; }
	}
}
