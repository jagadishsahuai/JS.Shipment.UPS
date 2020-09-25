namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDayOfWeekType
    {
        string Day { get; set; }
        string EarliestDropOfforPickup { get; set; }
        string LatestDropOfforPickup { get; set; }
        string OpenHours { get; set; }
        string CloseHours { get; set; }
        string PrepTime { get; set; }
        string LastDrop { get; set; }
    }
}
