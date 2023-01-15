using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Repositories.Interfaces
{
    public interface IProductRepositories
    {
        Task<List<ProductModel>> GetAllProducts();
        Task<ProductModel> GetProductByName(string name);
        Task<ProductModel> AddProduct(ProductModel productModel);
        Task<ProductModel> UpdateProduct(ProductModel productModel, string name);
        Task<bool> DeleteProduct(string name);
    
    }
}
