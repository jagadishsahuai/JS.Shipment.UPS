namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITrackingDataWithReferenceNumberType
    {
        string TrackingNumber { get; set; }
        string[] ReferenceNumber { get; set; }
    }
}
