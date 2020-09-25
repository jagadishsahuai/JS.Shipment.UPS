namespace JS.Shipment.UPS.Contract.Data
{
    public interface IRedirectType
    {
        string CompanyName { get; set; }
        string LocationID { get; set; }
        string PickupDate { get; set; }
    }
}
