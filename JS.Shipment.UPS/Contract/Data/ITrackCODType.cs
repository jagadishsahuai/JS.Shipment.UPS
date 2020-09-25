using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITrackCODType
    {
        AmountType Amount { get; set; }
        CODStatusType Status { get; set; }
        string ControlNumber { get; set; }
    }
}
