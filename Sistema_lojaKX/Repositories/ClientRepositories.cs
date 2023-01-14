﻿using Microsoft.EntityFrameworkCore;
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
            return await _dbcontext.Clients.ToListAsync(); 
        }

        public async Task<ClientModel> GetClientByCPF(string CPF)
        {
            return await _dbcontext.Clients.FirstOrDefaultAsync(x => x.CPF == CPF);
        }
        public async Task<ClientModel> AddClient(ClientModel client)
        {
            await _dbcontext.Clients.AddAsync(client);
            await _dbcontext.SaveChangesAsync();
            return client;
        }
        public async Task<ClientModel> UpdateClient(ClientModel client, string CPF)
        {
            ClientModel clientById = await GetClientByCPF(CPF);
            if(clientById == null)
            {
                throw new Exception($"Client for CPF: {CPF} is not found!");
            }
            clientById.Address = client.Address;
            clientById.Name= client.Name;
            clientById.PhoneNumber = client.PhoneNumber;
            clientById.Email = client.Email;

            _dbcontext.Update(clientById);
            await _dbcontext.SaveChangesAsync();

            return clientById;
        }

        public async Task<bool> DeleteClient(string CPF)
        {
            ClientModel clientById = await GetClientByCPF(CPF);
            if (clientById == null)
            {
                throw new Exception($"Client for CPF: {CPF} is not found!");
            }
            _dbcontext.Clients.Remove(clientById);
            await _dbcontext.SaveChangesAsync();
            return true;
        } 
        
    }
}
