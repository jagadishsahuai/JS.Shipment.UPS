using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class EmailDetailsType: IEmailDetailsType
	{
		public string[] EMailAddress { get; set; }
		public string UndeliverableEMailAddress { get; set; }
		public string FromEMailAddress { get; set; }
		public string FromName { get; set; }
		public string Memo { get; set; }
		public string Subject { get; set; }
		public string SubjectCode { get; set; }
	}
}
