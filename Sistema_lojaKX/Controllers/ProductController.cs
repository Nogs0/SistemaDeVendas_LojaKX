using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_lojaKX.Models;
using Sistema_lojaKX.Repositories.Interfaces;

namespace Sistema_lojaKX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepositories _productrepositories;
        public ProductController(IProductRepositories productrepositories)
        {
            _productrepositories = productrepositories;
        }

        [HttpPost]
        public async Task<ActionResult<ProductModel>> AddProduct([FromBody] ProductModel productModel)
        {
            ProductModel product = await _productrepositories.AddProduct(productModel);
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
        {
            List<ProductModel> products = await _productrepositories.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{name}")]
        public async Task<ActionResult<ProductModel>> GetProductByName(string name)
        {
            ProductModel product = await _productrepositories.GetProductByName(name);
            return Ok(product);
        }
        [HttpDelete("{name}")]
        public async Task<ActionResult<bool>> DeleteProduct(string name)
        {
            await _productrepositories.DeleteProduct(name);
            return Ok(true);
        }
        [HttpPut("{name}")]
        public async Task<ActionResult<ProductModel>> UpdateProduct([FromBody] ProductModel productModel, string name)
        {
            productModel.Name_Product = name;
            ProductModel product = await _productrepositories.UpdateProduct(productModel, name);
            return Ok(product);

        }


    }
}
