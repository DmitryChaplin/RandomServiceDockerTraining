namespace RandomService.InventoryStore.Services
{
    public interface IInventoryStoreService
    {
        public GetInventoryItemResponse Get(int itemType);
    }
}
