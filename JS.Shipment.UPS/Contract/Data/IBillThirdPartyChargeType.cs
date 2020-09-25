using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IBillThirdPartyChargeType
	{
		string AccountNumber { get; set; }
		AccountAddressType Address { get; set; }
	}
}
