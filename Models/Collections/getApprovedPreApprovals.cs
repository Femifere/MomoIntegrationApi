namespace MomoIntegrationApi.Models.Collections
{
    public class GetApprovedPreApprovals
    {
        //parameter
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
