namespace JS.Shipment.UPS.Configuration
{
    public class MessageConfiguration
    {
        public string SuccessfulShipmentCreation { get; set; }
        public string FailedShipmentCreation { get; set; }
        public string SuccessfulShipConfirmCreation { get; set; }
        public string FailedShipConfirmCreation { get; set; }
        public string SuccessfulShipAcceptCreation { get; set; }
        public string FailedShipAcceptCreation { get; set; }
        public string SuccessfulShipmentTracking { get; set; }
        public string FailedShipmentTracking { get; set; }
        public string SuccessfulShipmentDeletion { get; set; }
        public string FailedShipmentDeletion { get; set; }
        public string SuccessfulPackageDeletion { get; set; }
        public string AlreadyDeletedPackage { get; set; }
        public string FailedPackageDeletion { get; set; }
        public string SuccessfulPickupCreation { get; set; }
        public string FailedPickupCreation { get; set; }
        public string SuccessfulPickupCancelation { get; set; }
        public string FailedPickupCancelation { get; set; }
        public string SuccessfulGetServiceCenterFacilities { get; set; }
        public string FailedGetServiceCenterFacilities { get; set; }
        public string SuccessfulPickupPendingStatusFetched { get; set; }
        public string FailedPickupPendingStatusFetched { get; set; }
        public string SuccessfulPickupRateFetched { get; set; }
        public string FailedPickupRateFetched { get; set; }
        public string SuccessfulPickupGetPoliticalDivision1ListFetched { get; set; }
        public string FailedPickupGetPoliticalDivision1ListFetched { get; set; }
        public string SuccessfulLabelRecovery { get; set; }
        public string FailedLabelRecovery { get; set; }
    }
}
