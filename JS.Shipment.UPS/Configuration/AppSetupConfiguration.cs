using System;

namespace JS.Shipment.UPS.Configuration
{
    public class AppSetupConfiguration
    {
        public bool EnableCreateShipment { get; set; }
        public bool EnableDeleteShipment { get; set; }
        public bool EnablePickupShipment { get; set; }
        public bool EnableTrackShipment { get; set; }
        public bool WriteXmlRequest { get; set; }
        public bool WriteXmlResponse { get; set; }
        public string XmlFileDirectory { get; set; }
        public bool SaveLabelFileAfterAcceptSuccess { get; set; }
        public bool SaveLabelFileAfterCreateSuccess { get; set; }
        public bool SaveLabelFileAfterLabelRecoverySuccess { get; set; }
        public bool IsTestEnvironment { get; set; }
        public bool IsProductionEnvironment { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public UrlConfiguration Urls { get; set; }
        public uint TimeOutInSeconds { get; set; }
        public TimeSpan TimeOut { get { return new TimeSpan(TimeOutInSeconds * 10000000); } }
    }
}
