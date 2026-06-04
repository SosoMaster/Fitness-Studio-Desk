
using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY;

public class BaseRepository<T> : IRepository<T> where T : class
{
    protected FitnessStudioAppDbContext _db;
    protected readonly DbSet<T> _dbSet;
    protected readonly ILoggerService _logger;

    public BaseRepository(FitnessStudioAppDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<T>();
        _logger = new LoggerService(typeof(T)); 
    }

    public async Task AddAsync(T entity)
    {
        try
        {
            _logger.Info($"Добавяне на {typeof(T).Name}");
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            _logger.Info($"{typeof(T).Name} добавен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при добавяне на {typeof(T).Name}", ex);
            throw;
        }
    }

    public async Task DeleteAsync(T entity)
    {
        try
        {
            _logger.Info($"Изтриване на {typeof(T).Name}");
            _db.Remove(entity);
            await _db.SaveChangesAsync();
            _logger.Info($"{typeof(T).Name} изтрит успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на {typeof(T).Name}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        try
        {
            _logger.Debug($"Зареждане на всички {typeof(T).Name}");
            return await _dbSet.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на {typeof(T).Name}", ex);
            throw;
        }
    }

    public async Task<T> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на {typeof(T).Name} Id={id}");
            var result = await _dbSet.FindAsync(id);

            if (result == null)
                _logger.Warn($"Не е намерен {typeof(T).Name} с Id={id}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на {typeof(T).Name} Id={id}", ex);
            throw;
        }
    }

    public async Task UpdateAsync(T entity)
    {
        try
        {
            _logger.Info($"Обновяване на {typeof(T).Name}");
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            _logger.Info($"{typeof(T).Name} обновен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на {typeof(T).Name}", ex);
            throw;
        }
    }
}