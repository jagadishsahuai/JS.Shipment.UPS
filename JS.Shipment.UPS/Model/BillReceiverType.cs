using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class BillReceiverType : IBillReceiverType
	{
		public string AccountNumber { get; set; }
		public BillReceiverAddressType Address { get; set; }
	}
}
