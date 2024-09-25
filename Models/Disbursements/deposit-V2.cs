namespace MomoIntegrationApi.Models.Disbursements
{
    public class deposit_V2
    {
        public string PayeeNote { get; set; }
        public string ExternalId { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }

        // Nested class for the payer details
        public PayerDetailsV1 Payee { get; set; }
        public string PayerMessage { get; set; }

        // Inner class to handle payer information
        public class PayerDetailsV1
        {
            public string PartyIdType { get; set; }
            public string PartyId { get; set; }
        }
    }
}
