namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupPieceServiceType
    {
        string ServiceCode { get; set; }
        string Quantity { get; set; }
        string DestinationCountryCode { get; set; }
        string ContainerCode { get; set; }
    }
}
