using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;
using System.Security.Policy;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class BookingTrainingServiceTests
    {
        private Mock<BaseRepository<Booking>> _bookingRepoMock;
        private Mock<TrainingSessionRepository> _sessionRepoMock;
        private Mock<ClientRepository> _clientRepoMock;

        private BookingTrainingService _service;

        [SetUp]
        public void Setup()
        {
            var db = new FitnessStudioAppDbContext();

            _bookingRepoMock = new Mock<BaseRepository<Booking>>(db);
            _sessionRepoMock = new Mock<TrainingSessionRepository>(db);
            _clientRepoMock = new Mock<ClientRepository>(db);

            _service = new BookingTrainingService(
                _bookingRepoMock.Object,
                _sessionRepoMock.Object,
                _clientRepoMock.Object);
        }

        [Test]
        public async Task AddAsync_ShouldThrow_WhenBookingIsNull()
        {
            Assert.ThrowsAsync<Exception>(async () =>
                await _service.AddAsync(null));
        }

        [Test]
        public async Task AddAsync_ShouldThrow_WhenClientDoesNotExist()
        {
            Booking booking = new()
            {
                ClientId = 1,
                TrainingSessionId = 1
            };

            _clientRepoMock
                .Setup(x => x.GetByIdAsync(booking.ClientId))
                .ReturnsAsync((Client)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.AddAsync(booking));
        }

        [Test]
        public async Task AddAsync_ShouldThrow_WhenSessionDoesNotExist()
        {
            Booking booking = new()
            {
                ClientId = 1,
                TrainingSessionId = 1
            };

            _clientRepoMock
                .Setup(x => x.GetByIdAsync(booking.ClientId))
                .ReturnsAsync(new Client());

            _sessionRepoMock
                .Setup(x => x.GetByIdAsync(booking.TrainingSessionId))
                .ReturnsAsync((TrainingSession)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.AddAsync(booking));
        }

        [Test]
        public async Task AddAsync_ShouldThrow_WhenNoAvailableSpots()
        {
            Booking booking = new()
            {
                ClientId = 1,
                TrainingSessionId = 1
            };

            TrainingSession session = new()
            {
                TrainingSessionId = 1,
                Capacity = 1,
                Bookings = new List<Booking>
                {
                    new Booking()
                }
            };

            _clientRepoMock
                .Setup(x => x.GetByIdAsync(booking.ClientId))
                .ReturnsAsync(new Client());

            _sessionRepoMock
                .Setup(x => x.GetByIdAsync(booking.TrainingSessionId))
                .ReturnsAsync(session);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.AddAsync(booking));
        }

        [Test]
        public async Task AddAsync_ShouldThrow_WhenClientAlreadyBooked()
        {
            Booking booking = new()
            {
                ClientId = 1,
                TrainingSessionId = 1
            };

            TrainingSession session = new()
            {
                TrainingSessionId = 1,
                Capacity = 10,
                Bookings = new List<Booking>
                {
                    new Booking
                    {
                        ClientId = 1,
                        Status = "Active"
                    }
                }
            };

            _clientRepoMock
                .Setup(x => x.GetByIdAsync(booking.ClientId))
                .ReturnsAsync(new Client());

            _sessionRepoMock
                .Setup(x => x.GetByIdAsync(booking.TrainingSessionId))
                .ReturnsAsync(session);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.AddAsync(booking));
        }

        [Test]
        public async Task AddAsync_ShouldAddBooking_WhenDataIsValid()
        {
            Booking booking = new()
            {
                ClientId = 1,
                TrainingSessionId = 1
            };

            TrainingSession session = new()
            {
                TrainingSessionId = 1,
                Capacity = 10,
                Bookings = new List<Booking>()
            };

            _clientRepoMock
                .Setup(x => x.GetByIdAsync(booking.ClientId))
                .ReturnsAsync(new Client());

            _sessionRepoMock
                .Setup(x => x.GetByIdAsync(booking.TrainingSessionId))
                .ReturnsAsync(session);

            await _service.AddAsync(booking);

            _bookingRepoMock.Verify(
                x => x.AddAsync(booking),
                Times.Once);
        }

        [Test]
        public async Task GetByIdAsync_ShouldThrow_WhenBookingDoesNotExist()
        {
            _bookingRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync((Booking)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.GetByIdAsync(1));
        }

        [Test]
        public async Task GetByIdAsync_ShouldReturnBooking_WhenBookingExists()
        {
            Booking booking = new()
            {
                BookingId = 1
            };

            _bookingRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(booking);

            var result = await _service.GetByIdAsync(1);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.BookingId, Is.EqualTo(1));
        }

        [Test]
        public async Task Delete_ShouldThrow_WhenBookingIsNull()
        {
            Assert.ThrowsAsync<Exception>(async () =>
                await _service.Delete(null));
        }

        [Test]
        public async Task Delete_ShouldDeleteBooking_WhenBookingExists()
        {
            Booking booking = new()
            {
                BookingId = 1
            };

            _bookingRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(booking);

            await _service.Delete(booking);

            _bookingRepoMock.Verify(
                x => x.DeleteAsync(booking),
                Times.Once);
        }
    }
}