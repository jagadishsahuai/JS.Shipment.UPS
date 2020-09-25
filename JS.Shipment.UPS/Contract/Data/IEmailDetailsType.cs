namespace JS.Shipment.UPS.Contract.Data
{
    public interface IEmailDetailsType
	{
		string[] EMailAddress { get; set; }
		string UndeliverableEMailAddress { get; set; }
		string FromEMailAddress { get; set; }
		string FromName { get; set; }
		string Memo { get; set; }
		string Subject { get; set; }
		string SubjectCode { get; set; }
	}
}
