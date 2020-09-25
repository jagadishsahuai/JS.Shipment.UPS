using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelRecoveryResponse: ILabelRecoveryResponse
    {
        public ResponseType Response { get; set; }
        public string ShipmentIdentificationNumber { get; set; }
        public IResponseImageType CODTurnInPage { get; set; }
        public FormType Form { get; set; }
        public HighValueReportType HighValueReport { get; set; }
        public object[] Items { get; set; }
    }
}