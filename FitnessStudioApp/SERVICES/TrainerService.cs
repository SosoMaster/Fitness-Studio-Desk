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

public class TrainerService
{
    private readonly TrainerRepository _trainerRepo;

    public TrainerService(UserService userService, TrainerRepository trainerRepository)
    {
        _trainerRepo = trainerRepository;
    }

    public async Task Delete(Trainer entity)
    {
        if (entity == null)
        {
            throw new Exception("Trainer is null");
        }

        var existing = await _trainerRepo.GetByIdAsync(entity.TrainerId);

        if (existing == null)
        {
            throw new Exception("No trainer found! Cannot delete.");
        }
        await _trainerRepo.DeleteAsync(existing);
    }

    public async Task<IEnumerable<Trainer>> GetAllAsync()
    {
        var trainers = await _trainerRepo.GetAllAsync();

        if (!trainers.Any())
            throw new Exception("No trainers found");

        return trainers;
    }

    public async Task<Trainer> GetByIdAsync(int id)
    {
        var trainer = await _trainerRepo.GetByIdAsync(id);

        if (trainer == null)
        {
            throw new Exception("No trainer found");
        }
        return trainer;
    }

    public async Task Update(Trainer entity)
    {
        TrainerValidator.InfoFieldsValidate(entity);

        var trainer = await _trainerRepo.GetByIdAsync(entity.TrainerId);
        if (trainer == null)
        {
            throw new Exception("No trainer found");
        }

        await _trainerRepo.UpdateAsync(entity);
    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddTrainerWithUserInfo()
    {
        return await _trainerRepo.GetAddTrainerWithUserInfo();
    }

    public async Task<Trainer> GetClientByUserId(int userId)
    {
        return await _trainerRepo.GetClientByUserId(userId);
    }

}
