using Microsoft.AspNetCore.Mvc;
using Sistema_lojaKX.Models;
using Sistema_lojaKX.Repositories.Interfaces;

namespace Sistema_lojaKX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseRepositories _purchaseRepositories;
        public PurchaseController(IPurchaseRepositories purchaseRepositories)
        {
            _purchaseRepositories = purchaseRepositories;
        }
        [HttpPost]
        public async Task<ActionResult<PurchaseModel>> AddPurchase([FromBody] PurchaseModel purchaseModel)
        {
            PurchaseModel purchase = await _purchaseRepositories.AddPurchase(purchaseModel);
            return Ok(purchase);

        }

        [HttpGet]
        public async Task<ActionResult<List<PurchaseModel>>> GetAllPurchases()
        {
            List<PurchaseModel> purchases = await _purchaseRepositories.GetAllPurchases();
            return Ok(purchases);
        }

        [HttpGet("{cpf}")]
        public async Task<ActionResult<PurchaseModel>> GetPurchaseByCPF(string cpf)
        {
            PurchaseModel purchase = await _purchaseRepositories.GetPurchaseByCPF(cpf);
            return Ok(purchase);
        }

        
    }
}
