using FitnessStudioApp.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY;

public class BaseRepository<T> : IRepository<T> where T : class
{
    protected FitnessStudioAppDbContext _db;
    protected readonly DbSet<T> _dbSet;

    public BaseRepository(FitnessStudioAppDbContext db )
    {
        _db = db;
        _dbSet = _db.Set<T>();

    }

    public async Task AddAsync(T entity)
    {
        await _db.AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _db.Remove(entity);
        _db.SaveChanges();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
        
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        _db.SaveChangesAsync();
    }
}
