using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IAppointmentType
    {
        DateTimeType Made { get; set; }
        DateTimeType Requested { get; set; }
        string BeginTime { get; set; }
        string EndTime { get; set; }
    }
}
