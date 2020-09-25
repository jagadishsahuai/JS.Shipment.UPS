namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentReferenceNumberType
    {
        string Code { get; set; }
        string Description { get; set; }
        string Value { get; set; }
    }
}
