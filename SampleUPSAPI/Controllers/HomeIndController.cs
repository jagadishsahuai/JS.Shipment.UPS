using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Criteria;
using JS.Shipment.UPS.Configuration;
using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Criteria;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Contract.Service;
using JS.Shipment.UPS.Model;
using JS.Shipment.UPS.Service;
using SampleUPSAPI.Web.Test.Models;

namespace SampleUPSAPI.Web.Test.Controllers
{
    public class HomeIndController : Controller
    {
        ITrackService _trackService;
        IShipmentService _shipmentService;
        IVoidShipmentService _voidShipmentService;
        ILabelRecoveryService _labelRecoveryService;
        IPickupService _pickupService;
        UPSConfiguration _config;
        public HomeIndController(ITrackService trackService, IShipmentService shipmentService, IVoidShipmentService voidShipmentService, ILabelRecoveryService labelRecoveryService, IPickupService pickupService, IOptions<UPSConfiguration> config)
        {
            this._trackService = trackService;
            this._shipmentService = shipmentService;
            this._voidShipmentService = voidShipmentService;
            this._labelRecoveryService = labelRecoveryService;
            this._pickupService = pickupService;
            this._config = config?.Value;
        }
        public IActionResult Index()
        {
            //ITrackRequest request = new TrackRequest()
            //{
            //    InquiryNumber = "1Z12345E0305271640"
            //};
            //var response = _trackService.ProcessTrackAsync(request);
            return View();
        }
        public async Task<IActionResult> TrackAsync()
        {
            ITrackRequest request = new TrackRequest()
            {
                InquiryNumber = "1Z12345E0305271640" //None (Last) | Ground | Delivered
                //1Z12345E6205277936 Activity (All) | Next Day Air Saver | 2nd Delivery attempt
            };
            IUPSConfiguration configuration = new UPSConfiguration
            {
                Authentication = new Authentication
                {
                    AccessKey = _config?.Authentication?.AccessKey,
                    AccountNumber = _config?.Authentication?.AccountNumber,
                    Password = _config?.Authentication?.Password,
                    UserName = _config?.Authentication?.UserName,
                    CustomerContext = _config?.Authentication?.CustomerContext,
                }
            };
            var response = await _trackService.ProcessTrackAsync(request, configuration);
            var s = response.CurrentShipmentStatuses;
            return View();
        }
        public async Task<IActionResult> CriteriaTrackAsync()
        {
            ITrackCriteria criteria = new TrackCriteria()
            {
                TrackingReferenceNumber = "1Z12345E0305271640",
                TrackingOption = "02"
            };
            var response = await _trackService.ProcessTrackAsync(criteria);
            return View();
        }
        public async Task<IActionResult> CreateShipmentAsync()
        {
            INativeShipmentResponse response = null;
            try
            {
                IUPSConfiguration configuration = new UPSConfiguration
                {
                    Authentication = new Authentication
                    {
                        AccessKey = _config?.Authentication?.AccessKey,
                        AccountNumber = _config?.Authentication?.AccountNumber,
                        Password = _config?.Authentication?.Password,
                        UserName = _config?.Authentication?.UserName,
                        CustomerContext = _config?.Authentication?.CustomerContext,
                    }
                };
                response = await _shipmentService.ProcessShipmentAsync(ShipmentRequest, configuration);
            }
            catch (Exception ex) { }
            return View();
        }
        private IShipmentRequest ShipmentRequest
        {
            get
            {
                IShipmentRequest shipmentRequest = new ShipmentRequest()
                {
                    //Request Container
                    //Required: Yes
                    Request = new RequestType()
                    {
                        //Valid values are validate and nonvalidate.
                        //Optional Processing. nonvalidate = UPS will not perform any address validation.
                        //validate = UPS will validate the City, State and Postal Code (Regional). 
                        //UPS will not validate the Street address. 
                        //Note: Despite any request to UPS for validation, it remains the responsibility of the Shipping API User to ensure the address entered is correct to avoid an address correction fee.
                        //Length: 1…11
                        //Required: Yes
                        RequestOption = new string[] { "validate" }
                    },
                    //Shipment Container
                    //Required: Yes
                    Shipment = new ShipmentType
                    {
                        //The Description of Goods for the shipment. 
                        //Applies to international and domestic shipments. 
                        //Provide a detailed description of items being shipped for documents and non-documents. 
                        //Examples: "annual reports" and "9 mm steel screws".
                        //Length: 1…50
                        //Validation:
                        //Required if all of the listed conditions are true: 
                        //ShipFrom and ShipTo countries or territories are not the same; 
                        //The packaging type is not UPS Letter; 
                        //The ShipFrom and or ShipTo countries or territories are not in the European Union or the ShipFrom 
                        //and ShipTo countries or territories are both in the European Union and the shipments service type is not UPS Standard.
                        //Required: Cond
                        Description = "Ship webservice example",
                        //Container for the Shipper’s information.
                        //Required: Yes
                        Shipper = new ShipperType
                        {
                            //Shipper’s six digit alphanumeric account number. 
                            //Must be associated with the UserId specified in the AccessRequest XML. 
                            //The account must be a valid UPS account number that is active. 
                            //For US, PR and CA accounts, the account must be either a daily pickup account, an occasional account, or a customer B.I.N account. 
                            //Drop Shipper accounts are valid for return service shipments only if the account is Trade Direct (TD) enabled. 
                            //All other accounts must be either a daily pickup account or an occasional account.
                            //Length: 6
                            //Required: Yes
                            ShipperNumber = _config?.ShipperConfiguration?.Shipper?.ShipperNumber,
                            //The package should be returned to this address if the package is undeliverable. 
                            //This address appears on the upper left hand corner of the label. 
                            //Note: If the ShipFrom container is not present then this address will be used as the ShipFrom address. 
                            //If this address is used as the ShipFrom the shipment will be rated from this origin address.
                            //Address tag Container.
                            //Required: Yes
                            Address = new ShipAddressType
                            {
                                //The Shipper street address including name and number (when applicable).
                                //Validation:
                                //Up to three occurrences are allowed; only the first is printed on the label.
                                //35 characters are accepted, but for the first occurrence, only 30 characters will be printed on the label for return shipments.
                                //Max Allowed: 3 
                                //Length: 1…35
                                //Required: Yes
                                AddressLine = new string[] { "D25, Noida Setor 24" },
                                //Shipper's City.
                                //For forward Shipment 30 characters are accepted, but only 15 characters will be printed on the label.
                                //Length: 1…30
                                //Required: Yes
                                City = "Noida",
                                //Shipper’s postal code.
                                //Length: 1…9
                                //Required: Cond
                                PostalCode = "201301",
                                //Shipper's state or province code. For forward Shipment 5 characters are accepted, but only 2 characters will be printed on the label.
                                //Validation:
                                //For US, PR and CA accounts, the account must be either a daily pickup account, an occasional account, or a customer B.I.N account.
                                //Length: 2…5
                                //Required: Cond
                                StateProvinceCode = "UP",
                                //Shipper’s country or territory code. Refer to Country or Territory Codes in the Appendix for valid values.
                                //Validation:
                                //Drop Shipper accounts are valid for return service shipments only if the account is Trade Direct (TD) enabled.
                                //Length: 2
                                //Required: Yes
                                CountryCode = "IN"
                            },
                            //Shippers company name. For forward Shipment 35 characters are accepted, but only 30 characters will be printed on the label.
                            //Length: 1…35
                            //Required: Yes
                            Name = "ABC Associates",
                            //Shippers Attention Name. For forward Shipment 35 characters are accepted, but only 30 characters will be printed on the label.
                            //Validation:
                            //Required if destination is international. 
                            //Required if Invoice and CO International forms are requested and the ShipFrom address is not present.
                            //Length: 1…35
                            //Required: Cond
                            AttentionName = "ABC Associates",
                            //Container tag for Phone Number.
                            //Required: Cond
                            Phone = new ShipPhoneType
                            {
                                //Shipper’s phone Number.
                                //Valid values are 0 - 9. 
                                //If Shipper country or territory is US, PR, CA, and VI, the layout is: area code, 7 digit PhoneNumber or area code, 7 digit PhoneNumber, 4 digit extension number. 
                                //For other country or territory, the layout is: CountryCode, area code, 7 digit number.
                                //A phone number is required if destination is international.
                                //Length: 1…15
                                //Required: Yes*
                                Number = "1234567890"
                            }
                        },
                        //Payment information container for detailed shipment charges. 
                        //The two shipment charges that are available for specification are Transportation charges and Duties and Taxes.
                        //Validation:
                        //It is required for non-Ground Freight Pricing shipments only.
                        //Required: Cond
                        PaymentInformation = new PaymentInfoType
                        {
                            //Shipment charge container.
                            //Validation:
                            //If Duty and Tax charges are applicable to a shipment and a payer is not specified, the default payer of Duty and Tax charges is Bill to Receiver.
                            //Required: Yes*
                            ShipmentCharge = new ShipmentChargeType[]
                            {
                                new ShipmentChargeType
                                {
                                    //Container for the BillShipper billing option. 
                                    //The three payment methods that are available for the Bill Shipper billing option are alternate payment method, account number or credit card.
                                    //Validation:
                                    //This element or its sibling element, BillReceiver, BillThirdParty or ConsigneeBilledIndicator, must be present but no more than one can be present.
                                    //Required: Cond
                                    BillShipper = new BillShipperType
                                    {
                                        //UPS account number.
                                        //Validation:
                                        //Must be the same UPS account number as the one provided in Shipper/ShipperNumber. 
                                        //Either this element or one of the sibling elements CreditCard 
                                        //or AlternatePaymentMethod must be provided, but all of them may not be provided.
                                        //Max Allowed: 1 
                                        //Length: 6
                                        //Required: Cond 
                                        AccountNumber = _config?.PaymentInfoConfiguration?.PaymentInformation?.ShipmentCharge?.FirstOrDefault()?.BillShipper?.AccountNumber
                                    },
                                    //Valid values: 01 = Transportation 02 = Duties and Taxes 03 = Broker of Choice
                                    //Validation:
                                    //A shipment charge type of 01 = Transportation is required. 
                                    //A shipment charge type of 02 = Duties and Taxes is not required; 
                                    //however, this charge type is invalid for Qualified Domestic Shipments. 
                                    //A Qualified Domestic Shipment is any shipment in which one of the following applies: 
                                    //1) The origin and destination country or territory is the same. 
                                    //2) US to PR shipment. 
                                    //3) PR to US shipment. 
                                    //4) The origin and destination country or territory are both European Union countries 
                                    //and territories and the GoodsNotInFreeCirculation indicator is not present. 
                                    //5) The origin and destination IATA code is the same.
                                    //03 = Broker of Choice
                                    Type = "01",
                                }
                            }
                        },
                        //Ship From Container.
                        //Validation:
                        //Required for return shipment. Required if pickup location is different from the shipper’s address.
                        //Required: Cond
                        ShipFrom = new ShipFromType
                        {
                            //The ship from Attention name. 35 characters are accepted, but for return Shipment only 30 characters will be printed on the label.
                            //Validation:
                            //Required if ShipFrom tag is in the XML and Invoice or CO International forms is requested. 
                            //If not present, will default to the Shipper Attention Name.
                            //Max Allowed: 1 
                            //Length: 1…35
                            //Required: Cond 
                            AttentionName = "Mr.ABC",
                            //The ship from location’s name or company name. 35 characters are accepted, but for return Shipment only 30 characters will be printed on the label.
                            //Validations:
                            //Required if ShipFrom tag is in the XML.
                            //Max Allowed: 1 
                            //Length: 1…35
                            //Required: Yes* 
                            Name = "ABC Associates",
                            //Ship from Address Container.
                            //Validation:
                            //The package will be originating from or being shipped from this address. T
                            //he shipment will be rated from this origin address to the destination ship to address.
                            //Max Allowed: 1 Length: N/A
                            //Required: Yes*
                            Address = new ShipAddressType
                            {
                                //The Ship from street address including name and number
                                //(when applicable). 35 characters are accepted, but for return Shipment only 30 characters will be printed on the label.
                                //Validation:
                                //Max occurrence: 3
                                //Max Allowed: 3 
                                //Length: 1…35
                                //Required: Yes*
                                AddressLine = new string[] { "D25, Noida Setor 24" },
                                //The Ship from city. 30 characters are accepted, but for return Shipment only 15 characters will be printed on the label.
                                //Validation:
                                //Required if ShipFrom tag is in the XML.
                                //Max Allowed: 1 
                                //Length: 1…30
                                //Required: Yes* 
                                City = "Noida",
                                //The ship from locations postal code. 9 characters are accepted.
                                //Validation:
                                //Required if ShipFrom tag is in the XML and the ShipFrom country or territory is the US and Puerto Rico. 
                                //For US and Puerto Rico, it must be valid 5 or 9 digit postal code. 
                                //The character "-" may be used to separate the first five digits and the last four digits. 
                                //If the ShipFrom country or territory is CA, then the postal code must be 6 alphanumeric characters 
                                //whose format is A#A#A# where A is an uppercase letter and # is a digit. 
                                //For all other countries or territories the postal code is optional and must be no more than 9 alphanumeric characters long.
                                PostalCode = "201301",
                                //Origin locations state or province code.
                                //Validation:
                                //Required if ShipFrom tag is in the XML, and ShipFrom Country or territory is US. 
                                //If ShipFrom country or territory is US or CA, then the value must be a valid US State/ Canadian Province code. 
                                //If the country or territory is Ireland, the StateProvinceCode will contain the county.
                                //Max Allowed: 1 
                                //Length: 2…5
                                //Required: Cond 
                                StateProvinceCode = "UP",
                                //Origin locations country or territory code.
                                //Validation:
                                //Required if ShipFrom tag is in the XML. 
                                //For Return Shipment the country or territory code must meet the following conditions: 
                                //1) At least two of the following country or territory codes are the same: ShipTo, ShipFrom, and Shipper. 
                                //2) None of the following country or territory codes are the same and are a member of the EU: ShipTo, ShipFrom, and Shipper. 
                                //3) If any of the two following country or territory codes: ShipTo/ShipFrom/ Shipper are members in EU otherwise check if the shipper has Third Country or territory Contract.
                                //Max Allowed: 1 
                                //Length: 2
                                //Required: Yes* 
                                CountryCode = "IN"
                            }
                        },
                        //Ship To Container.
                        //Required: Yes
                        ShipTo = new ShipToType
                        {
                            //Contact name at the consignee’s location.
                            //Validation:
                            //Required for: UPS Next Day Air® Early service, and when ShipTo country or territory is different than ShipFrom country or territory. 
                            //Required if Invoice International form is requested.
                            //Length: 1…35
                            //Required: Cond
                            AttentionName = "DEF",
                            //Consignee’s company name.
                            //Validation:
                            //All other accounts must be either a daily pickup account or an occasional account.
                            //Length: 1…35
                            //Required: Yes
                            Name = "DEF Associates",
                            //Address Container.
                            //Required: Yes
                            Address = new ShipToAddressType
                            {
                                //Address Line of the consignee.
                                //Validation
                                //Max occurrence: 3 Only first two Address Lines will be printed on the label.
                                //Max Allowed: 3 
                                //Length: 1…35
                                //Required: Yes 
                                AddressLine = new string[] { "GOERLITZER STR.1" },
                                //Consignee’s city. 30 characters are accepted, but only 15 characters will be printed on the label.
                                //Max Allowed: 1 
                                //Length: 1…30
                                //Required: Yes 
                                City = "Neuss",
                                //Consignee’s postal code.
                                //Validations:
                                //If the ShipTo country or territory is US or Puerto Rico, 5 or 9 digits are required. 
                                //If the ShipTo country or territory is CA, then the postal code is required and must be 6 alphanumeric characters 
                                //whose format is A#A#A# where A is an uppercase letter and # is a digit. 
                                //Otherwise optional. 
                                //For all other countries or territories the postal code is optional and must be no more than 9 alphanumeric characters long.
                                //Max Allowed: 1 
                                //Length: 1…9
                                //Required: Cond 
                                PostalCode = "41456",
                                //Consignee’s state or province code. Required for US or Canada.
                                //Validation:
                                //If destination is US or CA, then the value must be a valid US State/ Canadian Province code. 
                                //If the country or territory is Ireland, the StateProvinceCode will contain the county.
                                //Max Allowed: 1 
                                //Length: 2…5
                                //Required: Cond 
                                //StateProvinceCode = "DE",

                                //Consignee’s country or territory code.
                                //Validation:
                                //Must be a valid UPS Billing country or territory code. 
                                //For Return Shipment the country or territory code must meet the following conditions: 
                                //1) At least two of the following country or territory codes are the same: ShipTo, ShipFrom, and Shipper. 
                                //2) None of the following country or territory codes are the same and are a member of the EU: ShipTo, ShipFrom, and Shipper.
                                //3) If any of the two following country or territory codes: ShipTo/ ShipFrom/ Shipper are members in EU 
                                //otherwise check if the shipper has Third Country or territory Contract.
                                //Max Allowed: 1 
                                //Length: 2
                                //Required: Yes 
                                CountryCode = "DE"
                            },
                            //Container for Phone Number
                            //Required: Cond
                            Phone = new ShipPhoneType
                            {
                                //Consignee’s phone Number.
                                //Validation:
                                //Required for: UPS Next Day Air® Early service, and when Ship To country or territory is different 
                                //than the ShipFrom country or territory. 
                                //If ShipTo country or territory is US, PR, CA, and VI, the layout is: area code, 7 digit PhoneNumber 
                                //or area code, 7 digit PhoneNumber, 4 digit extension number; number. 
                                //For other country or territory, the layout is: CountryCode, area code, 7 digit number.
                                //Length: 1…15
                                //Required: Yes*
                                Number = "1234567890"
                            }
                        },
                        //UPS service type.
                        //Required: Yes
                        Service = new ServiceType
                        {
                            //Valid values: 01 = Next Day Air 
                            //02 = 2nd Day Air 
                            //03 = Ground 
                            //07 = Express 
                            //08 = Expedited 
                            //11 = UPS Standard 
                            //12 = 3 Day Select 
                            //13 = Next Day Air Saver 
                            //14 = UPS Next Day Air® Early 
                            //17 = UPS Worldwide Economy DDU 
                            //54 = Express Plus
                            //59 = 2nd Day Air A.M. 65 = UPS Saver M2 = First Class Mail M3 = Priority Mail M4 = Expedited MaiI Innovations M5 = Priority Mail Innovations M6 = Economy Mail Innovations
                            //M7 = MaiI Innovations(MI) Returns 
                            //70 = UPS Access Point™ Economy
                            //71 = UPS Worldwide Express Freight Midday 
                            //72 = UPS Worldwide Economy DDP
                            //74 = UPS Express®12:00
                            //82 = UPS Today Standard 
                            //83 = UPS Today Dedicated Courier 
                            //84 = UPS Today Intercity 
                            //85 = UPS Today Express 
                            //86 = UPS Today Express Saver 
                            //96 = UPS Worldwide Express Freight.
                            //Note: 
                            //Only service code 03 is used for Ground Freight Pricing shipments
                            //Validation:
                            //The following Services are not available to return shipment: 13, 59, 82, 83, 84, 85, 86
                            //Max Allowed: 1 
                            //Length: 2
                            //Required: Yes 
                            Code = "08"
                        },
                        //Package Information container.
                        //Validation:
                        //For Return Shipments up to and including 20 packages are allowed. 
                        //US /PR origin return movements are limited to only one package. 
                        //For Mail Innovations shipments only one package is allowed.
                        //Max Allowed: 200
                        //Required: Yes 
                        Package = new PackageType[]
                        {
                            new PackageType
                            {
                                //Container to hold package weight information.
                                //Validation:
                                //Package weight is a required for Ground Freight Pricing shipments
                                //Required: Cond
                                PackageWeight = new PackageWeightType
                                {
                                    //Packages weight. Weight accepted for letters/envelopes.
                                    //Validation:
                                    //Only average package weight is required for Ground Freight Pricing Shipment.
                                    //Max Allowed: 1 
                                    //Length: 1…5
                                    //Required: Yes* 
                                    Weight = "10",
                                    //Container to hold UnitOfMeasurement information for package weight.
                                    //Max Allowed: 1
                                    //Required: Yes*
                                    UnitOfMeasurement= new ShipUnitOfMeasurementType
                                    {
                                        //Package weight unit of measurement code. Valid values: LBS = Pounds KGS = Kilograms 
                                        //OZS = Ounces Unit of Measurement "OZS" is the only valid UOM for some of the Mail Innovations Forward Shipments. 
                                        //Please refer to Appendix for more details regarding the valid combination of Mail Innovation Forward Shipment
                                        //services, Package Type and Unit of Measurement.
                                        //Max Allowed: 1 
                                        //Length: 3
                                        //Required: Yes* 
                                        Code = "KGS"
                                    }
                                },
                                //Packaging container.
                                //Max Allowed: 1
                                //Required: Yes 
                                Packaging = new PackagingType
                                {
                                    //Package types. Values are: 
                                    //01 = UPS Letter 
                                    //02 = Customer Supplied Package 
                                    //03 = Tube 
                                    //04 = PAK 
                                    //21 = UPS Express Box 
                                    //24 = UPS 25KG Box 
                                    //25 = UPS 10KG Box 
                                    //30 = Pallet 
                                    //2a = Small Express Box 
                                    //2b = Medium Express Box 
                                    //2c = Large Express Box 
                                    //56 = Flats 
                                    //57 = Parcels
                                    //58 = BPM 
                                    //59 = First Class 
                                    //60 = Priority 
                                    //61 = Machineables 
                                    //62 = Irregulars 
                                    //63 = Parcel Post 
                                    //64 = BPM Parcel 
                                    //65 = Media Mail 
                                    //66 = BPM Flat 
                                    //67 = Standard Flat. 
                                    //Note: 
                                    //Only packaging type code 02 is applicable to Ground Freight Pricing.
                                    //Validation
                                    //Package type 24, or 25 is only allowed for shipment without return service. 
                                    //Packaging type must be valid for all the following: ShipTo country or territory, ShipFrom country 
                                    //or territory, a shipment going from ShipTo country or territory to ShipFrom country or territory, 
                                    //all Accessorials at both the shipment and package level, and the shipment service type. 
                                    //UPS will not accept raw wood pallets and please refer the UPS packaging guidelines for pallets on UPS.com.
                                    //Max Allowed: 1 
                                    //Length: 2
                                    //Required: Yes 
                                    Code = "02"
                                },
                                //Merchandise description of package.
                                //Validation:
                                //Required for shipment with return service.
                                //Max Allowed: 1 
                                //Length: 1…35
                                //Required: Cond 
                                Description = "Package Description",
                                //Additional Values Start
                                //Dimensions information container. Note: Currently dimensions are not applicable to Ground Freight Pricing.
                                //Validation:
                                //Length + 2*(Width + Height) must be less than or equal to 165 IN or 330 CM.
                                //Required: Cond
                                Dimensions = new DimensionsType
                                {
                                    //Package width.
                                    //Max Allowed: 1 
                                    //Length: 3
                                    //Required: Yes* 
                                    Height = "10",
                                    //Package width.
                                    //Max Allowed: 1 
                                    //Length: 3
                                    //Required: Yes* 
                                    Width = "10",
                                    //Package length. Length must be the longest dimension of the container.
                                    //Validation:
                                    //Valid values are 0 to 108 IN and 0 to 274 CM.
                                    //Max Allowed: 1 
                                    //Length: 3
                                    //Required: Yes* 
                                    Length = "30",
                                    //UnitOfMeasurement container for dimensions.
                                    //Max Allowed: 1
                                    //Required: Yes*
                                    UnitOfMeasurement = new ShipUnitOfMeasurementType
                                    {
                                        //Package dimensions measurement code. 
                                        //Valid codes: IN = Inches CM = Centimeters 00 = Metric Units Of Measurement 01 = English Units of Measurement
                                        //Validation:The unit of measurement must be valid for the Shipper country or territory.
                                        //Max Allowed: 1 
                                        //Length: 2
                                        //Required: Yes* 
                                        Code = "CM"
                                    }
                                },

                                //Additional Values End
                            },
                            new PackageType
                            {
                                PackageWeight = new PackageWeightType
                                {
                                    Weight = "20",
                                    UnitOfMeasurement= new ShipUnitOfMeasurementType { Code = "KGS" }
                                },
                                Packaging = new PackagingType { Code = "02" },
                                Description = "Package Description",
                                //Additional Values Start
                                Dimensions = new DimensionsType
                                {
                                    Height = "10",
                                    Width = "20",
                                    Length = "60",
                                    UnitOfMeasurement = new ShipUnitOfMeasurementType { Code = "CM" }
                                },

                                //Additional Values End
                            }
                        }
                    },
                    //Container used to define the properties required by the user to print and/or display the UPS shipping label.
                    //Validation:
                    //Required for shipment without return service or shipments with PRL return service. 
                    //Required for Electronic Return Label or Electronic Import Control Label shipments with SubVersion greater than or equal to 1707.
                    //Max Allowed: 1
                    //Required: Cond
                    LabelSpecification = new LabelSpecificationType
                    {
                        //Container for the EPL2, ZPL, STARPL or SPL label size.
                        //Validation:
                        //Valid for EPL2, ZPL, STARPL and SPL Labels.
                        //Required: Yes*
                        LabelStockSize = new LabelStockSizeType
                        {
                            //Height of the label image. For IN, use whole inches.
                            //Validation:
                            //For EPL2, ZPL, STARPL and SPL Labels. Only valid values are 6 or 8. 
                            //Note: 
                            //Label Image will only scale up to 4 X 6, even when requesting 4 X 8.
                            //Max Allowed: 1 
                            //Length: 1…3
                            //Required: Yes* 
                            Height = "6",
                            //Width of the label image. For IN, use whole inches.
                            //Validation:
                            //For EPL2, ZPL, STARPL and SPL Labels. Valid value is 4. 
                            //Note: 
                            //Label Image will only scale up to 4 X 6, even when requesting 4 X 8.
                            //Max Allowed: 1 
                            //Length: 1…3
                            //Required: Yes* 
                            Width = "4"
                        },
                        //LabelImageFormat Container.
                        //Max Allowed: 1
                        //Required: Yes* 
                        LabelImageFormat = new LabelImageFormatType
                        {
                            //Label image code determines the format in which Labels are to be generated. 
                            //For EPL2 formatted Labels use EPL, for SPL formatted Labels use SPL, for ZPL formatted Labels use ZPL, 
                            //for image formats use GIF, for PNG formatted Labels use PNG and for Star Printer format formatted Labels use STARPL.
                            //Validation
                            //For shipments without return service the valid value is GIF, PNG, ZPL, EPL and SPL. For shipments with PRL return service, 
                            //the valid values are EPL, ZPL, SPL, STARPL, PNG and GIF. For Mail Innovations forward shipments STARPL is not supported.
                            //Max Allowed: 1 
                            //Length: 4
                            //Required: Yes* 
                            Code = "GIF"
                        }
                    }
                };

                return shipmentRequest;
            }
        }
        public async Task<IActionResult> ConfirmShipmentAsync()
        {
            INativeShipConfirmResponse response = null;
            INativeShipAcceptResponse acceptResponse = null;
            try
            {
                IUPSConfiguration configuration = new UPSConfiguration
                {
                    Authentication = new Authentication
                    {
                        AccessKey = _config?.Authentication?.AccessKey,
                        AccountNumber = _config?.Authentication?.AccountNumber,
                        Password = _config?.Authentication?.Password,
                        UserName = _config?.Authentication?.UserName,
                        CustomerContext = _config?.Authentication?.CustomerContext,
                    }
                };
                response = await _shipmentService.ProcessShipConfirmAsync(ShipConfirmRequest, configuration);
                IShipAcceptRequest request = ShipAcceptRequest;
                request.ShipmentDigest = response?.ShipmentDigest;
                acceptResponse = await _shipmentService.ProcessShipAcceptAsync(request, configuration);

                var file = @"E:\UpsXML\UPSobject-26Jun2020-053730.xml";
                using (StreamReader sr = new StreamReader(file))
                {
                    // Read the stream to a string, and write the string to the console.
                    string requestText = sr.ReadToEnd();
                    request.ShipmentDigest = BaseService.Base64Encode(requestText);
                    acceptResponse = await _shipmentService.ProcessShipAcceptAsync(request, configuration);
                }
            }
            catch (Exception ex) { }
            return View();
        }
        private IShipConfirmRequest ShipConfirmRequest
        {
            get
            {
                IShipConfirmRequest shipmentRequest = new ShipConfirmRequest()
                {
                    Request = new RequestType()
                    {
                        RequestOption = new string[] { "validate" }
                    },
                    Shipment = new ShipmentType
                    {
                        Description = "Ship webservice example",
                        Shipper = new ShipperType
                        {
                            ShipperNumber = _config?.ShipperConfiguration?.Shipper?.ShipperNumber,
                            Address = new ShipAddressType
                            {
                                AddressLine = new string[] { "D25, Noida Setor 24" },
                                City = "Noida",
                                PostalCode = "201301",
                                StateProvinceCode = "UP",
                                CountryCode = "IN"
                            },
                            Name = "ABC Associates",
                            AttentionName = "ABC Associates",
                            Phone = new ShipPhoneType { Number = "1234567890" }
                        },
                        PaymentInformation = new PaymentInfoType
                        {
                            ShipmentCharge = new ShipmentChargeType[]
                            {
                                new ShipmentChargeType
                                {
                                    BillShipper = new BillShipperType
                                    {
                                        AccountNumber = _config?.PaymentInfoConfiguration?.PaymentInformation?.ShipmentCharge?.FirstOrDefault()?.BillShipper?.AccountNumber
                                    },
                                    Type = "01",

                                }
                            }
                        },
                        ShipFrom = new ShipFromType
                        {
                            AttentionName = "Mr.ABC",
                            Name = "ABC Associates",
                            Address = new ShipAddressType
                            {
                                AddressLine = new string[] { "D25, Noida Setor 24" },
                                City = "Noida",
                                PostalCode = "201301",
                                StateProvinceCode = "UP",
                                CountryCode = "IN"
                            }
                        },
                        ShipTo = new ShipToType
                        {
                            AttentionName = "DEF",
                            Name = "DEF Associates",
                            Address = new ShipToAddressType
                            {
                                AddressLine = new string[] { "GOERLITZER STR.1" },
                                City = "Neuss",
                                PostalCode = "41456",
                                //StateProvinceCode = "DE",
                                CountryCode = "DE"
                            },
                            Phone = new ShipPhoneType { Number = "1234567890" }
                        },
                        Service = new ServiceType
                        {
                            Code = "08"
                        },

                        Package = new PackageType[]
                        {
                            new PackageType
                            {
                                PackageWeight = new PackageWeightType
                                {
                                    Weight = "10",
                                    UnitOfMeasurement= new ShipUnitOfMeasurementType { Code = "KGS" }
                                },
                                Packaging = new PackagingType { Code = "02" },
                                Description = "Package Description",
                                //Additional Values Start
                                //Dimensions = new DimensionsType
                                //{
                                //    Height = "10",
                                //    Width = "10",
                                //    Length = "30",
                                //    UnitOfMeasurement = new ShipUnitOfMeasurementType { Code = "CM" }
                                //},

                                //Additional Values End
                            },
                            new PackageType
                            {
                                PackageWeight = new PackageWeightType
                                {
                                    Weight = "20",
                                    UnitOfMeasurement= new ShipUnitOfMeasurementType { Code = "KGS" }
                                },
                                Packaging = new PackagingType { Code = "02" },
                                Description = "Package Description",
                                //Additional Values Start
                                //Dimensions = new DimensionsType
                                //{
                                //    Height = "10",
                                //    Width = "10",
                                //    Length = "30",
                                //    UnitOfMeasurement = new ShipUnitOfMeasurementType { Code = "CM" }
                                //},

                                //Additional Values End
                            }
                        }
                    },
                    LabelSpecification = new LabelSpecificationType
                    {
                        LabelStockSize = new LabelStockSizeType
                        {
                            Height = "6",
                            Width = "4"
                        },
                        LabelImageFormat = new LabelImageFormatType { Code = "GIF" }
                    }
                };

                return shipmentRequest;
            }
        }
        private IShipAcceptRequest ShipAcceptRequest
        {
            get
            {
                IShipAcceptRequest reequest = new ShipAcceptRequest
                {
                    Request = new RequestType
                    {
                        RequestOption = new string[] { "validate" }
                    }
                };
                return reequest;
            }
        }
        public async Task<IActionResult> ProcessVoidAsync()
        {
            INativeVoidShipmentResponse response = null;
            try
            {
                //var createResponse = await _packageShipmentService.ProcessShipmentAsync(ShipmentRequest, null);
                var request = new VoidShipmentRequest
                {
                    VoidShipment = new VoidShipmentRequestVoidShipment
                    {
                        ShipmentIdentificationNumber = "1Z2220060290530202", //createResponse?.MasterTrackingReferenceNumber,
                        TrackingNumber = new string[] { "1Z2220060293874210", "1Z2220060292634221" }
                    }
                };
                response = await _voidShipmentService.ProcessVoidAsync(request);
            }
            catch (Exception ex) { }
            return View();
        }
        public async Task<IActionResult> ProcessPickupCreationAsync()
        {
            INativePickupCreationResponse response = null;
            try
            {
                IUPSConfiguration configuration = new UPSConfiguration
                {
                    Authentication = new Authentication
                    {
                        AccessKey = _config?.Authentication?.AccessKey,
                        AccountNumber = _config?.Authentication?.AccountNumber,
                        Password = _config?.Authentication?.Password,
                        UserName = _config?.Authentication?.UserName,
                        CustomerContext = _config?.Authentication?.CustomerContext,
                    }
                };
                response = await _pickupService.ProcessPickupCreationAsync(PickupCreationRequest, configuration);
            }
            catch (Exception ex) { }
            return View();
        }
        private IPickupCreationRequest PickupCreationRequest
        {
            get
            {
                IPickupCreationRequest request = null;

                request = new PickupCreationRequest
                {
                    //Common element for all services
                    //Required: Yes
                    //Request = new RequestType(),
                    //Indicates whether to rate the on-call pickup or not. Valid values: Y = Rate this pickup N = Do not rate this pickup (default)
                    //Required: Yes
                    RatePickupIndicator = "Y",
                    //On-call pickup shipper or requestor information.
                    //Must provide when choose to pay the pickup by shipper account number.
                    //It is optional if the shipper chooses any other payment method. However, it is highly recommended to provide if available.
                    //Required: Cond
                    Shipper = new PickupShipperType
                    {
                        //Required: Cond
                        //Shipper account information.
                        //Must provide when choose to pay the pickup by shipper account number.
                        Account = new AccountType
                        {
                            //Country or Territory code as defined by ISO-3166. Refer to Country or Territory Codes in the Appendix for valid values.
                            //Required: Yes
                            AccountCountryCode = "IN",
                            //UPS account number.
                            //Shipper's (requester of the pickup) UPS account number
                            //Required: Yes
                            AccountNumber = _config?.ShipperConfiguration?.Shipper?.ShipperNumber
                        }
                    },
                    //The container of desired pickup date
                    //Required: Yes
                    PickupDateInfo = new PickupDateInfoType
                    {
                        //Pickup location's local close time.
                        //- User provided Close Time must be later than the Earliest Allowed Customer Close Time.
                        //- Earliest Allowed Customer Close Time is defined by UPS pickup operation system.
                        //- CloseTime minus ReadyTime must be greater than the LeadTime.
                        //- LeadTime is determined by UPS pickup operation system. LeadTime is the minimum amount of time UPS requires between customer’s request for a pickup and driver arriving at the location for the pickup.
                        //Format: HHmm
                        //Hour: 0 - 23 Minute: 0 - 59
                        //Required: Yes
                        CloseTime = DateTime.Now.AddHours(5).ToString("HHmm"),
                        //Local pickup date of the location.
                        //Format: yyyyMMdd
                        //yyyy = Year Appliable
                        //MM = 01– 12
                        //dd = 01–31
                        //Required: Yes
                        PickupDate = DateTime.Today.AddDays(1).ToString("yyyyMMdd"),
                        //Pickup location's local ready time. ReadyTime means the time when your shipment(s) can be ready for UPS to pick up. 
                        //- User provided ReadyTime must be earlier than CallByTime. 
                        //- CallByTime is determined by UPS pickup operation system. CallByTime is the Latest time a Customer can call UPS or self-serve on UPS.com and complete a Pickup Request and UPS can still make the Pickup service request. 
                        //- If ReadyTime is earlier than current local time, UPS uses the current local time as the ReadyTime.
                        //Format: HHmm
                        //Hour: 0 - 23 Minute: 0 - 59
                        //Required: Yes
                        ReadyTime = DateTime.Now.ToString("HHmm")
                    },
                    //The container of pickup address.
                    //Required: Yes
                    PickupAddress = new PickupAddressType
                    {
                        //Detailed street address. For Jan. 2010 release, only one AddressLine is allowed
                        //Length: 1..73
                        //Required: Yes                        
                        AddressLine = new string[] { "D25, Noida Setor 24" },
                        //City or equivalent
                        //Length: 1..50
                        //Required: Yes
                        City = "Noida",
                        //Company name
                        //Required: Yes
                        CompanyName = "Pickup Proxy",
                        //Name of contact person
                        //Required: Yes
                        ContactName = "Pickup Proxy",
                        //The pickup country or territory code as defined by ISO-3166. Refer to Country or Territory Codes in the Appendix for valid values.
                        //Length: 2
                        //Required: Yes
                        CountryCode = "IN",
                        //Length: 1..3
                        //Required: Yes
                        Floor = "2",
                        //State or province for postal countries or territories; county for Ireland (IE) and district code for Hong Kong SAR, China (HK)
                        //Length: 1..50
                        //Required: Cond
                        StateProvince = "UP",
                        //Contact telephone number.
                        //Required: Yes
                        Phone = new PhoneType
                        {
                            //Phone extension
                            //Length: 1..10
                            //Required: No
                            Extension = "120",
                            //Phone number
                            //Length: 1..25
                            //Required: Yes
                            Number = "6785851399"
                        },
                        //Postal code or equivalent for postal countries or territories.
                        //Length: 1..8
                        //Required: Cond
                        PostalCode = "201301",
                        //The specific spot to pickup at the address.
                        //Length: 1..11
                        //Required: No
                        PickupPoint = "Lobby",
                        //Indicates if the pickup address is commercial or residential. Valid values: Y = Residential address N = Non-residential (Commercial) address (default)
                        //Length: 1
                        //Required: Yes
                        ResidentialIndicator = "Y"
                    },
                    //Indicates if pickup address is a different address than that specified in a customer's profile. 
                    //Valid values: Y = Alternate address N = Original pickup address (default)
                    //Length: 1
                    //Required: Yes
                    AlternateAddressIndicator = "N",
                    //The container providing the information about how many items should be picked up. 
                    //The total number of return and forwarding packages cannot exceed 9,999.
                    //Required: Yes
                    PickupPiece = new PickupPieceType[]
                    {
                        new PickupPieceType
                        {
                            //Container type. Valid values: 01 = PACKAGE 02 = UPS LETTER 03 = PALLET Note: 03 is used for only WWEF services
                            //Length: 2
                            //Required: Yes
                            ContainerCode = "01",
                            //The destination country or territory code as defined by ISO-3166. 
                            //Refer to Country or Territory Codes in the Appendix for valid values.
                            //Length: 2
                            //Required: Yes
                            DestinationCountryCode = "US",
                            //Number of pieces to be picked up. Max per service: 999
                            //Length: 1..3
                            //Required: Yes
                            Quantity = "27",
                            //Refer to Service Codes in the Appendix for valid values.
                            //Length: 3
                            //Required: Yes
                            ServiceCode = "002"
                        }
                    },
                    //Container for the total weight of all the items.
                    //Required: No
                    TotalWeight = new PickupWeightType
                    {
                        //The code representing the unit of measurement associated with the package. LBS = Pounds KGS = Kilograms
                        //Length: 3
                        //Required: Yes
                        UnitOfMeasurement = "LBS",
                        //The weight of the package. One decimal digit is allowed. Example: 10.9
                        //Length: 6
                        //Required: Yes
                        Weight = "2.0"
                    },
                    //Indicates if at least any package is over 70 lbs or 32 kgs. Valid values: Y = Over weight N = Not over weight (default)
                    OverweightIndicator = "N",
                    //The payment method to pay for this on call pickup. 00 = No payment needed 01 = Pay by shipper account 03 = Pay by charge card 04 = Pay by 1Z tracking number 05 = Pay by check or money order 06 = Cash(applicable only for these countries or territories - BE,FR,DE,IT,MX,NL,PL,ES,GB,CZ,HU,FI,NO) 07=Pay by PayPal
                    //For countries or territories and (or) zip codes where pickup is free of charge, please submit 00, means no payment needed as payment method.
                    //- If 01, 09, or 10 is the payment method, then ShipperAccountNumber and ShipperAccount CountryCode must be provided.
                    //- If 03 is selected, then CreditCard information should be provided.
                    //- If 04 is selected, then the shipper agreed to pay for the pickup packages.
                    //- If 05 is selected, then the shipper will pay for the pickup packages with a check or money order.
                    // Required: Yes
                    PaymentMethod = "01",
                    //Special handling instruction from the customer.
                    //Required: No
                    SpecialInstruction = ".Net Sample code for Pickup Client"
                };

                //String[] returnTrackingNumber = { "Your return tracking number 1", "Your return tracking number 2", "Your return tracking number 3" };
                //pickupCreationRequest.ReturnTrackingNumber = returnTrackingNumber;

                return request;
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> ProcessPickupGetServiceCenterFacilitiesAsync()
        {
            INativePickupGetServiceCenterFacilitiesResponse response = null;
            try
            {
                response = await _pickupService.ProcessPickupGetServiceCenterFacilitiesAsync(PickupGetServiceCenterFacilitiesRequest);
            }
            catch (Exception ex) { }
            return View();
        }
        private IPickupGetServiceCenterFacilitiesRequest PickupGetServiceCenterFacilitiesRequest
        {
            get
            {
                IPickupGetServiceCenterFacilitiesRequest request = null;

                request = new PickupGetServiceCenterFacilitiesRequest
                {
                    //Request = new RequestType(),
                    //Pickup Piece Container.
                    //Max Allowed: 1
                    //Required: Yes
                    PickupPiece = new PickupPieceServiceType[]
                    {
                        new PickupPieceServiceType
                        {
                            //The service code.Required for WWEF shipments.
                            //Max Allowed: 1 
                            //Length: 3
                            //Required: Yes 
                            ServiceCode = "096",//096
                            //The service code.Required for WWEF shipments.
                            //Max Allowed: 1
                            //Required: Yes 
                            ContainerCode = "03",
                            DestinationCountryCode ="US",
                            Quantity="1"
                        }
                    },
                    //Indicates the address of the shipper to allow for the nearest Drop off facility Search.
                    //Conditionally required for drop off location search.
                    //Required: Cond
                    OriginAddress = new OriginAddressType
                    {
                        //Indicates the address of the shipper to allow for the nearest Drop off facility Search.
                        //Conditionally required if proximitySearchIndicator is present.
                        //Length: 1.....73
                        //Required: Cond
                        StreetAddress = null,
                        //Indicates the address of the shipper to allow for the nearest Drop off facility Search
                        //Conditionally required if proximitySearchIndicator is present.
                        //Length: 1...50
                        //Required: Cond 
                        City = "Los Angeles",//"Noida",
                        //Indicates the address of the shipper to allow for the nearest Drop off facility Search
                        //Conditionally required if proximitySearchIndicator is present and if country or territory is US/CA/IE/HK.
                        //Length: 1...50
                        //Required: Cond 
                        StateProvince = "CA",
                        //Indicates the address of the shipper to allow for the nearest Drop off facility Search
                        //Conditionally required if proximitySearchIndicator is present and if country or territory has postal code.
                        //It does not apply to non-postal countries or territories such as IE and HK.
                        //Length: 1...8
                        //Required: Cond 
                        PostalCode = "90210",
                        //Indicates the address of the shipper to allow for the nearest Drop off facility Search
                        //Length: 2
                        //Required: Yes 
                        CountryCode = "US",
                        //Origin Search Criteria Container
                        //Required if Proximity SearchIndicator is present.
                        //Max Allowed: 1
                        //Required: Cond
                        //OriginSearchCriteria = new OriginSearchCriteriaType
                        //{
                        //    //Search Request range. Valied values: 1 to 200 Default: 200
                        //    //Length: 3
                        //    //Required: No 
                        //    SearchRadius = "100",
                        //    //Unit of Measure
                        //    //Required if ProximitySearchIndicator is present. Example: MI or KM
                        //    //Length: 2
                        //    //Required: Yes* 
                        //    DistanceUnitOfMeasure = "KM",
                        //    //Maximum Number of locations. Valied values: 1 to 100 Default: 100
                        //    //Length: 3
                        //    //Required: No 
                        //    MaximumLocation = "10"
                        //}
                    },
                    //DestinationAddress container.
                    //Conditionally required for pickup location search.
                    //Required: Cond
                    DestinationAddress = new DestinationAddressType
                    {
                        //Indicates the address of the consignee to allow for the nearest Pickup facility Search.
                        //It is required for non- postal country Ireland (IE).
                        //Length: 1..50
                        //Required: Cond 
                        City = "Neuss",
                        //Indicates the address of the consignee to allow for the nearest Pickup facility Search 
                        //1 = District code for Hong Kong SAR,China(HK)
                        //2 = County for Ireland(IE)
                        //3 = State or province for all the postal countries or territories.
                        //Required for non-postal countries or territories including HK and IE.
                        //Length: 1..50
                        //Required: Cond 
                        StateProvince = "DE",
                        //Indicates the address of the consignee to allow for the nearest Pickup facility Search.
                        //It does not apply to non-postal countries or territories. Example: IE and HK.
                        //Length: 1..8
                        //Required: Cond 
                        PostalCode = "41456",
                        //The pickup country or territory code as defined by ISO-3166.
                        //Refer to Country or Territory Codes in the Appendix for valid values.
                        //Length: 2
                        //Required: Yes 
                        CountryCode = "US"
                    },
                    //Origin Country or Territory Locale.
                    //Locale should be Origin Country or Territory.
                    // Example: en_US.
                    //The Last 50 instruction will be send based on this locale.
                    //Locale is required if PoximityIndicator is present for Drop Off facilities.
                    //Length: 5
                    //Required: Yes* 
                    Locale = "en_US",
                    //Proximity Indicator.
                    //Indicates the user requested the proximity search for UPS Worldwide Express Freight and 
                    //UPS Worldwide Express Freight Midday locations for the origin address and/or the airport code, 
                    //and the sort code for destination address.
                    //Length: 0
                    //Required: No 
                    ProximitySearchIndicator = null
                };
                return request;
            }
        }
        public async Task<IActionResult> ProcessPickupCancelAsync()
        {
            INativePickupCancelResponse response = null;
            try
            {
                var createPickupResponse = await _pickupService.ProcessPickupCreationAsync(PickupCreationRequest);
                var request = PickupCancelRequest;
                //request.PRN = createPickupResponse?.PickupConfirmationNumber;
                response = await _pickupService.ProcessPickupCancelAsync(request);
            }
            catch (Exception ex) { }
            return View();
        }
        private IPickupCancelRequest PickupCancelRequest
        {
            get
            {
                IPickupCancelRequest request = null;

                request = new PickupCancelRequest
                {
                    //The pickup request number (PRN) generated by UPS pickup system. Required if CancelBy = 02
                    //Pickup type=“01” (On-Call Pickup) | PRN =“2929AONCALL”, StatusCode =“001”, Description=“Received at dispatch”, etc.
                    //Pickup type=“02”(Smart Pickup)| PRN=“AA29A0A3GWN”, StatusCode=“003”, Description=“Order successfullycompleted”, etc.
                    //Pickup type=“03” | Both Smart Pickup and On-Call Pickup, will return all of the data listed above for types 01 and 02.
                    PRN = "AA29A0A3GWN", // "AA29A0A3GWN"
                    //Cancel pickup by Pickup Request Number (PRN).
                    //01 = Account Number
                    //02 = PRN
                    CancelBy = "02"
                };
                return request;
            }
        }
        /// <summary>
        /// Pickup type=“01” (On-Call Pickup) | PRN =“2929AONCALL”, StatusCode =“001”, Description=“Received at dispatch”, etc.
        /// Pickup type=“02”(Smart Pickup) | PRN=“AA29A0A3GWN”, StatusCode=“003”, Description=“Order successfullycompleted”, etc.
        /// Pickup type=“03” | Both Smart Pickup and On-Call Pickup, will return all of the data listed above for types 01 and 02. 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> ProcessPickupPendingStatusAsync()
        {
            INativePickupPendingStatusResponse response = null;
            try
            {
                //var createPickupResponse = await _pickupService.ProcessPickupCreationAsync(PickupCreationRequest);
                response = await _pickupService.ProcessPickupPendingStatusAsync(PickupPendingStatusRequest);
            }
            catch (Exception ex) { }
            return View();
        }
        private IPickupPendingStatusRequest PickupPendingStatusRequest
        {
            get
            {
                IPickupPendingStatusRequest request = null;

                request = new PickupPendingStatusRequest
                {
                    PickupType = "03",
                    AccountNumber = _config?.ShipperConfiguration?.Shipper?.ShipperNumber
                };
                return request;
            }
        }
        public async Task<IActionResult> ProcessPickupRateAsync()
        {
            INativePickupRateResponse response = null;
            try
            {
                //var createPickupResponse = await _pickupService.ProcessPickupCreationAsync(PickupCreationRequest);
                response = await _pickupService.ProcessPickupRateAsync(PickupRateRequest);
            }
            catch (Exception ex) { }
            return View();
        }
        private IPickupRateRequest PickupRateRequest
        {
            get
            {
                IPickupRateRequest request = null;

                request = new PickupRateRequest
                {
                    //Shipper account information.
                    //Required: No
                    ShipperAccount = new ShipperAccountType
                    {
                        //UPS account number.
                        //Shipper's (requester of the pickup) UPS account number.
                        //Length: 6 or 10
                        //Required: Yes*
                        AccountNumber = _config?.ShipperConfiguration?.Shipper?.ShipperNumber,
                        //Country or Territory code as defined by ISO-3166.
                        //Refer to Country or Territory Codes in the Appendix for valid values.
                        //Length: 2
                        //Required: Yes*
                        AccountCountryCode = _config?.ShipperConfiguration?.Shipper?.Address?.CountryCode
                    },
                    //The address to pick up the packages
                    //Required: Yes
                    PickupAddress = new PickupRateAddressType
                    {
                        //Detailed street address.
                        //Beginning Jan. 2010 release, only one AddressLine is allowed.
                        //Length: 1..73
                        //Required: No
                        AddressLine = _config?.ShipperConfiguration?.Shipper?.Address?.AddressLine,
                        //City or equivalent
                        //Length: 1..50
                        //Required: Yes
                        City = _config?.ShipperConfiguration?.Shipper?.Address?.City,
                        //Upper-case two-char long country or territory code as defined by ISO-3166. Refer to Country or Territory Codes in the Appendix for valid values.
                        //State province code or equivalent
                        //Length: 2
                        //Required: Yes
                        CountryCode = _config?.ShipperConfiguration?.Shipper?.Address?.CountryCode,
                        //Postal code for countries or territories with postal codes.
                        //Length: 1..8
                        //Required: Yes
                        PostalCode = _config?.ShipperConfiguration?.Shipper?.Address?.PostalCode,
                        //State province code or equivalent
                        //Length: 1..50
                        //Required: Yes
                        StateProvince = _config?.ShipperConfiguration?.Shipper?.Address?.StateProvinceCode,
                        //Indicates if the pickup address is commercial or residential. 
                        //Valid values: Y = Residential address N = Non-residential (Commercial) address (default)
                        //Length: 1
                        //Required: Yes
                        ResidentialIndicator = "N"
                    },
                    //Indicates if the pickup address is a different address than that specified in customer's profile.
                    //Valid values: Y = Alternate address N = Original pickup address (default)
                    //Length: 1
                    //Required: Yes
                    AlternateAddressIndicator = "",
                    //Indicates the pickup timeframe. 01 = Same-Day Pickup 02 = Future-Day Pickup 03 = A Specific-Day Pickup
                    //If 03 is selected,
                    //then PickupDate,
                    //EarliestReadyTime,
                    //and LatestClosetime must be specified.
                    //Length: 2
                    //Required: Yes
                    ServiceDateOption = "03",
                    //Required if the ServiceDateOption is: 03 A Specific-Day Pickup.
                    PickupDateInfo = new PickupDateInfoType
                    {
                        //The latest local close time. Format: HHmm Hour: 0-23 Minute: 0-59
                        //Length: 4
                        //Required: Yes
                        CloseTime = "2200",
                        //The earliest local ready Time. Format: HHmm Hour: 0-23 Minute: 0-59
                        //Length: 4
                        //Required: Yes
                        ReadyTime = "1800",
                        //The specific local pickup date. Format: yyyyMMdd yyyy = Year Applicable MM = 01–12 dd = 01–31
                        //Length: 8
                        //Required: Yes
                        PickupDate = DateTime.Today.AddDays(1).ToString("yyyyMMdd")
                    }
                };
                return request;
            }
        }
        public async Task<IActionResult> ProcessPickupGetPoliticalDivision1ListAsync()
        {
            INativePickupGetPoliticalDivision1ListResponse response = null;
            try
            {
                //var createPickupResponse = await _pickupService.ProcessPickupCreationAsync(PickupCreationRequest);
                response = await _pickupService.ProcessPickupGetPoliticalDivision1ListAsync(PickupGetPoliticalDivision1ListRequest);
            }
            catch (Exception ex) { }
            return View();
        }
        private IPickupGetPoliticalDivision1ListRequest PickupGetPoliticalDivision1ListRequest
        {
            get
            {
                IPickupGetPoliticalDivision1ListRequest request = null;

                request = new PickupGetPoliticalDivision1ListRequest
                {
                    CountryCode = "IN"
                };
                return request;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> ProcesslabelRecoveryAsync()
        {
            INativeLabelRecoveryResponse response = null;
            try
            {
                response = await _labelRecoveryService.ProcessLabelRecoveryAsync(LabelRecoveryRequest);
            }
            catch (Exception ex) { }
            return View();
        }
        private ILabelRecoveryRequest LabelRecoveryRequest
        {
            get
            {
                ILabelRecoveryRequest request = null;

                request = new LabelRecoveryRequest
                {
                    Request = new RequestType(),
                    TrackingNumber = "1Z12345E8791315509",//"1ZT60T006793687716",
                    LabelSpecification = new LabelSpecificationType
                    {
                        LabelImageFormat = new LabelImageFormatType { Code = "GIF" }
                    }
                };
                return request;
            }
        }
    }
}
