namespace MomoIntegrationApi.Models
{
    public class validateAccountHolderStatus
    {
        //Parameters
        // Enum definition
        public enum accountHolderIdType
        {
            msisdn,
            email,
            id,
            alias
        }

        // Property using the enum
        public accountHolderIdType AccountHolderId { get; set; }
    }
}
