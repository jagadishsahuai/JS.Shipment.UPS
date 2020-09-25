using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICommodityType
	{
		string FreightClass { get; set; }
		NMFCType NMFC { get; set; }
	}
}
