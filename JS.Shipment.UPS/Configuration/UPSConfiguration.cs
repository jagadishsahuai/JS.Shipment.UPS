using JS.Shipment.UPS.Contract.Configuration;

namespace JS.Shipment.UPS.Configuration
{
    public class UPSConfiguration: IUPSConfiguration
    {
		public Authentication Authentication { get; set; }
		public TrackConfiguration TrackConfiguration { get; set; }
		public ShipperConfiguration ShipperConfiguration { get; set; }
		public PaymentInfoConfiguration PaymentInfoConfiguration { get; set; }
		public LabelConfiguration LabelConfiguration { get; set; }
		public MessageConfiguration MessageConfiguration { get; set; }
		public ShipmentConfiguration ShipmentConfiguration { get; set; }
		public AppSetupConfiguration AppSetupConfiguration { get; set; }
        public PickupConfiguration PickupConfiguration { get; set; }
    }
}
