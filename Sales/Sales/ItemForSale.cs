namespace RandomService.Sales
{
    public class ItemForSale
    {
        public int Id { get; set; }

        public string ItemTypeId { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public string InventoryStoreInstance { get; set; }
    }
}
