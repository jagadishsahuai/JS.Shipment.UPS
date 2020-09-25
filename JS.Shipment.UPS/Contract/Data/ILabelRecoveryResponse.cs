using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelRecoveryResponse
    {
        ResponseType Response { get; set; }
        string ShipmentIdentificationNumber { get; set; }
        IResponseImageType CODTurnInPage { get; set; }
        FormType Form { get; set; }
        HighValueReportType HighValueReport { get; set; }
        object[] Items { get; set; }
    }
}
