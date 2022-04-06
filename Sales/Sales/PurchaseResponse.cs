namespace RandomService.Sales
{
    public interface IPurchaseResponse
    {
        public bool IsSucceseful { get; set; }

        public string DeclineReason { get; set; }
    }
}
