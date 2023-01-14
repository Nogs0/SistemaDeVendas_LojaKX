using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ClientModel>> GetClients()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<ClientModel> GetClientById(int id)
        {
            return Ok();
        }
    }
}
