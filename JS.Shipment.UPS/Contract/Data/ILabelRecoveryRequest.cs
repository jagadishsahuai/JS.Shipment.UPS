using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelRecoveryRequest
    {
        RequestType Request { get; set; }
        LabelSpecificationType LabelSpecification { get; set; }
        TranslateType Translate { get; set; }
        LabelDeliveryType LabelDelivery { get; set; }
        string TrackingNumber { get; set; }
        string MailInnovationsTrackingNumber { get; set; }
        ReferenceValuesType ReferenceValues { get; set; }
        LRUPSPremiumCareFormType UPSPremiumCareForm { get; set; }
    }
}
