using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Configuration
{
    public class LabelConfiguration
    {
        public string Directory { get; set; }
        public string LabelRecoveryDirectory { get; set; }
        public string FileExtention { get; set; }
        public string FileNamePrefixDefinedInHtmlFile { get; set; }
        public bool SaveLabelFile { get; set; }
        public bool SaveLabelHtmlFile { get; set; }
        public LabelSpecificationType LabelSpecification { get; set; }
    }
}
