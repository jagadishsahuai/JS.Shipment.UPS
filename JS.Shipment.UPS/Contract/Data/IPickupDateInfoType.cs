namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupDateInfoType
    {
        string CloseTime { get; set; }
        string ReadyTime { get; set; }
        string PickupDate { get; set; }
    }
}
