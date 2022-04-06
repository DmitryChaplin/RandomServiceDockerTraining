using Microsoft.AspNetCore.Mvc;
using RandomService.Sales.Services;

namespace RandomService.Sales.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class SalesController : ControllerBase
    {
        private readonly ILogger<SalesController> _logger;
        private readonly ISalesService _salesService;

        public SalesController(ILogger<SalesController> logger, ISalesService salesService)
        {
            _logger = logger;
            _salesService = salesService;
        }

        [HttpPost("")]
        public async Task<IPurchaseResponse> Buy(PurchaseRequest request) => await _salesService.Buy(request);
    }
}