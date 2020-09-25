using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelResultsType
    {
        string TrackingNumber { get; set; }
        LabelImageType LabelImage { get; set; }
        ReceiptType Receipt { get; set; }
        FormType Form { get; set; }
        string MailInnovationsTrackingNumber { get; set; }
        LabelImageType MailInnovationsLabelImage { get; set; }
    }
}
