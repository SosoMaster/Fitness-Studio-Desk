using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class PlansMembershipService : IPlansMembershipService
{
    private readonly MembershipRepository _membershipRepo;
    private readonly ILoggerService _logger;

    public PlansMembershipService(MembershipRepository membershipRepo)
    {
        _membershipRepo = membershipRepo;
        _logger = new LoggerService(typeof(PlansMembershipService));
    }

    public async Task AssignMembershipToClientAsync(int membershipId, int clientId)
    {
        try
        {
            _logger.Info($"Присвояване на членство Id={membershipId} към клиент Id={clientId}");

            var membership = await _membershipRepo.GetByIdAsync(membershipId);
            if (membership == null)
            {
                _logger.Warn($"Не е намерено членство Id={membershipId}");
                throw new Exception("Membership not found");
            }

            membership.ClientId = clientId;
            await _membershipRepo.UpdateAsync(membership);
            _logger.Info($"Членство Id={membershipId} е присвоено успешно към клиент Id={clientId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при присвояване на членство Id={membershipId} към клиент Id={clientId}", ex);
            throw;
        }
    }

    public async Task CreateMembershipAsync(Membership membership)
    {
        try
        {
            _logger.Info("Създаване на ново членство");

            if (membership == null)
            {
                _logger.Warn("Опит за създаване на null членство");
                throw new ArgumentNullException(nameof(membership));
            }

            await _membershipRepo.AddAsync(membership);
            _logger.Info("Членството е създадено успешно");
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при създаване на членство", ex);
            throw;
        }
    }

    public async Task DeleteMembershipAsync(int id)
    {
        try
        {
            _logger.Info($"Изтриване на членство Id={id}");

            var membership = await _membershipRepo.GetByIdAsync(id);
            if (membership == null)
            {
                _logger.Warn($"Не е намерено членство Id={id} за изтриване");
                throw new Exception("Membership not found");
            }

            await _membershipRepo.DeleteAsync(membership);
            _logger.Info($"Членство Id={id} е изтрито успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на членство Id={id}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<Membership>> GetAllMembershipsAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички членства");
            return await _membershipRepo.GetAllAsync();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на членства", ex);
            throw;
        }
    }

    public async Task<Membership> GetMembershipByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на членство Id={id}");

            var ms = await _membershipRepo.GetByIdAsync(id);
            if (ms == null)
            {
                _logger.Warn($"Не е намерено членство Id={id}");
                throw new Exception("Membership not found");
            }

            return ms;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на членство Id={id}", ex);
            throw;
        }
    }

    public async Task UpdateMembershipAsync(Membership membership)
    {
        try
        {
            _logger.Info($"Обновяване на членство Id={membership?.MembershipId}");

            if (membership == null)
            {
                _logger.Warn("Опит за обновяване на null членство");
                throw new ArgumentNullException(nameof(membership));
            }

            await _membershipRepo.UpdateAsync(membership);
            _logger.Info($"Членство Id={membership.MembershipId} е обновено успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на членство Id={membership?.MembershipId}", ex);
            throw;
        }
    }
}