using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class AdminRepository : BaseRepository<Admin>, IAdminRepository
{
    public AdminRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }
}
