using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Repositories.Interfaces
{
    public interface IPurchaseRepositories
    {
        Task<List<PurchaseModel>> GetAllPurchases();
        Task<PurchaseModel> GetPurchaseById(int id);
        Task<PurchaseModel> AddPurchase(PurchaseModel purchase);
        Task<bool> DeletePurchase(int purchaseId);
    }
}
