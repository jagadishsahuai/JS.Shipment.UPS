namespace JS.Shipment.UPS.Contract.Data
{
    public interface IAmountType
    {
        string CurrencyCode { get; set; }
        string MonetaryValue { get; set; }
    }
}
