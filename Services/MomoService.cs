using Newtonsoft.Json;

namespace MomoIntegrationApi.Services
{
    public class MomoService : IMomoService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public MomoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<ApiResponse> RequestToPayAsync(PaymentRequest request)
        {
            var url = _configuration["MomoApi:RequestToPay"];
            var response = await _httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(request)));

            // Handle response and return an ApiResponse object
        }

        public async Task<PaymentStatus> GetPaymentStatusAsync(string referenceId)
        {
            var url = $"{_configuration["MomoApi:PaymentStatus"]}/{referenceId}";
            var response = await _httpClient.GetAsync(url);

            // Parse response and return a PaymentStatus object
        }
    }
}
