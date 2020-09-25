using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Collections.Generic;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativeVoidShipmentResponse : INativeVoidShipmentResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(VoidShipmentResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public bool IsDeleted
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(VoidShipmentResponse?.SummaryResult?.Status?.Code) && VoidShipmentResponse?.SummaryResult?.Status?.Description?.ToUpper() == AppConstants.IS_DELETED_DESCRIPTION.ToUpper();
            }
        }
        [AutoMapper.IgnoreMap]
        public bool IsPartiallyDeleted
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(VoidShipmentResponse?.SummaryResult?.Status?.Code) && VoidShipmentResponse?.SummaryResult?.Status?.Description?.ToUpper() == AppConstants.IS_PARTIALLY_DELETED_DESCRIPTION.ToUpper();
            }
        }
        [AutoMapper.IgnoreMap]
        public List<string> DeletedPackageTrackingNumberList
        {
            get
            {
                return VoidShipmentResponse?.PackageLevelResult?.Where(x => AppConstants.BOOLEAN_TRUES.Contains(x.Status?.Code) && x?.Status?.Description?.ToUpper() == AppConstants.IS_DELETED_DESCRIPTION?.ToUpper()).Select(x => x.TrackingNumber).ToList();
            }
        }
        [AutoMapper.IgnoreMap]
        public string DeletedPackageTrackingNumbers
        {
            get
            {
                return string.Join(AppConstants.PACKAGE_TRACKING_NUMBER_DELIMETER, DeletedPackageTrackingNumberList);
            }
        }
        [AutoMapper.IgnoreMap]
        public List<string> AlreadyDeletedPackageTrackingNumberList
        {
            get
            {
                return VoidShipmentResponse?.PackageLevelResult?.Where(x => AppConstants.BOOLEAN_TRUES.Contains(x.Status?.Code) && x?.Status?.Description?.ToUpper() == AppConstants.IS_ALREADY_DELETED_DESCRIPTION?.ToUpper()).Select(x => x.TrackingNumber).ToList();
            }
        }
        [AutoMapper.IgnoreMap]
        public string AlreadyDeletedPackageTrackingNumbers
        {
            get
            {
                return string.Join(AppConstants.PACKAGE_TRACKING_NUMBER_DELIMETER, AlreadyDeletedPackageTrackingNumberList);
            }
        }
        [AutoMapper.IgnoreMap]
        public List<string> FailedDeletionPackageTrackingNumberList
        {
            get
            {
                return VoidShipmentResponse?.PackageLevelResult?.Where(x => AppConstants.BOOLEAN_FALSES.Contains(x.Status?.Code)).Select(x => x.TrackingNumber).ToList();
            }
        }
        [AutoMapper.IgnoreMap]
        public string FailedDeletionPackageTrackingNumbers
        {
            get
            {
                return string.Join(AppConstants.PACKAGE_TRACKING_NUMBER_DELIMETER, FailedDeletionPackageTrackingNumberList);
            }
        }
        public VoidShipmentResponse VoidShipmentResponse { get; set; }
    }
}
