namespace JS.Shipment.UPS.Contract.Data
{
    public interface IRateInfoType
	{
		string NegotiatedRatesIndicator { get; set; }
		string FRSShipmentIndicator { get; set; }
		string RateChartIndicator { get; set; }
		string UserLevelDiscountIndicator { get; set; }
	}
}
