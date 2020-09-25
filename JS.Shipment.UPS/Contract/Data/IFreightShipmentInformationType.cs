using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFreightShipmentInformationType
	{
		FreightDensityInfoType FreightDensityInfo { get; set; }
		string DensityEligibleIndicator { get; set; }
	}
}
