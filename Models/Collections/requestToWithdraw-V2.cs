namespace MomoIntegrationApi.Models.Collections
{
    public class RequestToWithdraw_V2
    {
        public string PayeeNote { get; set; }

        public string ExternalId { get; set; }

        public string Amount { get; set; }

        public string Currency { get; set; }

        // Nested class for the payer details
        public PayerDetailsV2 Payer { get; set; }

        public string PayerMessage { get; set; }

        // Inner class to handle payer information
        public class PayerDetailsV2
        {
            public string PartyIdType { get; set; }

            public string PartyId { get; set; }
        }
    }
}
