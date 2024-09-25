namespace MomoIntegrationApi.Models.Collections
{
    namespace MomoIntegrationApi.Models.Collections
    {
        public class createPayments
        {
            public string ExternalTransactionId { get; set; }

            public Money Money { get; set; }

            public string CustomerReference { get; set; }

            public string ServiceProviderUserName { get; set; }
        }

        public class Money
        {
            public string Amount { get; set; }

            public string Currency { get; set; }
        }
    }
}
