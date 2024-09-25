namespace MomoIntegrationApi.Models.Collections
{
    public class IntendedPayer
    {
        public string MSISDN { get; set; }

        public string partyId { get; set; }
    }

    public class payee
    {
        public string MSISDN { get; set; }

        public string partyId { get; set; }
    }

    public class createInvoice
    {
        public string externalId { get; set; }

        public double amount { get; set; }

        public string currency { get; set; }

        public DateTime? validityDuration { get; set; }

        public IntendedPayer[] intendedPayer { get; set; }

        public payee[] payee { get; set; }

        public string description { get; set; }
    }
}
