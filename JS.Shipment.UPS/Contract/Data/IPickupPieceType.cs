namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupPieceType
    {
        string ServiceCode { get; set; }
        string Quantity { get; set; }
        string DestinationCountryCode { get; set; }
        string ContainerCode { get; set; }
    }
}
