namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITaxChargeType
    {
        string Type { get; set; }
        string MonetaryValue { get; set; }
    }
}
