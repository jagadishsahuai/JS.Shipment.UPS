namespace JS.Shipment.UPS.Contract.Data
{
    public interface IResponse
    {
        [AutoMapper.IgnoreMap]
        string Message { get; set; }
    }
}
