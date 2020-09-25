using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IBillReceiverType
	{
		string AccountNumber { get; set; }
        BillReceiverAddressType Address { get; set; }
    }
}
