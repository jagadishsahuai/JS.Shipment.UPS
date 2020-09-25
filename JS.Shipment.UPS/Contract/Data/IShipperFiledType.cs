namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipperFiledType
	{
		string Code { get; set; }
		string Description { get; set; }
		string PreDepartureITNNumber { get; set; }
		string ExemptionLegend { get; set; }
		string EEIShipmentReferenceNumber { get; set; }
	}
}
