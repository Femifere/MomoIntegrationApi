namespace MomoIntegrationApi.Security___Middleware
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public AuthService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            var tokenUrl = _configuration["MomoApi:TokenUrl"];
            var response = await _httpClient.PostAsync(tokenUrl, ...);

            // Extract token from response and return
        }
    }
}
