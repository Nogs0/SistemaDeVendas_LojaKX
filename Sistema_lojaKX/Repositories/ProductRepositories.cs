using Sistema_lojaKX.Data;
using Sistema_lojaKX.Models;
using Sistema_lojaKX.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sistema_lojaKX.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly PurchaseSystemDBcontext _dbContext;
        public ProductRepositories(PurchaseSystemDBcontext dbContext)
        {
            _dbContext = dbContext;
        }

        //Função que adiciona um produto apenas se o Name_Product não exisitr no banco
        public async Task<ProductModel> AddProduct(ProductModel productModel)
        {
            ProductModel product =  await GetProductByName(productModel.Name_Product);
            if(product == null)
            {
                await _dbContext.Products.AddAsync(productModel);
                await _dbContext.SaveChangesAsync();
                return productModel;

            }
            throw new Exception("Product already exists!");            
        }
                
        public async Task<List<ProductModel>> GetAllProducts()
        {            
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<ProductModel> GetProductByName(string name)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Name_Product == name);
        }

        public async Task<ProductModel> UpdateProduct(ProductModel productModel, string name)
        {
            ProductModel product = await GetProductByName(name);
            if(product == null)
            {
                throw new Exception("There are no products in the Database");
            }

            product.Value_Product = productModel.Value_Product;
            product.Name_Product = productModel.Name_Product;
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(string name)
        {
            ProductModel product = _dbContext.Products.FirstOrDefault(x=> x.Name_Product == name);
            if(product == null)
            {
                throw new Exception("There isn't that product!");
            }

            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
