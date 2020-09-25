using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelResultsType: ILabelResultsType
    {
        public string TrackingNumber { get; set; }
        public LabelImageType LabelImage { get; set; }
        public ReceiptType Receipt { get; set; }
        public FormType Form { get; set; }
        public string MailInnovationsTrackingNumber{ get; set; }
        public LabelImageType MailInnovationsLabelImage { get; set; }
    }
}
