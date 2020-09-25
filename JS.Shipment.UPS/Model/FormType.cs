using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FormType: IFormType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public FormImageType Image { get; set; }
        public string FormGroupId { get; set; }
        public string FormGroupIdName { get; set; }
    }
}