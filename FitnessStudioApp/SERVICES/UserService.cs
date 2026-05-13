using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES.Helpers;

namespace FitnessStudioApp.SERVICES
{
    public class UserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task AddAsync(User entity)
        {
            if (!UserValidator.InfoFieldsValidate(entity))
                throw new Exception("Validation failed.");

            await _userRepo.AddAsync(entity);
        }

        public async Task Delete(User entity)
        {
            if (entity == null)
                throw new Exception("User is null");

            var existing = await _userRepo.GetByIdAsync(entity.UserId);
            if (existing == null)
                throw new Exception("No user found! Can not delete.");

            await _userRepo.DeleteAsync(existing);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _userRepo.GetAllAsync();
            if (!users.Any())
                throw new Exception("No users found");

            return users;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            if (user == null)
                throw new Exception("No found user");

            return user;
        }

        public async Task Update(User entity)
        {
            if (!UserValidator.InfoFieldsValidate(entity))
                throw new Exception("Validation failed.");

            var user = await _userRepo.GetByIdAsync(entity.UserId);
            if (user == null)
                throw new Exception("No found user");

            await _userRepo.UpdateAsync(entity);
        }
    }
}