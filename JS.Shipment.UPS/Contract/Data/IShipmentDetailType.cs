using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentDetailType
    {
        string HazmatIndicator { get; set; }
        PalletInformationType PalletInformation { get; set; }
    }
}
