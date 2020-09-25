using AutoMapper;
using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Configuration;
using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Model;
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace JS.Shipment.UPS.Service
{
    public abstract class BaseService
    {
        private static string XML_FILE_DIRECTORY = @"E:\XmlFiles";
        public BaseService(IOptions<UPSConfiguration> config)
        {
            Configuration = config.Value;
            Authentication = config.Value.Authentication;
            TrackConfiguration = config.Value.TrackConfiguration;
            ShipperConfiguration = config.Value.ShipperConfiguration;
            PaymentInfoConfiguration = config.Value.PaymentInfoConfiguration;
            MessageConfiguration = config.Value.MessageConfiguration;
            LabelConfiguration = config.Value.LabelConfiguration;
            ShipmentConfiguration = config.Value.ShipmentConfiguration;
            AppSetupConfiguration = config.Value.AppSetupConfiguration;
            XML_FILE_DIRECTORY = config?.Value?.AppSetupConfiguration?.XmlFileDirectory;
        }
        public UPSConfiguration Configuration { get; set; }
        public Authentication Authentication { get; set; }
        public TrackConfiguration TrackConfiguration { get; set; }
        public ShipperConfiguration ShipperConfiguration { get; set; }
        public PaymentInfoConfiguration PaymentInfoConfiguration { get; set; }
        public MessageConfiguration MessageConfiguration { get; set; }
        public LabelConfiguration LabelConfiguration { get; set; }
        public ShipmentConfiguration ShipmentConfiguration { get; set; }
        public AppSetupConfiguration AppSetupConfiguration { get; set; }
        private string UserName { get { return Authentication.UserName; } }
        private string Password { get { return Authentication.Password; } }
        private string AccountNumber { get { return Authentication.AccountNumber; } }
        private string AccessKey { get { return Authentication.AccessKey; } }
        private string TrackingDaysOffset { get { return TrackConfiguration.TrackingDaysOffset; } }
        public Track.UPSSecurity UPSTrackAuthenticationDetail
        {
            get
            {
                var upssecurity = new Track.UPSSecurity
                {
                    ServiceAccessToken = new Track.UPSSecurityServiceAccessToken { AccessLicenseNumber = AccessKey },
                    UsernameToken = new Track.UPSSecurityUsernameToken() { Username = UserName, Password = Password }
                };
                return upssecurity;
            }
        }
        public Track.TransactionReferenceType UPSTrackTransactionReference
        {
            get
            {
                var transactionReferenceType = new Track.TransactionReferenceType
                {
                    CustomerContext = Authentication.CustomerContext
                };
                return transactionReferenceType;
            }
        }
        public Ship.UPSSecurity UPSShipmentAuthenticationDetail
        {
            get
            {
                var upssecurity = new Ship.UPSSecurity
                {
                    ServiceAccessToken = new Ship.UPSSecurityServiceAccessToken { AccessLicenseNumber = AccessKey },
                    UsernameToken = new Ship.UPSSecurityUsernameToken() { Username = UserName, Password = Password }
                };
                return upssecurity;
            }
        }
        public Ship.TransactionReferenceType UPSShipmentTransactionReference
        {
            get
            {
                var transactionReferenceType = new Ship.TransactionReferenceType
                {
                    CustomerContext = Authentication.CustomerContext
                };
                return transactionReferenceType;
            }
        }
        public Void.UPSSecurity UPSVoidAuthenticationDetail
        {
            get
            {
                var upssecurity = new Void.UPSSecurity
                {
                    ServiceAccessToken = new Void.UPSSecurityServiceAccessToken { AccessLicenseNumber = AccessKey },
                    UsernameToken = new Void.UPSSecurityUsernameToken() { Username = UserName, Password = Password }
                };
                return upssecurity;
            }
        }
        public Void.TransactionReferenceType UpsVoidTransactionReference
        {
            get
            {
                var transactionReferenceType = new Void.TransactionReferenceType
                {
                    CustomerContext = Authentication.CustomerContext
                };
                return transactionReferenceType;
            }
        }
        public Pickup.UPSSecurity UPSPickupAuthenticationDetail
        {
            get
            {
                var upssecurity = new Pickup.UPSSecurity
                {
                    ServiceAccessToken = new Pickup.UPSSecurityServiceAccessToken { AccessLicenseNumber = AccessKey },
                    UsernameToken = new Pickup.UPSSecurityUsernameToken() { Username = UserName, Password = Password }
                };
                return upssecurity;
            }
        }
        public Pickup.TransactionReferenceType UPSPickupTransactionReference
        {
            get
            {
                var transactionReferenceType = new Pickup.TransactionReferenceType
                {
                    CustomerContext = Authentication.CustomerContext
                };
                return transactionReferenceType;
            }
        }
        public UpsLabelRecovery.UPSSecurity UPSLabelRecoveryAuthenticationDetail
        {
            get
            {
                var upssecurity = new UpsLabelRecovery.UPSSecurity
                {
                    ServiceAccessToken = new UpsLabelRecovery.UPSSecurityServiceAccessToken { AccessLicenseNumber = AccessKey },
                    UsernameToken = new UpsLabelRecovery.UPSSecurityUsernameToken() { Username = UserName, Password = Password }
                };
                return upssecurity;
            }
        }
        public UpsLabelRecovery.TransactionReferenceType UPSLabelRecoveryTransactionReference
        {
            get
            {
                var transactionReferenceType = new UpsLabelRecovery.TransactionReferenceType
                {
                    CustomerContext = Authentication.CustomerContext
                };
                return transactionReferenceType;
            }
        }
        public static MapperConfiguration TrackShipmentMapperConfiguration { get; } = new MapperConfiguration(cfg =>
        {
            cfg.CreateProfile("TrackShipment", profile =>
            {
                profile.CreateMap<Track.TrackResponse1, Model.NativeTrackResponse>(MemberList.Source);
                profile.CreateMap<Track.TrackResponse, Model.TrackResponse>().ReverseMap();

                profile.CreateMap<Track.ResponseType, Model.ResponseType>().ReverseMap();
                profile.CreateMap<Track.CodeDescriptionType, Model.CodeDescriptionType>().ReverseMap();
                profile.CreateMap<Track.DetailType, Model.DetailType>().ReverseMap();
                profile.CreateMap<Track.ElementLevelInformationType, Model.ElementLevelInformationType>().ReverseMap();
                profile.CreateMap<Track.ElementIdentifierType, Model.ElementIdentifierType>().ReverseMap();
                profile.CreateMap<Track.TransactionReferenceType, Model.TransactionReferenceType>().ReverseMap();

                profile.CreateMap<Track.ShipmentType, Model.TrackShipmentType>().ReverseMap();
                profile.CreateMap<Track.PackageType, Model.TrackPackageType>().ReverseMap();
                profile.CreateMap<Track.RedirectType, Model.RedirectType>().ReverseMap();
                profile.CreateMap<Track.PackageAddressType, Model.PackageAddressType>().ReverseMap();

                profile.CreateMap<Track.ServiceOptionType, Model.ServiceOptionType>().ReverseMap();

                profile.CreateMap<Track.ActivityType, Model.ActivityType>().ReverseMap();
                profile.CreateMap<Track.StatusType, Model.StatusType>().ReverseMap();
                profile.CreateMap<Track.NextScheduleActivityType, Model.NextScheduleActivityType>().ReverseMap();

                profile.CreateMap<Track.AlternateTrackingInfoType, Model.AlternateTrackingInfoType>().ReverseMap();
                profile.CreateMap<Track.ActivityLocationType, Model.ActivityLocationType>().ReverseMap();
                profile.CreateMap<Track.TransportFacilityType, Model.TransportFacilityType>().ReverseMap();
                profile.CreateMap<Track.MessageType, Model.MessageType>().ReverseMap();


                profile.CreateMap<Track.CodeDescriptionValueType, Model.CodeDescriptionValueType>().ReverseMap();
                profile.CreateMap<Track.RefShipmentType, Model.RefShipmentType>().ReverseMap();
                profile.CreateMap<Track.ShipmentAddressType, Model.ShipmentAddressType>().ReverseMap();
                profile.CreateMap<Track.CommonCodeDescriptionType, Model.CommonCodeDescriptionType>().ReverseMap();
                profile.CreateMap<Track.AddressType, Model.AddressType>(MemberList.Source);
                profile.CreateMap<Model.AddressType, Track.AddressType>(MemberList.Destination);
                profile.CreateMap<Track.WeightType, Model.WeightType>().ReverseMap();
                profile.CreateMap<Track.UnitOfMeasurementType, Model.UnitOfMeasurementType>().ReverseMap();
                profile.CreateMap<Track.ServiceType, Model.ServiceType>().ReverseMap();
                profile.CreateMap<Track.ShipmentReferenceNumberType, Model.ShipmentReferenceNumberType>().ReverseMap();
                profile.CreateMap<Track.ServiceCenterType, Model.ServiceCenterType>().ReverseMap();
                profile.CreateMap<Track.DeliveryDateUnavailableType, Model.DeliveryDateUnavailableType>().ReverseMap();
                profile.CreateMap<Track.DeliveryDetailType, Model.DeliveryDetailType>().ReverseMap();
                profile.CreateMap<Track.VolumeType, Model.VolumeType>().ReverseMap();
                profile.CreateMap<Track.NumberOfPackagingUnitType, Model.NumberOfPackagingUnitType>().ReverseMap();
                profile.CreateMap<Track.CODType, Model.TrackCODType>().ReverseMap();
                profile.CreateMap<Track.AmountType, Model.AmountType>().ReverseMap();
                profile.CreateMap<Track.CODStatusType, Model.CODStatusType>().ReverseMap();
                profile.CreateMap<Track.ShipmentActivityType, Model.ShipmentActivityType>().ReverseMap();
                profile.CreateMap<Track.OriginPortDetailType, Model.OriginPortDetailType>().ReverseMap();
                profile.CreateMap<Track.DateTimeType, Model.DateTimeType>().ReverseMap();
                profile.CreateMap<Track.DestinationPortDetailType, Model.DestinationPortDetailType>().ReverseMap();
                profile.CreateMap<Track.CarrierActivityInformationType, Model.CarrierActivityInformationType>().ReverseMap();
                profile.CreateMap<Track.DocumentType, Model.DocumentType>().ReverseMap();
                profile.CreateMap<Track.AppointmentType, Model.AppointmentType>().ReverseMap();
                profile.CreateMap<Track.AdditionalCodeDescriptionValueType, Model.AdditionalCodeDescriptionValueType>().ReverseMap();

                profile.CreateMap<Model.TrackRequest, Track.TrackRequest>().ReverseMap();
                profile.CreateMap<Model.RequestType, Track.RequestType>().ReverseMap();
                profile.CreateMap<Model.TransactionReferenceType, Track.TransactionReferenceType>().ReverseMap();
                profile.CreateMap<Model.ReferenceNumberType, Track.ReferenceNumberType>().ReverseMap();
                profile.CreateMap<Model.PickupDateRangeType, Track.PickupDateRangeType>().ReverseMap();
                profile.CreateMap<Model.ShipFromRequestType, Track.ShipFromRequestType>().ReverseMap();
                profile.CreateMap<Model.AddressRequestType, Track.AddressRequestType>().ReverseMap();
                profile.CreateMap<Model.ShipToRequestType, Track.ShipToRequestType>().ReverseMap();
                profile.CreateMap<Model.RefShipmentType, Track.RefShipmentType>().ReverseMap();
                profile.CreateMap<Model.ShipperAccountInfoType, Track.ShipperAccountInfoType>().ReverseMap();
            });
        });
        public static MapperConfiguration ShipmentMapperConfiguration { get; } = new MapperConfiguration(cfg =>
        {
            cfg.CreateProfile("Shipment", profile =>
            {
                profile.CreateMap<Ship.ShipmentResponse1, Model.NativeShipmentResponse>(MemberList.Source);
                profile.CreateMap<Ship.ShipmentResponse, Model.ShipmentResponse>().ReverseMap();
                profile.CreateMap<Ship.ResponseType, Model.ResponseType>().ReverseMap();
                profile.CreateMap<Ship.CodeDescriptionType, Model.CodeDescriptionType>().ReverseMap();
                profile.CreateMap<Ship.DetailType, Model.DetailType>().ReverseMap();
                profile.CreateMap<Ship.ElementLevelInformationType, Model.ElementLevelInformationType>().ReverseMap();
                profile.CreateMap<Ship.ElementIdentifierType, Model.ElementIdentifierType>().ReverseMap();
                profile.CreateMap<Ship.TransactionReferenceType, Model.TransactionReferenceType>().ReverseMap();


                profile.CreateMap<Ship.ShipmentResultsType, Model.ShipmentResultsType>().ReverseMap();
                profile.CreateMap<Ship.DisclaimerType, Model.DisclaimerType>().ReverseMap();
                profile.CreateMap<Ship.ShipmentChargesType, Model.ShipmentChargesType>().ReverseMap();
                profile.CreateMap<Ship.ShipChargeType, Model.ShipChargeType>().ReverseMap();
                profile.CreateMap<Ship.TaxChargeType, Model.TaxChargeType>().ReverseMap();

                profile.CreateMap<Ship.NegotiatedRateChargesType, Model.NegotiatedRateChargesType>().ReverseMap();
                profile.CreateMap<Ship.FRSShipmentDataType, Model.FRSShipmentDataType>().ReverseMap();
                profile.CreateMap<Ship.TransportationChargeType, Model.TransportationChargeType>().ReverseMap();
                profile.CreateMap<Ship.FreightDensityRateType, Model.FreightDensityRateType>().ReverseMap();

                profile.CreateMap<Ship.HandlingUnitsResponseType, Model.HandlingUnitsResponseType>().ReverseMap();
                profile.CreateMap<Ship.HandlingUnitsDimensionsType, Model.HandlingUnitsDimensionsType>().ReverseMap();
                profile.CreateMap<Ship.AdjustedHeightType, Model.AdjustedHeightType>().ReverseMap();

                profile.CreateMap<Model.BillingWeightType, Ship.BillingWeightType>().ReverseMap();
                profile.CreateMap<Ship.BillingUnitOfMeasurementType, Model.BillingUnitOfMeasurementType>().ReverseMap();
                profile.CreateMap<Ship.PackageResultsType, Model.PackageResultsType>().ReverseMap();
                profile.CreateMap<Ship.LabelType, Model.LabelType>().ReverseMap();
                profile.CreateMap<Ship.ReceiptType, Model.ReceiptType>().ReverseMap();
                profile.CreateMap<Ship.AccessorialType, Model.AccessorialType>().ReverseMap();
                profile.CreateMap<Ship.FormType, Model.FormType>().ReverseMap();
                profile.CreateMap<Ship.FormImageType, Model.FormImageType>().ReverseMap();
                profile.CreateMap<Ship.ImageFormatType, Model.ImageFormatType>().ReverseMap();
                profile.CreateMap<Ship.ImageType, Model.ImageType>().ReverseMap();
                profile.CreateMap<Ship.SCReportType, Model.SCReportType>().ReverseMap();
                profile.CreateMap<Ship.HighValueReportType, Model.HighValueReportType>().ReverseMap();

                profile.CreateMap<Model.ShipmentRequest, Ship.ShipmentRequest>().ReverseMap();
                profile.CreateMap<Model.RequestType, Ship.RequestType>().ReverseMap();
                profile.CreateMap<Model.TransactionReferenceType, Ship.TransactionReferenceType>().ReverseMap();
                profile.CreateMap<Model.ShipmentType, Ship.ShipmentType>().ReverseMap();
                profile.CreateMap<Model.ReturnServiceType, Ship.ReturnServiceType>().ReverseMap();
                profile.CreateMap<Model.ShipperType, Ship.ShipperType>().ReverseMap();
                profile.CreateMap<Model.ShipAddressType, Ship.ShipAddressType>().ReverseMap();
                profile.CreateMap<Model.ShipToType, Ship.ShipToType>().ReverseMap();
                profile.CreateMap<Model.ShipToAddressType, Ship.ShipToAddressType>().ReverseMap();
                profile.CreateMap<Model.AlternateDeliveryAddressType, Ship.AlternateDeliveryAddressType>().ReverseMap();

                profile.CreateMap<Model.ADLAddressType, Ship.ADLAddressType>().ReverseMap();
                profile.CreateMap<Model.ShipFromType, Ship.ShipFromType>().ReverseMap();
                profile.CreateMap<Model.PaymentInfoType, Ship.PaymentInfoType>().ReverseMap();
                profile.CreateMap<Model.ShipmentChargeType, Ship.ShipmentChargeType>().ReverseMap();
                profile.CreateMap<Model.BillShipperType, Ship.BillShipperType>().ReverseMap();
                profile.CreateMap<Model.CreditCardType, Ship.CreditCardType>().ReverseMap();
                profile.CreateMap<Model.CreditCardAddressType, Ship.CreditCardAddressType>().ReverseMap();
                profile.CreateMap<Model.BillReceiverType, Ship.BillReceiverType>().ReverseMap();
                profile.CreateMap<Model.BillReceiverAddressType, Ship.BillReceiverAddressType>().ReverseMap();
                profile.CreateMap<Model.BillThirdPartyChargeType, Ship.BillThirdPartyChargeType>().ReverseMap();
                profile.CreateMap<Model.AccountAddressType, Ship.AccountAddressType>().ReverseMap();
                profile.CreateMap<Model.FRSPaymentInfoType, Ship.FRSPaymentInfoType>().ReverseMap();
                profile.CreateMap<Model.FreightShipmentInformationType, Ship.FreightShipmentInformationType>().ReverseMap();

                profile.CreateMap<Model.FreightDensityInfoType, Ship.FreightDensityInfoType>().ReverseMap();
                profile.CreateMap<Model.AdjustedHeightType, Ship.AdjustedHeightType>().ReverseMap();
                profile.CreateMap<Model.HandlingUnitsType, Ship.HandlingUnitsType>().ReverseMap();
                profile.CreateMap<Model.ShipUnitOfMeasurementType, Ship.ShipUnitOfMeasurementType>().ReverseMap();
                profile.CreateMap<Model.HandlingUnitsDimensionsType, Ship.HandlingUnitsDimensionsType>().ReverseMap();

                profile.CreateMap<Model.RateInfoType, Ship.RateInfoType>().ReverseMap();
                profile.CreateMap<Model.ReferenceNumberType, Ship.ReferenceNumberType>().ReverseMap();

                profile.CreateMap<Model.ServiceType, Ship.ServiceType>().ReverseMap();
                profile.CreateMap<Model.CurrencyMonetaryType, Ship.CurrencyMonetaryType>().ReverseMap();
                profile.CreateMap<Model.IndicationType, Ship.IndicationType>().ReverseMap();
                profile.CreateMap<Model.PromotionalDiscountInformationType, Ship.PromotionalDiscountInformationType>().ReverseMap();
                profile.CreateMap<Model.DGSignatoryInfoType, Ship.DGSignatoryInfoType>().ReverseMap();

                profile.CreateMap<Model.ShipmentTypeShipmentServiceOptions, Ship.ShipmentTypeShipmentServiceOptions>().ReverseMap();
                profile.CreateMap<Model.PackageType, Ship.PackageType>().ReverseMap();
                profile.CreateMap<Model.PackagingType, Ship.PackagingType>().ReverseMap();
                profile.CreateMap<Model.DimensionsType, Ship.DimensionsType>().ReverseMap();

                profile.CreateMap<Model.PackageWeightType, Ship.PackageWeightType>().ReverseMap();
                profile.CreateMap<Model.PackageServiceOptionsType, Ship.PackageServiceOptionsType>().ReverseMap();
                profile.CreateMap<Model.DeliveryConfirmationType, Ship.DeliveryConfirmationType>().ReverseMap();
                profile.CreateMap<Model.PackageDeclaredValueType, Ship.PackageDeclaredValueType>().ReverseMap();
                profile.CreateMap<Model.DeclaredValueType, Ship.DeclaredValueType>().ReverseMap();
                profile.CreateMap<Model.PSOCODType, Ship.PSOCODType>().ReverseMap();
                profile.CreateMap<Model.PackageServiceOptionsAccessPointCODType, Ship.PackageServiceOptionsAccessPointCODType>().ReverseMap();
                profile.CreateMap<Model.VerbalConfirmationType, Ship.VerbalConfirmationType>().ReverseMap();

                profile.CreateMap<Model.ContactInfoType, Ship.ContactInfoType>().ReverseMap();
                profile.CreateMap<Model.ShipPhoneType, Ship.ShipPhoneType>().ReverseMap();
                profile.CreateMap<Model.PSONotificationType, Ship.PSONotificationType>().ReverseMap();
                profile.CreateMap<Model.EmailDetailsType, Ship.EmailDetailsType>().ReverseMap();
                profile.CreateMap<Model.HazMatType, Ship.HazMatType>().ReverseMap();
                profile.CreateMap<Model.DryIceType, Ship.DryIceType>().ReverseMap();
                profile.CreateMap<Model.DryIceWeightType, Ship.DryIceWeightType>().ReverseMap();

                profile.CreateMap<Model.CommodityType, Ship.CommodityType>().ReverseMap();
                profile.CreateMap<Model.NMFCType, Ship.NMFCType>().ReverseMap();
                profile.CreateMap<Model.HazMatPackageInformationType, Ship.HazMatPackageInformationType>().ReverseMap();

                profile.CreateMap<Model.ShipConfirmRequest, Ship.ShipConfirmRequest>().ReverseMap();
                profile.CreateMap<Ship.ShipConfirmResponse1, Model.NativeShipConfirmResponse>(MemberList.Source);
                profile.CreateMap<Ship.ShipConfirmResponse, Model.ShipConfirmResponse>().ReverseMap();

                profile.CreateMap<Model.ShipAcceptRequest, Ship.ShipAcceptRequest>().ReverseMap();
                profile.CreateMap<Ship.ShipAcceptResponse1, Model.NativeShipAcceptResponse>(MemberList.Source);
                profile.CreateMap<Ship.ShipAcceptResponse, Model.ShipAcceptResponse>().ReverseMap();
            });
        });
        public static MapperConfiguration VoidMapperConfiguration { get; } = new MapperConfiguration(cfg =>
        {
            cfg.CreateProfile("Void", profile =>
            {
                profile.CreateMap<Model.VoidShipmentRequest, Void.VoidShipmentRequest>().ReverseMap();
                profile.CreateMap<Model.RequestType, Void.RequestType>().ReverseMap();
                profile.CreateMap<Model.TransactionReferenceType, Void.TransactionReferenceType>().ReverseMap();
                profile.CreateMap<Model.VoidShipmentRequestVoidShipment, Void.VoidShipmentRequestVoidShipment>().ReverseMap();


                profile.CreateMap<Void.VoidShipmentResponse1, Model.NativeVoidShipmentResponse>(MemberList.Source);
                profile.CreateMap<Void.VoidShipmentResponse, Model.VoidShipmentResponse>().ReverseMap();
                profile.CreateMap<Void.ResponseType, Model.ResponseType>().ReverseMap();
                profile.CreateMap<Void.CodeDescriptionType, Model.CodeDescriptionType>();
                profile.CreateMap<Void.DetailType, Model.DetailType>().ReverseMap();
                profile.CreateMap<Void.ElementLevelInformationType, Model.ElementLevelInformationType>().ReverseMap();
                profile.CreateMap<Void.ElementIdentifierType, Model.ElementIdentifierType>().ReverseMap();
                profile.CreateMap<Void.TransactionReferenceType, Model.TransactionReferenceType>().ReverseMap();


                profile.CreateMap<Void.VoidShipmentResponseSummaryResult, Model.VoidShipmentResponseSummaryResult>().ReverseMap();
                profile.CreateMap<Void.CodeDescriptionType1, Model.CodeDescriptionType>();
                profile.CreateMap<Void.PackageLevelResult, Model.PackageLevelResult>().ReverseMap();

            });
        });
        public static MapperConfiguration PickupMapperConfiguration { get; } = new MapperConfiguration(cfg =>
        {
            cfg.CreateProfile("Pickup", profile =>
            {
                #region Pickup Creation
                profile.CreateMap<Model.PickupCreationRequest, Pickup.PickupCreationRequest>().ReverseMap();
                profile.CreateMap<Model.RequestType, Pickup.RequestType>().ReverseMap();
                profile.CreateMap<Model.TransactionReferenceType, Pickup.TransactionReferenceType>().ReverseMap();

                profile.CreateMap<Model.PickupShipperType, Pickup.ShipperType>().ReverseMap();
                profile.CreateMap<Model.AccountType, Pickup.AccountType>().ReverseMap();
                profile.CreateMap<Model.ChargeCardType, Pickup.ChargeCardType>().ReverseMap();
                profile.CreateMap<Model.ChargeCardAddressType, Pickup.ChargeCardAddressType>().ReverseMap();
                profile.CreateMap<Model.TaxInformationType, Pickup.TaxInformationType>().ReverseMap();

                profile.CreateMap<Model.PickupDateInfoType, Pickup.PickupDateInfoType>().ReverseMap();

                profile.CreateMap<Model.PickupAddressType, Pickup.PickupAddressType>().ReverseMap();
                profile.CreateMap<Model.PhoneType, Pickup.PhoneType>().ReverseMap();

                profile.CreateMap<Model.PickupPieceType, Pickup.PickupPieceType>().ReverseMap();
                profile.CreateMap<Model.PickupWeightType, Pickup.WeightType>().ReverseMap();

                profile.CreateMap<Model.TrackingDataType, Pickup.TrackingDataType>().ReverseMap();
                profile.CreateMap<Model.TrackingDataWithReferenceNumberType, Pickup.TrackingDataWithReferenceNumberType>().ReverseMap();
                profile.CreateMap<Model.FreightOptionsType, Pickup.FreightOptionsType>().ReverseMap();


                profile.CreateMap<Pickup.PickupCreationResponse1, Model.NativePickupCreationResponse>(MemberList.Source);
                profile.CreateMap<Pickup.PickupCreationResponse, Model.PickupCreationResponse>().ReverseMap();
                profile.CreateMap<Pickup.ResponseType, Model.ResponseType>().ReverseMap();
                profile.CreateMap<Pickup.CodeDescriptionType, Model.CodeDescriptionType>().ReverseMap();
                profile.CreateMap<Pickup.DetailType, Model.DetailType>().ReverseMap();
                profile.CreateMap<Pickup.ElementLevelInformationType, Model.ElementLevelInformationType>().ReverseMap();
                profile.CreateMap<Pickup.ElementIdentifierType, Model.ElementIdentifierType>().ReverseMap();
                profile.CreateMap<Pickup.TransactionReferenceType, Model.TransactionReferenceType>().ReverseMap();


                profile.CreateMap<Pickup.StatusCodeDescriptionType, Model.StatusCodeDescriptionType>().ReverseMap();
                profile.CreateMap<Pickup.RateResultType, Model.RateResultType>().ReverseMap();
                profile.CreateMap<Pickup.DisclaimerType, Model.DisclaimerType>().ReverseMap();
                profile.CreateMap<Pickup.ChargeDetailType, Model.ChargeDetailType>().ReverseMap();
                profile.CreateMap<Pickup.TaxChargeType, Model.TaxChargeType>().ReverseMap();
                #endregion
                #region Get Service Center Facilities                
                profile.CreateMap<Model.PickupGetServiceCenterFacilitiesRequest, Pickup.PickupGetServiceCenterFacilitiesRequest>().ReverseMap();
                profile.CreateMap<Model.PickupPieceServiceType, Pickup.PickupPieceServiceType>().ReverseMap();
                profile.CreateMap<Model.OriginAddressType, Pickup.OriginAddressType>().ReverseMap();
                profile.CreateMap<Model.OriginSearchCriteriaType, Pickup.OriginSearchCriteriaType>().ReverseMap();
                profile.CreateMap<Model.DestinationAddressType, Pickup.DestinationAddressType>().ReverseMap();

                profile.CreateMap<Pickup.PickupGetServiceCenterFacilitiesResponse1, Model.NativePickupGetServiceCenterFacilitiesResponse>(MemberList.Source);
                profile.CreateMap<Pickup.PickupGetServiceCenterFacilitiesResponse, Model.PickupGetServiceCenterFacilitiesResponse>().ReverseMap();
                profile.CreateMap<Pickup.ServiceCenterLocationsType, Model.ServiceCenterLocationsType>().ReverseMap();
                profile.CreateMap<Pickup.DropOffFacilitiesType, Model.DropOffFacilitiesType>().ReverseMap();
                profile.CreateMap<Pickup.DayOfWeekType, Model.DayOfWeekType>().ReverseMap();
                profile.CreateMap<Pickup.LocalizedInstructionType, Model.LocalizedInstructionType>().ReverseMap();
                profile.CreateMap<Pickup.DistanceType, Model.DistanceType>().ReverseMap();
                profile.CreateMap<Pickup.PickupFacilitiesType, Model.PickupFacilitiesType>().ReverseMap();
                #endregion
                #region Cancel Pickup              
                profile.CreateMap<Model.PickupCancelRequest, Pickup.PickupCancelRequest>().ReverseMap();

                profile.CreateMap<Pickup.PickupCancelResponse1, Model.NativePickupCancelResponse>(MemberList.Source);
                profile.CreateMap<Pickup.PickupCancelResponse, Model.PickupCancelResponse>().ReverseMap();
                #endregion
                #region Pending Pickup  Status            
                profile.CreateMap<Model.PickupPendingStatusRequest, Pickup.PickupPendingStatusRequest>().ReverseMap();

                profile.CreateMap<Pickup.PickupPendingStatusResponse1, Model.NativePickupPendingStatusResponse>(MemberList.Source);
                profile.CreateMap<Pickup.PickupPendingStatusResponse, Model.PickupPendingStatusResponse>().ReverseMap();
                profile.CreateMap<Pickup.PendingStatusType, Model.PendingStatusType>().ReverseMap();
                #endregion
                #region Pickup  Rate            
                profile.CreateMap<Model.PickupRateRequest, Pickup.PickupRateRequest>().ReverseMap();
                profile.CreateMap<Pickup.ShipperAccountType, Model.ShipperAccountType>().ReverseMap();
                profile.CreateMap<Pickup.AddressType, Model.PickupRateAddressType>().ReverseMap();

                profile.CreateMap<Pickup.PickupRateResponse1, Model.NativePickupRateResponse>(MemberList.Source);
                profile.CreateMap<Pickup.PickupRateResponse, Model.PickupRateResponse>().ReverseMap();
                #endregion 
                #region Pickup  Political Division            
                profile.CreateMap<Model.PickupGetPoliticalDivision1ListRequest, Pickup.PickupGetPoliticalDivision1ListRequest>().ReverseMap();

                profile.CreateMap<Pickup.PickupGetPoliticalDivision1ListResponse1, Model.NativePickupGetPoliticalDivision1ListResponse>(MemberList.Source);
                profile.CreateMap<Pickup.PickupGetPoliticalDivision1ListResponse, Model.PickupGetPoliticalDivision1ListResponse>().ReverseMap();

                #endregion
            });
        });
        public static MapperConfiguration LabelRecoveryMapperConfiguration { get; } = new MapperConfiguration(cfg =>
        {
            cfg.CreateProfile("LabelRecovery", profile =>
            {
                profile.CreateMap<Model.LabelRecoveryRequest, UpsLabelRecovery.LabelRecoveryRequest>();
                profile.CreateMap<Model.RequestType, UpsLabelRecovery.RequestType>().ReverseMap();
                profile.CreateMap<Model.TransactionReferenceType, UpsLabelRecovery.TransactionReferenceType>().ReverseMap();
                profile.CreateMap<Model.LabelSpecificationType, UpsLabelRecovery.LabelSpecificationType>().ReverseMap();
                profile.CreateMap<Model.LabelImageFormatType, UpsLabelRecovery.LabelImageFormatType>().ReverseMap();
                profile.CreateMap<Model.LabelStockSizeType, UpsLabelRecovery.LabelStockSizeType>().ReverseMap();

                profile.CreateMap<Model.TranslateType, UpsLabelRecovery.TranslateType>().ReverseMap();
                profile.CreateMap<Model.LabelDeliveryType, UpsLabelRecovery.LabelDeliveryType>(MemberList.Destination);

                profile.CreateMap<Model.ReferenceValuesType, UpsLabelRecovery.ReferenceValuesType>().ReverseMap();
                profile.CreateMap<Model.ReferenceNumberType, UpsLabelRecovery.ReferenceNumberType>().ReverseMap();
                profile.CreateMap<Model.LRUPSPremiumCareFormType, UpsLabelRecovery.LRUPSPremiumCareFormType>().ReverseMap();

                profile.CreateMap<UpsLabelRecovery.LabelRecoveryResponse1, Model.NativeLabelRecoveryResponse>(MemberList.Source);

                profile.CreateMap<UpsLabelRecovery.LabelRecoveryResponse, Model.LabelRecoveryResponse>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.ResponseType, Model.ResponseType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.CodeDescriptionType, Model.CodeDescriptionType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.DetailType, Model.DetailType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.ElementLevelInformationType, Model.ElementLevelInformationType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.ElementIdentifierType, Model.ElementIdentifierType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.TransactionReferenceType, Model.TransactionReferenceType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.ResponseImageType, Model.ResponseImageType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.ResponseImageDetailType, Model.ResponseImageDetailType>().ReverseMap();

                profile.CreateMap<UpsLabelRecovery.ImageFormatCodeType, Model.ImageFormatCodeType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.FormType, Model.FormType>(MemberList.Source);
                profile.CreateMap<UpsLabelRecovery.FormImageType, Model.FormImageType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.HighValueReportType, Model.HighValueReportType>().ReverseMap();
                profile.CreateMap<UpsLabelRecovery.HVRImageType, Model.HVRImageType>().ReverseMap();
                //profile.CreateMap<UpsLabelRecovery.LabelImageType, Model.LabelImageType>().ReverseMap();
                //profile.CreateMap<UpsLabelRecovery.LabelResultsType, Model.LabelResultsType>().ReverseMap();
            });
        });
        public static void WriteXML<T>(T data) where T : class, new()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, data);
                var value = stringwriter.ToString();
                var fileName = $"UPSobject-{typeof(T).Name}-{System.DateTime.Now.ToString("ddMMMyyyy-hhmmss")}.xml";
                if (!System.IO.Directory.Exists(XML_FILE_DIRECTORY))
                    System.IO.Directory.CreateDirectory(XML_FILE_DIRECTORY);
                var file = System.IO.Path.Combine(XML_FILE_DIRECTORY, fileName);
                System.IO.File.WriteAllText(file, value);
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public virtual T SetupAuthentication<T>(IAuthentication authentication) where T : class, new()
        {
            T obj = new T();
            try
            {
                Type t = typeof(T);
                Assembly assemFromType = t.Assembly;
                var nameSpace = t.Namespace;
                Type upscurityServiceAccessToken = assemFromType.GetType($"{nameSpace}.UPSSecurityServiceAccessToken");

                object upscurityServiceAccessTokenInstance = Activator.CreateInstance(upscurityServiceAccessToken);
                upscurityServiceAccessTokenInstance.GetType().InvokeMember("AccessLicenseNumber",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                    Type.DefaultBinder, upscurityServiceAccessTokenInstance, new string[] { authentication.AccessKey });

                Type upsSecurityUsernameToken = assemFromType.GetType($"{nameSpace}.UPSSecurityUsernameToken");

                object upsSecurityUsernameTokenInstance = Activator.CreateInstance(upsSecurityUsernameToken);
                upsSecurityUsernameTokenInstance.GetType().InvokeMember("Username",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                    Type.DefaultBinder, upsSecurityUsernameTokenInstance, new string[] { authentication.UserName });
                upsSecurityUsernameTokenInstance.GetType().InvokeMember("Password",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                    Type.DefaultBinder, upsSecurityUsernameTokenInstance, new string[] { authentication.Password });

                Type serviceAccessToken = assemFromType.GetType($"{nameSpace}.ServiceAccessToken");
                obj.GetType().InvokeMember("ServiceAccessToken",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                    Type.DefaultBinder, obj, new object[] { upscurityServiceAccessTokenInstance });
                obj.GetType().InvokeMember("UsernameToken",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                    Type.DefaultBinder, obj, new object[] { upsSecurityUsernameTokenInstance });
            }
            catch (Exception ex) { }
            return obj;
        }
        public virtual void SetupConfiguration<T>(T request, IUPSConfiguration configuration) where T : IShipRequest
        {
            request.LabelSpecification = request?.LabelSpecification ?? configuration?.LabelConfiguration?.LabelSpecification ?? Configuration?.LabelConfiguration?.LabelSpecification;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };
            if (request.Shipment != null)
            {
                request.Shipment.Shipper = request?.Shipment?.Shipper ?? configuration?.ShipperConfiguration?.Shipper ?? Configuration?.ShipperConfiguration?.Shipper;
                request.Shipment.PaymentInformation = request?.Shipment?.PaymentInformation ?? configuration?.PaymentInfoConfiguration?.PaymentInformation ?? Configuration?.PaymentInfoConfiguration?.PaymentInformation;
            }
        }
        public virtual U BuildRequest<R, U>(R request, IConfigurationProvider mapperConfiguration) where R : class, new() where U : class, new()
        {
            U upsRequest = new U();
            try
            {
                var executionPlan = mapperConfiguration.BuildExecutionPlan(typeof(R), typeof(U));
                mapperConfiguration.AssertConfigurationIsValid();
                //Mapper mapper = new Mapper(ProcessShipmentConfiguration);
                var iMapper = mapperConfiguration.CreateMapper();
                upsRequest = iMapper.Map<U>(request);
            }
            catch (Exception ex) { }
            return upsRequest;
        }
        public virtual A BuildResponse<R, A>(R response, IConfigurationProvider mapperConfiguration) where R : class, new() where A : class, new()
        {
            A answer = new A();
            try
            {
                var executionPlan = mapperConfiguration.BuildExecutionPlan(typeof(R), typeof(A));
                mapperConfiguration.AssertConfigurationIsValid();
                //Mapper mapper = new Mapper(ProcessShipmentConfiguration);
                var iMapper = mapperConfiguration.CreateMapper();
                answer = iMapper.Map<A>(response);
            }
            catch (Exception ex) { }
            return answer;
        }
        public static string GetXMLFromObject<T>(T obj)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, obj);
            }
            catch (Exception ex)
            {

                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }
        public static bool Validate<T>(T request, Dictionary<string, string> xsdFiles, out string errorMessage)
        {
            bool isValid = true;
            errorMessage = null;
            var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            XmlSchemaSet schema = new XmlSchemaSet();
            foreach (var xsdFile in xsdFiles)
                schema.Add(xsdFile.Value, xsdFile.Key);
            //StringReader txtReader = new StringReader(GetXMLFromObject(request));
            //XmlReader rd = XmlReader.Create(path + "\\input.xml");
            //XDocument doc = XDocument.Load(rd);
            using (TextReader tr = new StringReader(GetXMLFromObject(request)))
            {
                try
                {
                    XDocument doc = XDocument.Load(tr);
                    Console.WriteLine(doc);
                    doc.Validate(schema, ValidationEventHandler);
                }
                catch (Exception ex)
                {
                    isValid = false;
                    errorMessage = ex.Message;
                }
            }
            return isValid;
        }
        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
            }
        }
    }
}
