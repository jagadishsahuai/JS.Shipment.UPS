using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DryIceType: IDryIceType
	{
		public string RegulationSet { get; set; }
		public DryIceWeightType DryIceWeight { get; set; }
		public string MedicalUseIndicator { get; set; }
	}
}
