using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class RegisterServiceTests
    {
        private Mock<IUserRepository> _mockUserRepo;
        private Mock<IAdminRepository> _mockAdminRepo;
        private Mock<UserService> _mockUserService;
        private RegisterService _registerService;
        private User _validUser;

        [SetUp]
        public void SetUp()
        {
            _mockUserRepo = new Mock<IUserRepository>();
            _mockAdminRepo = new Mock<IAdminRepository>();
            _mockUserService = new Mock<UserService>(_mockUserRepo.Object);

            _registerService = new RegisterService(
                _mockUserService.Object,
                _mockUserRepo.Object,
                _mockAdminRepo.Object);

            _validUser = new User
            {
                Username = "testuser",
                Email = "test@test.com",
                Phone = "0888000000",
                Password = "secret123"
            };
        }

        [Test]
        public async Task RegisterAsync_DuplicateUsername_ThrowsException()
        {
            _mockUserRepo
                .Setup(r => r.GetByUsernameAsync(_validUser.Username))
                .ReturnsAsync(new User { Username = _validUser.Username });

            var ex = Assert.ThrowsAsync<Exception>(
                () => _registerService.RegisterAsync(_validUser, "Client"));

            Assert.That(ex.Message, Is.EqualTo("Username already exists."));
        }

        [Test]
        public async Task RegisterAsync_InvalidRole_ThrowsException()
        {
            _mockUserRepo
                .Setup(r => r.GetByUsernameAsync(_validUser.Username))
                .ReturnsAsync((User)null);

            _mockUserService
                .Setup(s => s.AddAsync(It.IsAny<User>()))
                .Returns(Task.CompletedTask);

            var ex = Assert.ThrowsAsync<Exception>(
                () => _registerService.RegisterAsync(_validUser, "InvalidRole"));

            Assert.That(ex.Message, Is.EqualTo("Please select a valid role."));
        }

        [Test]
        public async Task RegisterAsync_ClientRole_ReturnsUserWithUserId()
        {
            _mockUserRepo
                .Setup(r => r.GetByUsernameAsync(_validUser.Username))
                .ReturnsAsync((User)null);

            _mockUserService
                .Setup(s => s.AddAsync(It.IsAny<User>()))
                .Callback<User>(u => u.UserId = 1)
                .Returns(Task.CompletedTask);

            var result = await _registerService.RegisterAsync(_validUser, "Client");

            Assert.That(result.UserId, Is.EqualTo(1));
        }

        [Test]
        public async Task RegisterAsync_TrainerRole_ReturnsUser()
        {
            _mockUserRepo
                .Setup(r => r.GetByUsernameAsync(_validUser.Username))
                .ReturnsAsync((User)null);

            _mockUserService
                .Setup(s => s.AddAsync(It.IsAny<User>()))
                .Callback<User>(u => u.UserId = 2)
                .Returns(Task.CompletedTask);

            var result = await _registerService.RegisterAsync(_validUser, "Trainer");

            Assert.That(result.UserId, Is.EqualTo(2));
        }

        [Test]
        public async Task RegisterAsync_AdminRole_CallsAdminRepoAdd()
        {
            _mockUserRepo
                .Setup(r => r.GetByUsernameAsync(_validUser.Username))
                .ReturnsAsync((User)null);

            _mockUserService
                .Setup(s => s.AddAsync(It.IsAny<User>()))
                .Callback<User>(u => u.UserId = 3)
                .Returns(Task.CompletedTask);

            _mockAdminRepo
                .Setup(r => r.AddAsync(It.IsAny<Admin>()))
                .Returns(Task.CompletedTask);

            await _registerService.RegisterAsync(_validUser, "Admin");

            _mockAdminRepo.Verify(
                r => r.AddAsync(It.Is<Admin>(a => a.UserId == 3)),
                Times.Once);
        }

        [Test]
        public void RegisterAsync_EmptyUsername_ThrowsFromUserService()
        {
            var badUser = new User { Username = "", Email = "a@a.com", Phone = "0888", Password = "pass" };

            _mockUserRepo
                .Setup(r => r.GetByUsernameAsync(""))
                .ReturnsAsync((User)null);

            _mockUserService
                .Setup(s => s.AddAsync(It.IsAny<User>()))
                .ThrowsAsync(new Exception("Validation failed."));

            Assert.ThrowsAsync<Exception>(
                () => _registerService.RegisterAsync(badUser, "Client"));
        }
    }
}