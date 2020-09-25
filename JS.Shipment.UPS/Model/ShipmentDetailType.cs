using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentDetailType: IShipmentDetailType
    {
        public string HazmatIndicator { get; set; }
        public PalletInformationType PalletInformation { get; set; }
    }
}