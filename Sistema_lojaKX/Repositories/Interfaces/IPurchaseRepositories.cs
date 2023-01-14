using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Repositories.Interfaces
{
    public interface IPurchaseRepositories
    {
        Task<List<PurchaseModel>> GetAllPurchases();
        Task<PurchaseModel> GetPurchaseByCPF(string CPF);
        Task<PurchaseModel> AddPurchase(PurchaseModel purchase);

    }
}
