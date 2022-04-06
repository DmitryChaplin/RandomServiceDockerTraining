namespace RandomService.InventoryStore.Services
{
    public class InventoryStoreService : IInventoryStoreService
    {
        private const string ItemName = "Undefined Item Type";
        private static readonly Random instance = new();

        public GetInventoryItemResponse Get(int itemType)
        {
            return new GetInventoryItemResponse
            {
                Id = instance.Next(1, 999),
                InventoryStoreInstance = Environment.MachineName,
                ItemTypeId = itemType,
                Name = ItemName,
                Price = instance.Next(99, 99999),
            };
        }
    }
}
