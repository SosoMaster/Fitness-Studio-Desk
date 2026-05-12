using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class ClientService 
{
    private readonly ClientRepository _clientRepo;
    public ClientService(ClientRepository clientRepository)
    {
       
        _clientRepo = clientRepository;
        
    }

    public async Task Delete(Client entity)
    {
        if (entity == null)
        {
            throw new Exception("User is null");
        }

        var existing = await _clientRepo.GetByIdAsync(entity.ClientId);

        if (existing == null)
        {
            throw new Exception("No user found! Can not delete.");
        }
        await _clientRepo.DeleteAsync(existing);
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        var clients = await _clientRepo.GetAllAsync();

        if (!clients.Any())
            throw new Exception("No clients found");   // може и без това?

        return clients;
    }

    public async Task<Client> GetByIdAsync(int id)
    {
        var client = await _clientRepo.GetByIdAsync(id);

        if (client == null)
        {
            throw new Exception("No client user");
        }
        return client;
    }

    public async Task Update(Client entity)
    {
       if (!ClientValidator.InfoFieldsValidate(entity))
        {
            throw new Exception("Invalid client");
            
        }

        var client = await _clientRepo.GetByIdAsync(entity.ClientId);
        if (client == null)
        {
            throw new Exception("No client found");
        }

         await _clientRepo.UpdateAsync(entity);

    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddClientWithUserInfo()
    {
        return await _clientRepo.GetAddClientWithUserInfo();
    }

    public async Task<Client> GetClientByUserId (int userId)
    {
        return await _clientRepo.GetClientByUserId(userId);
    }
}
