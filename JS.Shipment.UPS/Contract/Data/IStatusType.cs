namespace JS.Shipment.UPS.Contract.Data
{
    public interface IStatusType
    {
        string Type { get; set; }
        string Description { get; set; }
        string Code { get; set; }
    }
}
