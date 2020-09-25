using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentServiceOptionsType
	{
		string SaturdayDeliveryIndicator { get; set; }
		string SaturdayPickupIndicator { get; set; }
		CODType COD { get; set; }
		ShipmentServiceOptionsAccessPointCODType AccessPointCOD { get; set; }
		string DeliverToAddresseeOnlyIndicator { get; set; }
		string DirectDeliveryOnlyIndicator { get; set; }
		NotificationType[] Notification { get; set; }
		LabelDeliveryType LabelDelivery { get; set; }
		InternationalFormType InternationalForms { get; set; }
		DeliveryConfirmationType DeliveryConfirmation { get; set; }
		string ReturnOfDocumentIndicator { get; set; }
		string ImportControlIndicator { get; set; }
		LabelMethodType LabelMethod { get; set; }
		string CommercialInvoiceRemovalIndicator { get; set; }
		string UPScarbonneutralIndicator { get; set; }
		PreAlertNotificationType[] PreAlertNotification { get; set; }
		string ExchangeForwardIndicator { get; set; }
		string HoldForPickupIndicator { get; set; }
		string DropoffAtUPSFacilityIndicator { get; set; }
		string LiftGateForPickUpIndicator { get; set; }
		string LiftGateForDeliveryIndicator { get; set; }
		string SDLShipmentIndicator { get; set; }
		string EPRAReleaseCode { get; set; }
		RestrictedArticlesType RestrictedArticles { get; set; }
		string InsideDelivery { get; set; }
		string ItemDisposal { get; set; }
	}
}
