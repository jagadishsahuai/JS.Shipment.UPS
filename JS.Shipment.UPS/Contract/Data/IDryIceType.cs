using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDryIceType
	{
		string RegulationSet { get; set; }
		DryIceWeightType DryIceWeight { get; set; }
		string MedicalUseIndicator { get; set; }
	}
}
