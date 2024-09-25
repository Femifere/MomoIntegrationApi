namespace MomoIntegrationApi.Models.Collections
{
    public class requestToPayDeliveryNotification
    {
        //parameters
        public string ReferenceId { get; set; }

        //Header
        public string notificationMessage { get; set; }

        public string language { get; set; }
    }
}
