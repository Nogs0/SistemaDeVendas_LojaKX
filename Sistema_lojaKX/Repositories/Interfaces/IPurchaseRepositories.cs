using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Repositories.Interfaces
{
    public interface IPurchaseRepositories
    {
        Task<List<PurchaseModel>> GetAllPurchases();
        Task<List<PurchaseModel>> GetPurchaseByCpf(string cpf);
        Task<PurchaseModel> AddPurchase(PurchaseModel purchase);
        Task<bool> DeletePurchase(int purchaseId);
    }
}
