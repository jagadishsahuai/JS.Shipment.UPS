namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipChargeType
    {
        string Code { get; set; }
        string Description { get; set; }
        string CurrencyCode { get; set; }
        string MonetaryValue { get; set; }
        string SubType { get; set; }
    }
}
