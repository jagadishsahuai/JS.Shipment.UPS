using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FreightDensityInfoType : IFreightDensityInfoType
	{
		public string AdjustedHeightIndicator { get; set; }
		public AdjustedHeightType AdjustedHeight { get; set; }
		public HandlingUnitsType[] HandlingUnits { get; set; }
	}
}
