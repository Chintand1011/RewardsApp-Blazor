﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsRewardsApp.Shared.Models
{
	[Table("tblstore")]
	public class StoreTbl
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StoreID { get; set; }
		public int DatabaseID { get; set; }
		public int? LEID { get; set; }
		public string StoreName { get; set; }
		public int? RegisterModelID { get; set; }
		public int Sam4ParentStoreID { get; set; }
		public short? ComCashLocationNo { get; set; }
		public int? ComCashLastInvoiceNo { get; set; }
		public DateTime? ComCashLastInvoiceDate { get; set; }
		public string? AcctgSprdsheets { get; set; }
		public string NaxmlVersion { get; set; }
		public string? IPPort { get; set; }
		public string? IPAddress { get; set; }
		public string? IPAddressInternal { get; set; }
		public int? PhysicalEntityId { get; set; }
		public int? NucleusVersionID { get; set; }
		public string? EnhancedHandheld { get; set; }
		public string? InvoiceInput { get; set; }
		public string? GetSales { get; set; }
		public string? SendData { get; set; }
		public string? ComPort { get; set; }
		public string? LocalAccount { get; set; }
		public string? LocalSynch { get; set; }
		public int? LocalServerID { get; set; }
		public string? Notes { get; set; }
		public string? SoftwareSet { get; set; }
		public int? OutputID { get; set; }
		public string? ContactName { get; set; }
		public string? Address1 { get; set; }
		public string? Address2 { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
		public string? Zip5 { get; set; }
		public string? Zip4 { get; set; }
		public string? AreaCode { get; set; }
		public string? Prefix { get; set; }
		public string? Suffix { get; set; }
		public string? CellPhone { get; set; }
		public string? StoreBlurbForCoupons { get; set; }
		public string? Login { get; set; }
		public string? EMailAddress { get; set; }
		public string? Longitude { get; set; }
		public string? Latitude { get; set; }
		public int? VendorID { get; set; }
		public string? VendorAcctNum { get; set; }
		public int? StationNo { get; set; }
		public string? GetInvoices { get; set; }
		public string? DefaultEDIServer { get; set; }
		public string? Active { get; set; }
		public string? TrulyActiveIETest { get; set; }
		public string? EPB { get; set; }
		public string? RealTime { get; set; }
		public string? Loyalty { get; set; }
		public string? EPB_IRI { get; set; }
		public string? FirstLoyaltyCardNumber { get; set; }
		public string? LastLoyaltyCardNumber { get; set; }
		public string? FirstMagneticStripNumber { get; set; }
		public string? LastMagneticStripNumber { get; set; }
		public string? StoreWebSiteAddress { get; set; }
		public string? LoyaltyEMailAddress { get; set; }
		public DateTime? LastSalesDownload { get; set; }
		public DateTime? LastPriceChange { get; set; }
		public int? PriceBookID { get; set; }
		public string? RegisterIP { get; set; }
		public string? StationID { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public string? LoyaltyHouseAccounts { get; set; }
		public string? GetSalesOnce { get; set; }
		public string? GetPLUs { get; set; }
		public int? PLURows { get; set; }
		public decimal? AllowableVariance { get; set; }
		public DateTime? DateModified { get; set; }
		public int? EmployeeID_ModifiedBy { get; set; }
		public DateTime? DateEntered { get; set; }
		public int? EmployeeId_EnteredBy { get; set; }
		public string? RegisterUserName { get; set; }
		public string? RegisterPassword { get; set; }
		public int ApplicationTypeId { get; set; }
		public int? NumberOfShifts { get; set; }
		public string? UpdateRetailPricesOnInvoiceReceipt { get; set; }
		public string? UpdateOnHandOnInvoiceReceipt { get; set; }
		public int? SoftwareSetID { get; set; }
		public string? UpdateVendorCostOnInvoiceReceipt { get; set; }
		public string? InProcess { get; set; }
		public string? InProcessNotes { get; set; }
		public string? UseLinkedItems { get; set; }
		public string? UseShiftSales { get; set; }
		public int? RequestedPeriodNumber { get; set; }
		public string? SalesTaxString { get; set; }
		public string? MealTaxString { get; set; }
		public string? PhoneNumber { get; set; }
		public string? GetSales_Base { get; set; }
		public string? PLUNotes { get; set; }
		public string? SalesNotes { get; set; }
		public decimal? FuelEPAAllowableVariance { get; set; }
		public string? StoreNumber { get; set; }
		public string? DataServer { get; set; }
		public string? ReportServer { get; set; }
		public string? OutboundConnection { get; set; }
		public string? ExternalIPAddress { get; set; }
		public decimal? CCProcessingPercent { get; set; }
		public string? EMail1 { get; set; }
		public string? EMail2 { get; set; }
		public string? EMail3 { get; set; }
		public string? ShowTips1 { get; set; }
		public int? RequestedPeriodNumberToCollect { get; set; }
		public string? GetLogFiles { get; set; }
		public string? GetConfig { get; set; }
		public string? ReStartSE { get; set; }
		public DateTime ReStartSELastDate { get; set; }
		public int? RequestedPeriodNumberForIRI { get; set; }
		public string? SendSalesFiles { get; set; }
		public string? ProcessSalesFiles { get; set; }
		public string? ConversionEMail { get; set; }
		public string? Telephone { get; set; }
		public string? UseSapphire14DigitSKUs { get; set; }
		public string? NetworkUserName { get; set; }
		public string? NetworkPassword { get; set; }
		public DateTime? EquipmentShippedDate { get; set; }
		public int? EquipmentShippedBy { get; set; }
		public string? EquipmentShippedNotes { get; set; }
		public int? EquipmentShippedScheduledBy { get; set; }
		public DateTime? EquipmentShippedDateScheduled { get; set; }
		public DateTime? ConnectivityDate { get; set; }
		public int? ConnectivityBy { get; set; }
		public string? ConnectivityNotes { get; set; }
		public int? ConnectivityScheduledBy { get; set; }
		public DateTime? ConnectivityDateScheduled { get; set; }
		public DateTime? ConfigDownloadedDate { get; set; }
		public int? ConfigDownloadedBy { get; set; }
		public string? ConfigDownloadedNotes { get; set; }
		public int? ConfigDownloadedScheduledBy { get; set; }
		public DateTime? ConfigDownloadedDateScheduled { get; set; }
		public DateTime? DatabaseSetupDate { get; set; }
		public int? DatabaseSetupBy { get; set; }
		public string? DatabaseSetupNotes { get; set; }
		public int? DatabaseSetupScheduledBy { get; set; }
		public DateTime? DatabaseSetupDAteScheduled { get; set; }
		public DateTime? EDIMailBoxSetupDate { get; set; }
		public int? EDIMailBoxSetupBy { get; set; }
		public string? EDIMailBoxSetupNotes { get; set; }
		public int? EDIMailBoxSetupScheduledBy { get; set; }
		public DateTime? EDIMailBoxSetupDateScheduled { get; set; }
		public DateTime? VelocityReportsImportedDate { get; set; }
		public int? VelocityReportsImportedBy { get; set; }
		public string? VelocityReportsImportedNotes { get; set; }
		public int? VelocityReportsImportedScheduledBy { get; set; }
		public DateTime? VelocityReportsImportedDateScheduled { get; set; }
		public DateTime? InvoicesCheckedDate { get; set; }
		public int? InvoicesCheckedBy { get; set; }
		public string? InvoicesCheckedByNotes { get; set; }
		public int? InvoicesCheckedByScheduledBy { get; set; }
		public DateTime? InvoicesCheckedByDateScheduled { get; set; }
		public DateTime? SalesImportedDate { get; set; }
		public int? SalesImportedBy { get; set; }
		public string? SalesImportedNotes { get; set; }
		public int? SalesImportedScheduledBy { get; set; }
		public DateTime? SalesImportedDateScheduled { get; set; }
		public DateTime? ItemChangedAndSentDate { get; set; }
		public int? ItemChangedAndSentBy { get; set; }
		public string? ItemChangedAndSentNotes { get; set; }
		public int? ItemChangedAndSentScheduledBy { get; set; }
		public DateTime? ItemChangedAndSentDateScheduled { get; set; }
		public DateTime? SiteReadyForTrainingDate { get; set; }
		public int? SiteReadyForTrainingBy { get; set; }
		public string? SiteReadyForTrainingDateNotes { get; set; }
		public int? SiteReadyForTrainingDateScheduledBy { get; set; }
		public DateTime? SiteReadyForTrainingDateDateScheduled { get; set; }
		public DateTime? CustomerTrainingScheduledDate { get; set; }
		public int? CustomerTrainingScheduledBy { get; set; }
		public string? CustomerTrainingScheduledNotes { get; set; }
		public int? CustomerTrainingScheduledScheduledBy { get; set; }
		public DateTime? CustomerTrainingScheduledDateScheduled { get; set; }
		public DateTime? CustomerTrainingDate { get; set; }
		public int? CustomerTrainingBy { get; set; }
		public string? CustomerTrainingDateNotes { get; set; }
		public int? CustomerTrainingDateScheduledBy { get; set; }
		public DateTime? CustomerTrainingDateDateScheduled { get; set; }
		public string? LMIEMAil { get; set; }
		public string? LMIPassword { get; set; }
		public string? LMIAccessCode { get; set; }
		public string? ComputerUserName { get; set; }
		public string? ComputerPassword { get; set; }
		public string? RouterUserName { get; set; }
		public string? RouterPassword { get; set; }
		public string? RouterModel { get; set; }
		public string? RouterIPAddress { get; set; }
		public string? LogInNotes { get; set; }
		public string? RestartSynchEngine { get; set; }
		public string? ProcessOldSalesFiles { get; set; }
		public string? SendCheckDigitToPOS { get; set; }
		public string? UpdateInventory { get; set; }
		public DateTime? ReactivateDate { get; set; }
		public int? StoreTypeID { get; set; }
		public string? UseSSL { get; set; }
		public string? PassportXMLVersion { get; set; }
		public string? UpdateFuelInventoryCost { get; set; }
		public string? ClassID { get; set; }
		public string? UseBlackPipe { get; set; }
		public string? CokeCustomerNumber { get; set; }
		public string? FintechCustomerNumber { get; set; }
		public string? NoveltyCustomerNumber { get; set; }
		public int? NielsenSlotNumber { get; set; }
		public string? Nielsen2 { get; set; }
		public string? IPAddressUpdated { get; set; }
		public string? SamsungMachineID { get; set; }
		public string? Nielsen { get; set; }
		public string? EMailForCommunications { get; set; }
		public string? GetNewVersion { get; set; }
		public string? GetNewPOSDCVer { get; set; }
		public int? MaxItemsToUpload { get; set; }
		public int? MinutesToWaitPer250Records { get; set; }
		public string? PartialRollout { get; set; }
		public string? qbCompany { get; set; }
		public string? qbClassName { get; set; }
		public string? qbSalesTaxAccount { get; set; }
		public string? HackneyCustomerNumber { get; set; }
		public string? TankReadingControlField { get; set; }
		public string? ContactEmailAddress { get; set; }
		public string? ContactPhone { get; set; }
		public int? SMSEMailAddressID { get; set; }
		public string? POShipToName { get; set; }
		public string? POShipToAddress1 { get; set; }
		public string? POShipToAddress2 { get; set; }
		public string? POShipToCity { get; set; }
		public string? POShipToState { get; set; }
		public string? POShipToZip { get; set; }
		public string? POBillToName { get; set; }
		public string? POBillToAddress1 { get; set; }
		public string? POBillToAddress2 { get; set; }
		public string? POBillToCity { get; set; }
		public string? POBillToState { get; set; }
		public string? POBillToZip { get; set; }
		public string? OriginalGetSales { get; set; }
		public decimal? LotteryCommission { get; set; }
		public string? OriginalSendData { get; set; }
		public string? GetPLUTOTFiles { get; set; }
		public string? UsePassportFuelDiscounts { get; set; }
		public string HandheldLevel { get; set; }
		public int? HandheldSeed { get; set; }
		public int? HandheldAnswer { get; set; }
		public DateTime? HandheldLastGenerate { get; set; }
		public int? WarehouseID { get; set; }
		public int? WarehouseEmployeeID { get; set; }
		public string? VendorCustomerNumber { get; set; }
		public string? VendorLocationNumber { get; set; }
		public int? DefaultEDIVendorID { get; set; }
		public string? DefaultRemoteServer { get; set; }
		public string? UseSapphireExpandedDeal { get; set; }
		public string? UseSapphireNAXML { get; set; }
		public short? SapphireNumberOfShifts { get; set; }
		public string? IsCommander { get; set; }
		public string? BookWorksAccount { get; set; }
		public string? GilbarcoCustomer { get; set; }
		public string? ResetPassword { get; set; }
		public string? LastPOFileSent { get; set; }
		public string? GetEJFiles { get; set; }
		public string? PassportTaxBasis { get; set; }
		public int PriceCheckLookedUpSKUCount { get; set; }
		public DateTime? PriceCheckCycleStartDate { get; set; }
		public int PriceCheckType { get; set; }
		public string? UseStorePrices { get; set; }
		public string? DisplayFritosForm { get; set; }
		public DateTime? WhenChanged { get; set; }
		public string? WhoChanged { get; set; }
		public string? DeleteRow { get; set; }
		public string? GetSales_Original { get; set; }
		public string? SendData_Original { get; set; }
		public string? osversion { get; set; }
		public string? MovingStatus { get; set; }
		public string? OriginalDefaultEDIServer { get; set; }
		public string? ReadOnlyPromotions { get; set; }
		public string? ResetModifier { get; set; }
		public string? ClosedOnSunday { get; set; }
		public string? McConnellCustomerNumber { get; set; }
		public string? CheckCompetitors { get; set; }
		public string? SendCompressedUPCToPOS { get; set; }
		public string? sendpromotion { get; set; }
	}
}
