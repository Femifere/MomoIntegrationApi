namespace MomoIntegrationApi.Logging___Error_Handling
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log request details
            await _next(context);
            // Log response details
        }
    }
}
