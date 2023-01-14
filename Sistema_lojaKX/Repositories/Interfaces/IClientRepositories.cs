using Sistema_lojaKX.Models;

namespace Sistema_lojaKX.Repositories.Interfaces
{
    public interface IClientRepositories
    {
        Task<List<ClientModel>> GetAllClients();

        Task<ClientModel> GetClientByCPF(string CPF);
        Task<ClientModel> AddClient(ClientModel client);

        Task<ClientModel> UpdateClientByCPF(ClientModel client, string CPF);
        Task<bool> DeleteClientByCPF(string CPF);

    }
}
