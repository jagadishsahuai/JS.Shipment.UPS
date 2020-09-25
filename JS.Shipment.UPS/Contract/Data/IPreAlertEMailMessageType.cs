namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPreAlertEMailMessageType
	{
		string EMailAddressField { get; set; }
		string UndeliverableEMailAddressField { get; set; }
	}
}
