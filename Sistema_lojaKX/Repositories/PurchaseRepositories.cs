using Microsoft.EntityFrameworkCore;
using Sistema_lojaKX.Data;
using Sistema_lojaKX.Models;
using Sistema_lojaKX.Repositories.Interfaces;

namespace Sistema_lojaKX.Repositories
{
    public class PurchaseRepositories : IPurchaseRepositories
    {
        private readonly PurchaseSystemDBcontext _dbcontext;
        public PurchaseRepositories(PurchaseSystemDBcontext dBcontext)
        {
            _dbcontext = dBcontext;
        }
        public async Task<PurchaseModel> AddPurchase(PurchaseModel purchase)
        {
            ClientModel client = _dbcontext.Clients.FirstOrDefault(x => x.Id_Client== purchase.Id_Client);
            ProductModel product = _dbcontext.Products.FirstOrDefault(x=>x.Id_Product== purchase.Id_Product);
            if (client == null)
            {
                throw new Exception("There isn't that client!");
            }
            if(product == null)
            {
                throw new Exception("There isn't that product!");
            }
            await _dbcontext.Purchases.AddAsync(purchase);
            await _dbcontext.SaveChangesAsync();
            return purchase;
        }

        public async Task<bool> DeletePurchase(int purchaseId)
        {
            PurchaseModel purchase = _dbcontext.Purchases.FirstOrDefault(x=> x.Id_Purchase == purchaseId);
            if (purchase != null)
            {
                throw new Exception("There are no Purchase in the DataBase");
            }
            _dbcontext.Purchases.Remove(purchase);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<List<PurchaseModel>> GetAllPurchases()
        {
            if (_dbcontext.Purchases == null)
                throw new Exception("There are no purchases");
            return await _dbcontext.Purchases.ToListAsync();

        }

        public async Task<PurchaseModel> GetPurchaseById(int id)
        {
            PurchaseModel purchase = await _dbcontext.Purchases.FirstOrDefaultAsync(x => x.Id_Product == id);
            if (purchase == null)
            {
                throw new Exception($"There is no purchase with this Id : {id}");
            }
            return purchase;
        }
    }
}
