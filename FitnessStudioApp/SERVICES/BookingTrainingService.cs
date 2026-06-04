using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class BookingTrainingService
{
    private readonly BaseRepository<Booking> _bookingRepo;
    private readonly TrainingSessionRepository _sessionRepo;
    private readonly ClientRepository _clientRepo;
    private readonly ILoggerService _logger;

    public BookingTrainingService(
        BaseRepository<Booking> bookingRepo,
        TrainingSessionRepository sessionRepo,
        ClientRepository clientRepo)
    {
        _bookingRepo = bookingRepo;
        _sessionRepo = sessionRepo;
        _clientRepo = clientRepo;
        _logger = new LoggerService(typeof(BookingTrainingService));
    }

    public async Task AddAsync(Booking booking)
    {
        try
        {
            _logger.Info($"Добавяне на резервация за клиент Id={booking?.ClientId}");

            if (booking == null)
            {
                _logger.Warn("Опит за добавяне на null резервация");
                throw new Exception("Booking is null");
            }

            var client = await _clientRepo.GetByIdAsync(booking.ClientId);
            if (client == null)
            {
                _logger.Warn($"Невалиден клиент Id={booking.ClientId}");
                throw new Exception("Invalid client");
            }

            var session = await _sessionRepo.GetByIdAsync(booking.TrainingSessionId);
            if (session == null)
            {
                _logger.Warn($"Невалидна сесия Id={booking.TrainingSessionId}");
                throw new Exception("Invalid training session");
            }

            if (session.Capacity <= session.Bookings.Count)
            {
                _logger.Warn($"Няма свободни места за сесия Id={booking.TrainingSessionId}");
                throw new Exception("No available spots");
            }

            bool alreadyBooked = session.Bookings.Any(
                b => b.ClientId == booking.ClientId && b.Status == "Active");

            if (alreadyBooked)
            {
                _logger.Warn($"Клиент Id={booking.ClientId} вече има резервация за сесия Id={booking.TrainingSessionId}");
                throw new Exception("Client already has a booking for this session");
            }

            await _bookingRepo.AddAsync(booking);
            _logger.Info($"Резервацията е добавена успешно за клиент Id={booking.ClientId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при добавяне на резервация за клиент Id={booking?.ClientId}", ex);
            throw;
        }
    }

    public async Task Delete(Booking entity)
    {
        try
        {
            _logger.Info($"Изтриване на резервация Id={entity?.BookingId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null резервация");
                throw new Exception("Booking is null");
            }

            var existing = await _bookingRepo.GetByIdAsync(entity.BookingId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерена резервация Id={entity.BookingId} за изтриване");
                throw new Exception("No booking found");
            }

            await _bookingRepo.DeleteAsync(existing);
            _logger.Info($"Резервация Id={entity.BookingId} е изтрита успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на резервация Id={entity?.BookingId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<Booking>> GetAllAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички резервации");

            var bookings = await _bookingRepo.GetAllAsync();
            if (!bookings.Any())
            {
                _logger.Warn("Няма намерени резервации");
                throw new Exception("No bookings found");
            }

            return bookings;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на резервации", ex);
            throw;
        }
    }

    public async Task<Booking> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на резервация Id={id}");

            var booking = await _bookingRepo.GetByIdAsync(id);
            if (booking == null)
            {
                _logger.Warn($"Не е намерена резервация Id={id}");
                throw new Exception("No booking found");
            }

            return booking;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на резервация Id={id}", ex);
            throw;
        }
    }

    public async Task Update(Booking entity)
    {
        try
        {
            _logger.Info($"Обновяване на резервация Id={entity?.BookingId}");

            if (entity == null)
            {
                _logger.Warn("Опит за обновяване на null резервация");
                throw new Exception("Booking is null");
            }

            var existing = await _bookingRepo.GetByIdAsync(entity.BookingId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерена резервация Id={entity.BookingId} за обновяване");
                throw new Exception("No booking found");
            }

            await _bookingRepo.UpdateAsync(entity);
            _logger.Info($"Резервация Id={entity.BookingId} е обновена успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на резервация Id={entity?.BookingId}", ex);
            throw;
        }
    }
}