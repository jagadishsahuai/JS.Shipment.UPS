using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentChargeType
	{
		string Type { get; set; }
		BillShipperType BillShipper { get; set; }
		BillReceiverType BillReceiver { get; set; }
		BillThirdPartyChargeType BillThirdParty { get; set; }
		string ConsigneeBilledIndicator { get; set; }
	}
}
