using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class NextScheduleActivityType: INextScheduleActivityType
    {
        public string Date { get; set; }
        public string Time { get; set; }
    }
}