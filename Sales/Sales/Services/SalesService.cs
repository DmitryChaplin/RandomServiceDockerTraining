using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace RandomService.Sales.Services
{
    public class SalesService : ISalesService
    {
        private IConfiguration configuration { get; set; }
        private static readonly HttpClient httpClient = new HttpClient();

        public SalesService(IConfiguration configuration) => this.configuration = configuration;

        public async Task<IPurchaseResponse> Buy(PurchaseRequest request)
        {
            var queryParams = new Dictionary<string, string>() { { "itemTypeId", request.ItemType.ToString() } };
            var requestUri = new Uri(QueryHelpers.AddQueryString(configuration["IntentoryServiceUrl"], queryParams));
            var response = await httpClient.GetAsync(requestUri).Result.Content.ReadAsStringAsync();
            var item = JsonConvert.DeserializeObject<ItemForSale>(response);

            if (item != null)   
            {
                return new Cheque()
                {
                    IsSucceseful = true,
                    Amount = item.Price,
                    Change = request.Amount - item.Price,
                    DateCreated = DateTime.UtcNow,
                    SalesInstance = Environment.MachineName,
                    InventoryStoreInstance = item.InventoryStoreInstance,
                    ItemId = item.Id,
                    ItemName = item.Name,
                };
            }
            else
            {
                return new Cheque() { IsSucceseful = false, DeclineReason = $"ItemType {request.ItemType} was not found." };
            }
        }
    }
}
