namespace MomoIntegrationApi.Models
{
    public class bc_authorize
    {
        //Oauth2 Token
        public string MSISDN { get; set; }

        public string scope { get; set; }

        public string accessType { get; set; }
    }
}
