using Microsoft.AspNetCore.Mvc;
using Sistema_lojaKX.Models;
using Sistema_lojaKX.Repositories.Interfaces;

namespace Sistema_lojaKX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepositories _clientRepositories;
        public ClientController(IClientRepositories clientRepositories)
        {
            _clientRepositories= clientRepositories;
        }
        [HttpPost]
        public async Task<ActionResult<ClientModel>> AddClient([FromBody] ClientModel clientModel)
        {
            ClientModel client = await _clientRepositories.AddClient(clientModel);
            return Ok(client);
        }

        [HttpGet]
        public async Task<ActionResult<List<ClientModel>>> GetClients()
        {
            List<ClientModel> clients = await _clientRepositories.GetAllClients();
            return Ok(clients);
        }


        [HttpGet("{cpf}")]
        public async Task<ActionResult<ClientModel>> GetClientByCPF(string cpf)
        {
            ClientModel client = await _clientRepositories.GetClientByCPF(cpf);
            return Ok(client);
        }

        [HttpPut("{cpf}")]
        public async Task<ActionResult<ClientModel>> UpdateClientByCPF(ClientModel _client, string cpf)
        {
            _client.CPF= cpf;
            ClientModel client = await _clientRepositories.UpdateClientByCPF(_client, cpf);
            return Ok(client);
        }

        [HttpDelete("{cpf}")]
        public async Task<ActionResult<ClientModel>> DeleteClientByCPF(string cpf)
        {
            bool delete = await _clientRepositories.DeleteClientByCPF(cpf);
            return Ok(delete);
        }
    }
}
