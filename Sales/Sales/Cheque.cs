namespace RandomService.Sales
{
    public sealed class Cheque : IPurchaseResponse
    {
        
        public decimal Amount { get; set; }

        public decimal Change { get; set; }     
        
        public DateTime DateCreated { get; set; }

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string SalesInstance { get; set; }

        public string InventoryStoreInstance { get; set; }

        public bool IsSucceseful { get; set; }

        public string DeclineReason { get; set; }
    }
}