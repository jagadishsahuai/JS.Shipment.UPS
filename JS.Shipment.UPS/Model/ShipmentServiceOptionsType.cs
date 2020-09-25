using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentServiceOptionsType: IShipmentServiceOptionsType
	{
		public string SaturdayDeliveryIndicator { get; set; }
		public string SaturdayPickupIndicator { get; set; }
		public CODType COD { get; set; }
		public ShipmentServiceOptionsAccessPointCODType AccessPointCOD { get; set; }
		public string DeliverToAddresseeOnlyIndicator { get; set; }
		public string DirectDeliveryOnlyIndicator { get; set; }
		public NotificationType[] Notification { get; set; }
		public LabelDeliveryType LabelDelivery { get; set; }
		public InternationalFormType InternationalForms { get; set; }
		public DeliveryConfirmationType DeliveryConfirmation { get; set; }
		public string ReturnOfDocumentIndicator { get; set; }
		public string ImportControlIndicator { get; set; }
		public LabelMethodType LabelMethod { get; set; }
		public string CommercialInvoiceRemovalIndicator { get; set; }
		public string UPScarbonneutralIndicator { get; set; }
		public PreAlertNotificationType[] PreAlertNotification { get; set; }
		public string ExchangeForwardIndicator { get; set; }
		public string HoldForPickupIndicator { get; set; }
		public string DropoffAtUPSFacilityIndicator { get; set; }
		public string LiftGateForPickUpIndicator { get; set; }
		public string LiftGateForDeliveryIndicator { get; set; }
		public string SDLShipmentIndicator { get; set; }
		public string EPRAReleaseCode { get; set; }
		public RestrictedArticlesType RestrictedArticles { get; set; }
		public string InsideDelivery { get; set; }
		public string ItemDisposal { get; set; }
	}
}
