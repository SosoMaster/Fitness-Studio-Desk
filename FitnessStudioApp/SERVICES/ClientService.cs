using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class ClientService
{
    private readonly UserService _userService;
    private readonly ClientRepository _clientRepo;
    public ClientService(UserService userService, ClientRepository clientRepository)
    {
        _userService = userService;
        _clientRepo = clientRepository;
    }






}
