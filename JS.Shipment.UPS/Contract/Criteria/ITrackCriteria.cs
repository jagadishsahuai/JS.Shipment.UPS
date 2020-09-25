using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Criteria
{
    public interface ITrackCriteria
    {
        /// <summary>
        /// Inquiry Number. Package: For package, the number will be treated as 
        /// Shipment Identification Number or Package Tracking Number based on the value of the element TrackingOption. 
        /// Tracking options: 01, the inquiry number will be treated as shipment identification number. 
        /// 02, the inquiry number will be treated as package Tracking number. Freight: For freight, 
        /// the number will be always treated as the tracking number of the shipment regardless of the value of the TrackingOption.
        /// Mail Innovations: For mail innovations this number will be the tracking number. 
        /// When tracking for mail innovations by tracking number the TrackingOption also needs to be set to03. 
        /// For mail innovations different types of tracking numbers apply like - Sequence number (Mail Manifest ID / MMS), Postal service Tracking ID.
        /// </summary>
        string TrackingReferenceNumber { get; set; }
        /// <summary>
        /// TrackingOption applies to Package and Mail Innovations only.
        /// Package: 01 - Single trackable entity with more trackable entities inside it 
        /// 02 - Single trackable entity with no more trackable entities inside it If value or element is not found, 
        /// then Inquiry number will be treated as Shipment Identification Number.
        /// If the TrackingOption is not present then it will return all packages information 
        /// if it is a Multi-package shipment(Which means Tracking number will be treated as Shipment Identification number). 
        /// Freight: Freight: For Freight, This element will be ignored and the Inquiry number will always be treated as Shipment Identification Number.
        /// For Freight Inquiry Number this field will not be used so all the information about that freight shipment will be returned.
        /// Mail Innovations: For Mail Innovations track by number, this is a mandatory field which has to be set to 
        /// 03. For Mail Innovations a single shipment has single package.
        /// </summary>
        string TrackingOption { get; set; }
        /// <summary>
        /// The additional information of pickup date range to support and narrow a reference number search. 
        /// For Mail Innovations this is optional field for tracking by reference number.
        /// </summary>
        PickupDateRangeType PickupDateRange { get; set; }
        RequestType RequestType { get; set; }
        /// <summary>
        /// The customer assigned reference number.
        /// </summary>
        ReferenceNumberType ReferenceNumber { get; set; }
        /// <summary>
        /// Container for the type of Shipment when doing a Reference Number search. 
        /// This element is required if the Reference Number element is specified.
        /// Code: This element will be used to indicate the type of the shipment being tracked during Reference number tracking.
        /// Valid values: 01 = Package (Default) 02 = Freight 03 = Mail Innovations
        /// </summary>
        RefShipmentType ShipmentType { get; set; }
        /// <summary>
        /// Container for ship from address used to narrow a reference number search.
        /// </summary>
        string ShipperNumber { get; set; }
    }
}
