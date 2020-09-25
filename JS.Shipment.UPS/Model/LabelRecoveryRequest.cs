using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelRecoveryRequest: ILabelRecoveryRequest
    {
        public RequestType Request { get; set; }
        public LabelSpecificationType LabelSpecification { get; set; }
        public TranslateType Translate { get; set; }
        public LabelDeliveryType LabelDelivery { get; set; }
        public string TrackingNumber { get; set; }
        public string MailInnovationsTrackingNumber { get; set; }
        public ReferenceValuesType ReferenceValues { get; set; }
        public LRUPSPremiumCareFormType UPSPremiumCareForm { get; set; }
    }
}
