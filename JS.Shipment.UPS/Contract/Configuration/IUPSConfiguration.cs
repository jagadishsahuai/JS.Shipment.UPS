using JS.Shipment.UPS.Configuration;

namespace JS.Shipment.UPS.Contract.Configuration
{
    public interface IUPSConfiguration
    {
        Authentication Authentication { get; set; }
        TrackConfiguration TrackConfiguration { get; set; }
        ShipperConfiguration ShipperConfiguration { get; set; }
        PaymentInfoConfiguration PaymentInfoConfiguration { get; set; }
        LabelConfiguration LabelConfiguration { get; set; }
        MessageConfiguration MessageConfiguration { get; set; }
        ShipmentConfiguration ShipmentConfiguration { get; set; }
        AppSetupConfiguration AppSetupConfiguration { get; set; }
        PickupConfiguration PickupConfiguration { get; set; }
    }
}
