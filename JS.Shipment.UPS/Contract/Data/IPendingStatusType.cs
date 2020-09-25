namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPendingStatusType
    {
        string PickupType { get; set; }
        string ServiceDate { get; set; }
        string PRN { get; set; }
        string GWNStatusCode { get; set; }
        string OnCallStatusCode { get; set; }
        string PickupStatusMessage { get; set; }
        string BillingCode { get; set; }
        string ContactName { get; set; }
        string ReferenceNumber { get; set; }
    }
}
