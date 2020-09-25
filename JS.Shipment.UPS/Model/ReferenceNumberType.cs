using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ReferenceNumberType : IReferenceNumberType
	{
		public string BarCodeIndicator { get; set; }
		public string Code { get; set; }
		public string Value { get; set; }
	}
}
