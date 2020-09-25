using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFreightDensityInfoType
	{
		string AdjustedHeightIndicator { get; set; }
		AdjustedHeightType AdjustedHeight { get; set; }
		HandlingUnitsType[] HandlingUnits { get; set; }
	}
}
