﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItsRewardsApp.Server.Migrations.LoyaltyBaseDB
{
    public partial class InitialLoyaltyBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblstore",
                columns: table => new
                {
                    StoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatabaseID = table.Column<int>(type: "int", nullable: false),
                    LEID = table.Column<int>(type: "int", nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterModelID = table.Column<int>(type: "int", nullable: true),
                    Sam4ParentStoreID = table.Column<int>(type: "int", nullable: false),
                    ComCashLocationNo = table.Column<short>(type: "smallint", nullable: true),
                    ComCashLastInvoiceNo = table.Column<int>(type: "int", nullable: true),
                    ComCashLastInvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AcctgSprdsheets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaxmlVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPAddressInternal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalEntityId = table.Column<int>(type: "int", nullable: true),
                    NucleusVersionID = table.Column<int>(type: "int", nullable: true),
                    EnhancedHandheld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceInput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetSales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalSynch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalServerID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftwareSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutputID = table.Column<int>(type: "int", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreBlurbForCoupons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorID = table.Column<int>(type: "int", nullable: true),
                    VendorAcctNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StationNo = table.Column<int>(type: "int", nullable: true),
                    GetInvoices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultEDIServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrulyActiveIETest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loyalty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPB_IRI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstLoyaltyCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoyaltyCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstMagneticStripNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastMagneticStripNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreWebSiteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoyaltyEMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSalesDownload = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastPriceChange = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PriceBookID = table.Column<int>(type: "int", nullable: true),
                    RegisterIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoyaltyHouseAccounts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetSalesOnce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetPLUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLURows = table.Column<int>(type: "int", nullable: true),
                    AllowableVariance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeID_ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeId_EnteredBy = table.Column<int>(type: "int", nullable: true),
                    RegisterUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationTypeId = table.Column<int>(type: "int", nullable: false),
                    NumberOfShifts = table.Column<int>(type: "int", nullable: true),
                    UpdateRetailPricesOnInvoiceReceipt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOnHandOnInvoiceReceipt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftwareSetID = table.Column<int>(type: "int", nullable: true),
                    UpdateVendorCostOnInvoiceReceipt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InProcessNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseLinkedItems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseShiftSales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedPeriodNumber = table.Column<int>(type: "int", nullable: true),
                    SalesTaxString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealTaxString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetSales_Base = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLUNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelEPAAllowableVariance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StoreNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutboundConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCProcessingPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EMail1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowTips1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedPeriodNumberToCollect = table.Column<int>(type: "int", nullable: true),
                    GetLogFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetConfig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReStartSE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReStartSELastDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedPeriodNumberForIRI = table.Column<int>(type: "int", nullable: true),
                    SendSalesFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessSalesFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionEMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseSapphire14DigitSKUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetworkUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetworkPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentShippedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EquipmentShippedBy = table.Column<int>(type: "int", nullable: true),
                    EquipmentShippedNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentShippedScheduledBy = table.Column<int>(type: "int", nullable: true),
                    EquipmentShippedDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConnectivityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConnectivityBy = table.Column<int>(type: "int", nullable: true),
                    ConnectivityNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectivityScheduledBy = table.Column<int>(type: "int", nullable: true),
                    ConnectivityDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfigDownloadedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfigDownloadedBy = table.Column<int>(type: "int", nullable: true),
                    ConfigDownloadedNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigDownloadedScheduledBy = table.Column<int>(type: "int", nullable: true),
                    ConfigDownloadedDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatabaseSetupDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatabaseSetupBy = table.Column<int>(type: "int", nullable: true),
                    DatabaseSetupNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatabaseSetupScheduledBy = table.Column<int>(type: "int", nullable: true),
                    DatabaseSetupDAteScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EDIMailBoxSetupDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EDIMailBoxSetupBy = table.Column<int>(type: "int", nullable: true),
                    EDIMailBoxSetupNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDIMailBoxSetupScheduledBy = table.Column<int>(type: "int", nullable: true),
                    EDIMailBoxSetupDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VelocityReportsImportedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VelocityReportsImportedBy = table.Column<int>(type: "int", nullable: true),
                    VelocityReportsImportedNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VelocityReportsImportedScheduledBy = table.Column<int>(type: "int", nullable: true),
                    VelocityReportsImportedDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoicesCheckedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoicesCheckedBy = table.Column<int>(type: "int", nullable: true),
                    InvoicesCheckedByNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicesCheckedByScheduledBy = table.Column<int>(type: "int", nullable: true),
                    InvoicesCheckedByDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesImportedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesImportedBy = table.Column<int>(type: "int", nullable: true),
                    SalesImportedNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesImportedScheduledBy = table.Column<int>(type: "int", nullable: true),
                    SalesImportedDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemChangedAndSentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemChangedAndSentBy = table.Column<int>(type: "int", nullable: true),
                    ItemChangedAndSentNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemChangedAndSentScheduledBy = table.Column<int>(type: "int", nullable: true),
                    ItemChangedAndSentDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiteReadyForTrainingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiteReadyForTrainingBy = table.Column<int>(type: "int", nullable: true),
                    SiteReadyForTrainingDateNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteReadyForTrainingDateScheduledBy = table.Column<int>(type: "int", nullable: true),
                    SiteReadyForTrainingDateDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerTrainingScheduledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerTrainingScheduledBy = table.Column<int>(type: "int", nullable: true),
                    CustomerTrainingScheduledNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTrainingScheduledScheduledBy = table.Column<int>(type: "int", nullable: true),
                    CustomerTrainingScheduledDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerTrainingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerTrainingBy = table.Column<int>(type: "int", nullable: true),
                    CustomerTrainingDateNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTrainingDateScheduledBy = table.Column<int>(type: "int", nullable: true),
                    CustomerTrainingDateDateScheduled = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LMIEMAil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LMIPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LMIAccessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouterUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouterPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouterModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouterIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogInNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestartSynchEngine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessOldSalesFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendCheckDigitToPOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateInventory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReactivateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StoreTypeID = table.Column<int>(type: "int", nullable: true),
                    UseSSL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportXMLVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateFuelInventoryCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseBlackPipe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CokeCustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FintechCustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoveltyCustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NielsenSlotNumber = table.Column<int>(type: "int", nullable: true),
                    Nielsen2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPAddressUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamsungMachineID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nielsen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMailForCommunications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetNewVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetNewPOSDCVer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxItemsToUpload = table.Column<int>(type: "int", nullable: true),
                    MinutesToWaitPer250Records = table.Column<int>(type: "int", nullable: true),
                    PartialRollout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qbCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qbClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qbSalesTaxAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HackneyCustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TankReadingControlField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMSEMailAddressID = table.Column<int>(type: "int", nullable: true),
                    POShipToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POShipToAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POShipToAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POShipToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POShipToState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POShipToZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POBillToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POBillToAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POBillToAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POBillToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POBillToState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    POBillToZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalGetSales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotteryCommission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OriginalSendData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetPLUTOTFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsePassportFuelDiscounts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandheldLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HandheldSeed = table.Column<int>(type: "int", nullable: true),
                    HandheldAnswer = table.Column<int>(type: "int", nullable: true),
                    HandheldLastGenerate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarehouseID = table.Column<int>(type: "int", nullable: true),
                    WarehouseEmployeeID = table.Column<int>(type: "int", nullable: true),
                    VendorCustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorLocationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultEDIVendorID = table.Column<int>(type: "int", nullable: true),
                    DefaultRemoteServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseSapphireExpandedDeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseSapphireNAXML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapphireNumberOfShifts = table.Column<short>(type: "smallint", nullable: true),
                    IsCommander = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookWorksAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GilbarcoCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPOFileSent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetEJFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportTaxBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceCheckLookedUpSKUCount = table.Column<int>(type: "int", nullable: false),
                    PriceCheckCycleStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PriceCheckType = table.Column<int>(type: "int", nullable: false),
                    UseStorePrices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayFritosForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhenChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WhoChanged = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteRow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetSales_Original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendData_Original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    osversion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalDefaultEDIServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReadOnlyPromotions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetModifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosedOnSunday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    McConnellCustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckCompetitors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendCompressedUPCToPOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sendpromotion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblstore", x => x.StoreID);
                });

            migrationBuilder.CreateTable(
                name: "tblTobaccoRebateProgramType",
                columns: table => new
                {
                    RebateTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataBaseID = table.Column<int>(type: "int", nullable: true),
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    RJRAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaUSSTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaAllOtherManCig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaPMUSA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLateSalesEMailDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastRJREMailDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastAltriaEMailDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastRJRFileSent = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastAltriaFileSent = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAltriaChain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayClosed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaChainNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutletSequence = table.Column<int>(type: "int", nullable: true),
                    RegisterID = table.Column<int>(type: "int", nullable: true),
                    IsAltriaApproved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRJRApproved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rjrsubmitiondate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RJRFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaSubmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRSubmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRPortalUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRPortalPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionUpdateScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marlboromultipack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iriemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msaemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coupons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loyalty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    promotiontext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RJRStoreAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altria_Client_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altria_Client_Secret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltriaBatchType = table.Column<int>(type: "int", nullable: true),
                    Tier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cigs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smokeless = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cigar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EVape = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTobaccoRebateProgramType", x => x.RebateTypeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblstore");

            migrationBuilder.DropTable(
                name: "tblTobaccoRebateProgramType");
        }
    }
}
