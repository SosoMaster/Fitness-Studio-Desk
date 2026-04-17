using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class UserRepository: BaseRepository<User>, IUserRepository
{
    public UserRepository(FitnessStudioAppDbContext db) : base(db)
    {

    }
}
