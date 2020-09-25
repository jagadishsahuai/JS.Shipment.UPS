using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class BillThirdPartyChargeType : IBillThirdPartyChargeType
	{
		public string AccountNumber { get; set; }
		public AccountAddressType Address { get; set; }
	}
}
