using Microsoft.EntityFrameworkCore;
using Sistema_lojaKX.Data;
using Sistema_lojaKX.Models;
using Sistema_lojaKX.Repositories.Interfaces;

namespace Sistema_lojaKX.Repositories
{
    public class ClientRepositories : IClientRepositories
    {
        private readonly PurchaseSystemDBcontext _dbcontext;
        public ClientRepositories(PurchaseSystemDBcontext dBcontext)
        {
            _dbcontext= dBcontext;
        }
        public async Task<List<ClientModel>> GetAllClients()
        {
            return await _dbcontext.Clients
                .ToListAsync(); 
        }
        public async Task<ClientModel> GetClientByCPF(string cpf)
        {
            return await _dbcontext.Clients.FirstOrDefaultAsync(x => x.Cpf == cpf);
        }
        public async Task<ClientModel> AddClient(ClientModel client)
        {
            ClientModel clientByCPF = await GetClientByCPF(client.Cpf);
            if (clientByCPF == null)
            {
                await _dbcontext.Clients.AddAsync(client);
                await _dbcontext.SaveChangesAsync();
                return client;
            }

             throw new Exception($"Client already exists!");
        }
        public async Task<ClientModel> UpdateClientByCPF(ClientModel client, string CPF)
        {
            ClientModel clientByCPF = await GetClientByCPF(CPF);
            if(clientByCPF == null)
            {
                throw new Exception($"Client for CPF: {CPF} is not found!");
            }

            clientByCPF.Name_Client= client.Name_Client;
            clientByCPF.PhoneNumber = client.PhoneNumber;
            clientByCPF.Email = client.Email;

            _dbcontext.Update(clientByCPF);
            await _dbcontext.SaveChangesAsync();

            return clientByCPF;
        }
        public async Task<bool> DeleteClientByCPF(string CPF)
        {
            ClientModel clientByCPF= await GetClientByCPF(CPF);
            if (clientByCPF == null)
            {
                throw new Exception($"Client for CPF: {CPF} is not found!");
            }
            _dbcontext.Clients.Remove(clientByCPF);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

    }
}
