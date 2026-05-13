using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class BookingTrainingService
    {
        private readonly BaseRepository<Booking> _bookingRepo;
        private readonly TrainingSessionRepository _sessionRepo;
        private readonly ClientRepository _clientRepo;

        public BookingTrainingService(
            BaseRepository<Booking> bookingRepo,
            TrainingSessionRepository sessionRepo,
            ClientRepository clientRepo)
        {
            _bookingRepo = bookingRepo;
            _sessionRepo = sessionRepo;
            _clientRepo = clientRepo;
        }

        public async Task AddAsync(Booking booking)
        {
            if (booking == null)
            {
                throw new Exception("Booking is null");
            }

            var client =
                await _clientRepo.GetByIdAsync(booking.ClientId);

            if (client == null)
            {
                throw new Exception("Invalid client");
            }

            var session =
                await _sessionRepo.GetByIdAsync(
                    booking.TrainingSessionId);

            if (session == null)
            {
                throw new Exception("Invalid training session");
            }

            if (session.Capacity <= session.Bookings.Count)
            {
                throw new Exception("No available spots");
            }

            bool alreadyBooked = session.Bookings.Any(
                b => b.ClientId == booking.ClientId &&
                     b.Status == "Active");

            if (alreadyBooked)
            {
                throw new Exception(
                    "Client already has a booking for this session");
            }

            await _bookingRepo.AddAsync(booking);
        }

        public async Task Delete(Booking entity)
        {
            if (entity == null)
            {
                throw new Exception("Booking is null");
            }

            var existing =
                await _bookingRepo.GetByIdAsync(entity.BookingId);

            if (existing == null)
            {
                throw new Exception("No booking found");
            }

            await _bookingRepo.DeleteAsync(existing);
        }

        public async Task<IEnumerable<Booking>> GetAllAsync()
        {
            var bookings = await _bookingRepo.GetAllAsync();

            if (!bookings.Any())
            {
                throw new Exception("No bookings found");
            }

            return bookings;
        }

        public async Task<Booking> GetByIdAsync(int id)
        {
            var booking = await _bookingRepo.GetByIdAsync(id);

            if (booking == null)
            {
                throw new Exception("No booking found");
            }

            return booking;
        }

        public async Task Update(Booking entity)
        {
            if (entity == null)
            {
                throw new Exception("Booking is null");
            }

            var existing =
                await _bookingRepo.GetByIdAsync(entity.BookingId);

            if (existing == null)
            {
                throw new Exception("No booking found");
            }

            await _bookingRepo.UpdateAsync(entity);
        }
    }
}
