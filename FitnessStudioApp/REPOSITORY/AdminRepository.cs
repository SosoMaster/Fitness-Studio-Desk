using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY;

public class AdminRepository : BaseRepository<Admin>
{
    public AdminRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }
}
