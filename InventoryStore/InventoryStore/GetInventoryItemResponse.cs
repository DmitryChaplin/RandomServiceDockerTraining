namespace RandomService.InventoryStore
{
    public class GetInventoryItemResponse
    {
        public int Id { get; set; }

        public int ItemTypeId { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public string InventoryStoreInstance { get; set; }
    }
}
