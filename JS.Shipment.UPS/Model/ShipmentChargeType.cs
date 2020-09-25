using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentChargeType : IShipmentChargeType
	{
		public string Type { get; set; }
		public BillShipperType BillShipper { get; set; }
		public BillReceiverType BillReceiver { get; set; }
		public BillThirdPartyChargeType BillThirdParty { get; set; }
		public string ConsigneeBilledIndicator { get; set; }
	}
}
