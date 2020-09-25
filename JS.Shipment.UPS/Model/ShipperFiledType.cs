using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipperFiledType : IShipperFiledType
	{
		public string Code { get; set; }
		public string Description { get; set; }
		public string PreDepartureITNNumber { get; set; }
		public string ExemptionLegend { get; set; }
		public string EEIShipmentReferenceNumber { get; set; }
	}
}
