using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFormType
    {
        string Code { get; set; }
        string Description { get; set; }
        FormImageType Image { get; set; }
        string FormGroupId { get; set; }
        string FormGroupIdName { get; set; }
    }
}
