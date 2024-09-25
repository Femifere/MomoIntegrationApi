using Microsoft.AspNetCore.Mvc;

namespace MomoIntegrationApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IMomoService _momoService;

        public PaymentController(IMomoService momoService)
        {
            _momoService = momoService;
        }

        [HttpPost("request-to-pay")]
        public async Task<IActionResult> RequestToPay([FromBody] PaymentRequest request)
        {
            var response = await _momoService.RequestToPayAsync(request);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("payment-status/{referenceId}")]
        public async Task<IActionResult> GetPaymentStatus(string referenceId)
        {
            var status = await _momoService.GetPaymentStatusAsync(referenceId);
            if (status != null)
                return Ok(status);
            return NotFound();
        }
    }
}
