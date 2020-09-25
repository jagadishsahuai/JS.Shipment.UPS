namespace JS.Shipment.UPS.Contract.Data
{
    public interface IVoidShipmentRequestVoidShipment
    {
        string ShipmentIdentificationNumber { get; set; }
        string[] TrackingNumber { get; set; }
    }
}
