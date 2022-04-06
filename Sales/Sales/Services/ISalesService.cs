namespace RandomService.Sales.Services
{
    public interface ISalesService
    {
        public Task<IPurchaseResponse> Buy(PurchaseRequest request);
    }
}
