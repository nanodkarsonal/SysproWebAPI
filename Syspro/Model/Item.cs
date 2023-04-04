

using Newtonsoft.Json;
using System;

namespace Syspro.Model
{
    public partial class Item
    {
        [JsonProperty("key")]
        public Key Key { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Salesperson")]
        public long Salesperson { get; set; }

        [JsonProperty("Branch")]
        public long Branch { get; set; }

        [JsonProperty("TermsCode")]
        public long TermsCode { get; set; }

        [JsonProperty("ArStatementNo")]
        public string ArStatementNo { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }

        [JsonProperty("ExemptFinChg")]
        public string ExemptFinChg { get; set; }

        [JsonProperty("MaintHistory")]
        public string MaintHistory { get; set; }

        [JsonProperty("CreditStatus")]
        public long CreditStatus { get; set; }

        [JsonProperty("CreditLimit")]
        public long CreditLimit { get; set; }

        [JsonProperty("CreditCheckFlag")]
        public string CreditCheckFlag { get; set; }

        [JsonProperty("PriceCode")]
        public string PriceCode { get; set; }

        [JsonProperty("CustomerClass")]
        public string CustomerClass { get; set; }

        [JsonProperty("InvDiscCode")]
        public string InvDiscCode { get; set; }

        [JsonProperty("BalanceType")]
        public string BalanceType { get; set; }

        [JsonProperty("Area")]
        public string Area { get; set; }

        [JsonProperty("LineDiscCode")]
        public string LineDiscCode { get; set; }

        [JsonProperty("TaxStatus")]
        public string TaxStatus { get; set; }

        [JsonProperty("TaxExemptNumber")]
        public string TaxExemptNumber { get; set; }

        [JsonProperty("SpecialInstrs")]
        public string SpecialInstrs { get; set; }

        [JsonProperty("PriceCategoryTable")]
        public string PriceCategoryTable { get; set; }

        [JsonProperty("Telephone")]
        public string Telephone { get; set; }

        [JsonProperty("TelephoneExtn")]
        public string TelephoneExtn { get; set; }

        [JsonProperty("Contact")]
        public string Contact { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("Currency")]
        public string Currency { get; set; }

        [JsonProperty("UserField1")]
        public string UserField1 { get; set; }

        [JsonProperty("UserField2")]
        public string UserField2 { get; set; }

        [JsonProperty("GstExemptFlag")]
        public string GstExemptFlag { get; set; }

        [JsonProperty("GstExemptNum")]
        public string GstExemptNum { get; set; }

        [JsonProperty("GstLevel")]
        public string GstLevel { get; set; }

        [JsonProperty("DetailMoveReqd")]
        public string DetailMoveReqd { get; set; }

        [JsonProperty("ContractPrcReqd")]
        public string ContractPrcReqd { get; set; }

        [JsonProperty("BuyingGroup1")]
        public string BuyingGroup1 { get; set; }

        [JsonProperty("BuyingGroup2")]
        public string BuyingGroup2 { get; set; }

        [JsonProperty("BuyingGroup3")]
        public string BuyingGroup3 { get; set; }

        [JsonProperty("BuyingGroup4")]
        public string BuyingGroup4 { get; set; }

        [JsonProperty("BuyingGroup5")]
        public string BuyingGroup5 { get; set; }

        [JsonProperty("StatementReqd")]
        public string StatementReqd { get; set; }

        [JsonProperty("BackOrdReqd")]
        public string BackOrdReqd { get; set; }

        [JsonProperty("ShippingInstrs")]
        public string ShippingInstrs { get; set; }

        [JsonProperty("ShippingInstrsCod")]
        public string ShippingInstrsCod { get; set; }

        [JsonProperty("StateCode")]
        public string StateCode { get; set; }

        [JsonProperty("DateCustAdded")]
        public DateTimeOffset DateCustAdded { get; set; }

        [JsonProperty("StockInterchange")]
        public string StockInterchange { get; set; }

        [JsonProperty("MaintLastPrcPaid")]
        public string MaintLastPrcPaid { get; set; }

        [JsonProperty("IbtCustomer")]
        public string IbtCustomer { get; set; }

        [JsonProperty("SoDefaultDoc")]
        public long SoDefaultDoc { get; set; }

        [JsonProperty("CounterSlsOnly")]
        public string CounterSlsOnly { get; set; }

        [JsonProperty("Nationality")]
        public string Nationality { get; set; }

        [JsonProperty("CustomerOnHold")]
        public string CustomerOnHold { get; set; }

        [JsonProperty("InvCommentCode")]
        public string InvCommentCode { get; set; }

        [JsonProperty("EdiSenderCode")]
        public string EdiSenderCode { get; set; }

        [JsonProperty("EdiFlag")]
        public string EdiFlag { get; set; }

        [JsonProperty("SoDefaultType")]
        public string SoDefaultType { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("ApplyOrdDisc")]
        public string ApplyOrdDisc { get; set; }

        [JsonProperty("ApplyLineDisc")]
        public string ApplyLineDisc { get; set; }

        [JsonProperty("FaxInvoices")]
        public string FaxInvoices { get; set; }

        [JsonProperty("FaxStatements")]
        public string FaxStatements { get; set; }

        [JsonProperty("FaxQuotes")]
        public string FaxQuotes { get; set; }

        [JsonProperty("DocFax")]
        public string DocFax { get; set; }

        [JsonProperty("DocFaxContact")]
        public string DocFaxContact { get; set; }

        [JsonProperty("SoldToAddr1")]
        public string SoldToAddr1 { get; set; }

        [JsonProperty("SoldToAddr2")]
        public string SoldToAddr2 { get; set; }

        [JsonProperty("SoldToAddr3")]
        public string SoldToAddr3 { get; set; }

        [JsonProperty("SoldToAddr3Loc")]
        public string SoldToAddr3Loc { get; set; }

        [JsonProperty("SoldToAddr4")]
        public string SoldToAddr4 { get; set; }

        [JsonProperty("SoldToAddr5")]
        public string SoldToAddr5 { get; set; }

        [JsonProperty("SoldPostalCode")]
        public string SoldPostalCode { get; set; }

        [JsonProperty("ShipToAddr1")]
        public string ShipToAddr1 { get; set; }

        [JsonProperty("ShipToAddr2")]
        public string ShipToAddr2 { get; set; }

        [JsonProperty("ShipToAddr3")]
        public string ShipToAddr3 { get; set; }

        [JsonProperty("ShipToAddr3Loc")]
        public string ShipToAddr3Loc { get; set; }

        [JsonProperty("ShipToAddr4")]
        public string ShipToAddr4 { get; set; }

        [JsonProperty("ShipToAddr5")]
        public string ShipToAddr5 { get; set; }

        [JsonProperty("ShipPostalCode")]
        public string ShipPostalCode { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("CountyZip")]
        public string CountyZip { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State1")]
        public string State1 { get; set; }

        [JsonProperty("CountyZip1")]
        public string CountyZip1 { get; set; }

        [JsonProperty("City1")]
        public string City1 { get; set; }

        [JsonProperty("DefaultOrdType")]
        public string DefaultOrdType { get; set; }

        [JsonProperty("PoNumberMandatory")]
        public string PoNumberMandatory { get; set; }

        [JsonProperty("CompanyTaxNumber")]
        public string CompanyTaxNumber { get; set; }

        [JsonProperty("TransactionNature")]
        public string TransactionNature { get; set; }

        [JsonProperty("TransactionNatureC")]
        public string TransactionNatureC { get; set; }

        [JsonProperty("DeliveryTerms")]
        public string DeliveryTerms { get; set; }

        [JsonProperty("DeliveryTermsC")]
        public string DeliveryTermsC { get; set; }

        [JsonProperty("ShippingLocation")]
        public string ShippingLocation { get; set; }

        [JsonProperty("TpmCustomerFlag")]
        public string TpmCustomerFlag { get; set; }

        [JsonProperty("TpmCreditCheck")]
        public string TpmCreditCheck { get; set; }

        [JsonProperty("TpmPricingFlag")]
        public string TpmPricingFlag { get; set; }

        [JsonProperty("RouteCode")]
        public string RouteCode { get; set; }

        [JsonProperty("RouteDistance")]
        public string RouteDistance { get; set; }

        [JsonProperty("SalesWarehouse")]
        public string SalesWarehouse { get; set; }

        [JsonProperty("WholeOrderShipFlag")]
        public string WholeOrderShipFlag { get; set; }

        [JsonProperty("MinimumOrderValue")]
        public long MinimumOrderValue { get; set; }

        [JsonProperty("MinimumOrderChgCod")]
        public string MinimumOrderChgCod { get; set; }

        [JsonProperty("UkVatFlag")]
        public string UkVatFlag { get; set; }

        [JsonProperty("UkCurrency")]
        public string UkCurrency { get; set; }

        [JsonProperty("Salesperson1")]
        public string Salesperson1 { get; set; }

        [JsonProperty("Salesperson2")]
        public string Salesperson2 { get; set; }

        [JsonProperty("Salesperson3")]
        public string Salesperson3 { get; set; }

        [JsonProperty("AddTelephone")]
        public string AddTelephone { get; set; }

        [JsonProperty("Telex")]
        public string Telex { get; set; }

        [JsonProperty("HighestBalance")]
        public string HighestBalance { get; set; }

        [JsonProperty("HighInv")]
        public string HighInv { get; set; }

        [JsonProperty("HighInvDays")]
        public string HighInvDays { get; set; }

        [JsonProperty("eSignature")]
        public string ESignature { get; set; }

        [JsonProperty("SoldToGpsLat")]
        public string SoldToGpsLat { get; set; }

        [JsonProperty("SoldToGpsLong")]
        public string SoldToGpsLong { get; set; }

        [JsonProperty("ShipToGpsLat")]
        public string ShipToGpsLat { get; set; }

        [JsonProperty("ShipToGpsLong")]
        public string ShipToGpsLong { get; set; }

        [JsonProperty("LanguageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("AltMethodFlag")]
        public string AltMethodFlag { get; set; }

        [JsonProperty("SalesAllowed")]
        public string SalesAllowed { get; set; }

        [JsonProperty("UnappPayAllowed")]
        public string UnappPayAllowed { get; set; }

        [JsonProperty("PaymentsAllowed")]
        public string PaymentsAllowed { get; set; }

        [JsonProperty("QuotesAllowed")]
        public string QuotesAllowed { get; set; }

        [JsonProperty("CrNotesAllowed")]
        public string CrNotesAllowed { get; set; }

        [JsonProperty("DrNotesAllowed")]
        public string DrNotesAllowed { get; set; }

        [JsonProperty("QueryAllowed")]
        public string QueryAllowed { get; set; }

        [JsonProperty("PriceGroup")]
        public string PriceGroup { get; set; }

        [JsonProperty("DunningGroup")]
        public string DunningGroup { get; set; }

        [JsonProperty("DunningFax")]
        public string DunningFax { get; set; }

        [JsonProperty("DunningEmail")]
        public string DunningEmail { get; set; }
    }
}
