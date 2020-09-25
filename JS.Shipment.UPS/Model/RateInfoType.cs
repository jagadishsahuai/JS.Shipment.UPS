using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class RateInfoType : IRateInfoType
	{
		public string NegotiatedRatesIndicator { get; set; }
		public string FRSShipmentIndicator { get; set; }
		public string RateChartIndicator { get; set; }
		public string UserLevelDiscountIndicator { get; set; }
	}
}
