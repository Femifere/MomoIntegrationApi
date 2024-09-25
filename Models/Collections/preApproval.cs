namespace MomoIntegrationApi.Models.Collections
{
    public class preApproval
    {
        public Payer Payer { get; set; }

        public string PayerCurrency { get; set; }

        public string PayerMessage { get; set; }

        public int ValidityTime { get; set; }
    }

    public class Payer
    {
        public string PartyIdType { get; set; }

        public string PartyId { get; set; }
    }
}
