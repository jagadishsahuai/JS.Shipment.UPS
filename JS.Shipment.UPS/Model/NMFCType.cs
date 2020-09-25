using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class NMFCType: INMFCType
	{
		public string PrimeCode { get; set; }
		public string SubCode { get; set; }
	}
}
