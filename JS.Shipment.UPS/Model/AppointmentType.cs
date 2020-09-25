using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AppointmentType: IAppointmentType
    {
        public DateTimeType Made { get; set; }
        public DateTimeType Requested { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
    }
}