using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupDateInfoType: IPickupDateInfoType
    {
        public string CloseTime { get; set; }
        public string ReadyTime { get; set; }
        public string PickupDate { get; set; }
    }
}