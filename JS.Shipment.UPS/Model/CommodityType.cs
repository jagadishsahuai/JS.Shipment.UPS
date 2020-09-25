using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CommodityType: ICommodityType
	{
		public string FreightClass { get; set; }
		public NMFCType NMFC { get; set; }
	}
}
