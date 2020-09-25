namespace JS.Shipment.UPS.Model
{
    public class TrackResponse
    {
        public ResponseType Response { get; set; }
        public TrackShipmentType[] Shipment { get; set; }
        public string[] Disclaimer { get; set; }
    }
}