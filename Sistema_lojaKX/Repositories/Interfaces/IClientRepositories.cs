using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Repositories.Interfaces
{
    public interface IClientRepositories
    {
        Task<List<ClientModel>> GetAllClients();
        Task<ClientModel> GetClientById(int id);
        Task<ClientModel> GetClientByCPF(string CPF);
        Task<ClientModel> AddClient(ClientModel client);
        Task<ClientModel> UpdateClientById(ClientModel client, int id);
        Task<ClientModel> UpdateClientByCPF(ClientModel client, string CPF);
        Task<bool> DeleteClient(string CPF);
    }
}
