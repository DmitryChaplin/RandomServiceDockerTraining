using Microsoft.AspNetCore.Mvc;
using RandomService.InventoryStore;
using RandomService.InventoryStore.Services;

namespace RandomService.Sales.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class InventoryStoreController : ControllerBase
    {
        private readonly ILogger<InventoryStoreController> _logger;
        private readonly IInventoryStoreService _inventoryService;

        public InventoryStoreController(ILogger<InventoryStoreController> logger, IInventoryStoreService inventoryService)
        {
            _logger = logger;
            _inventoryService = inventoryService;
        }

        [HttpGet("")]
        public GetInventoryItemResponse Get(int itemTypeId) => _inventoryService.Get(itemTypeId);
    }
}