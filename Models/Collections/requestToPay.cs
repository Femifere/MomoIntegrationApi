namespace MomoIntegrationApi.Models.Collections
{
    public class RequestToPay
    {
        // Properties
        public string Amount { get; set; }

        public string Currency { get; set; }

        public string ExternalId { get; set; }

        public Payer Payer { get; set; }

        public string PayerMessage { get; set; }

        public string PayeeNote { get; set; }
    }
}
