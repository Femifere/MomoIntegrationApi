namespace MomoIntegrationApi.Models.Collections
{
    public class CashTransfer
    {
        public string Amount { get; set; }
        public string Currency { get; set; }
        public Payee Payee { get; set; }
        public string ExternalId { get; set; }
        public string OriginatingCountry { get; set; }
        public string OriginalAmount { get; set; }
        public string OriginalCurrency { get; set; }
        public string PayerMessage { get; set; }
        public string PayeeNote { get; set; }
        public string PayerIdentificationType { get; set; }
        public string PayerIdentificationNumber { get; set; }
        public string PayerIdentity { get; set; }
        public string PayerFirstName { get; set; }
        public string PayerSurName { get; set; }
        public string PayerLanguageCode { get; set; }
        public string PayerEmail { get; set; }
        public string PayerMsisdn { get; set; }
        public string PayerGender { get; set; }
    }

    public class Payee
    {
        public string PartyId { get; set; }
        public string PartyIdType { get; set; } // Can be enum if specific values are used
    }
}