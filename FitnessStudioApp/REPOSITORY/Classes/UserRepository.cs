using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class UserRepository: BaseRepository<User>, IUserRepository
{
    public async Task<User> GetByUsernameAsync(string username)
    {
        return await _db.Users.Include(u=> u.Client).Include(u=> u.Trainer).Include(u => u.Admin)
            .FirstOrDefaultAsync(u => u.Username == username);
    }


    public UserRepository(FitnessStudioAppDbContext db) : base(db)
    {

    }
}
