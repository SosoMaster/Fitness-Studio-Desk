using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<IUserRepository> _mockUserRepo;
        private UserService _userService;

        private User _validUser;

        [SetUp]
        public void SetUp()
        {
            _mockUserRepo = new Mock<IUserRepository>();
            _userService = new UserService(_mockUserRepo.Object);

            _validUser = new User
            {
                UserId = 1,
                Username = "testuser",
                Email = "test@test.com",
                Phone = "0888000000",
                Password = "secret123"
            };
        }


        [Test]
        public async Task AddAsync_ValidUser_CallsRepoAdd()
        {
            _mockUserRepo
                .Setup(r => r.AddAsync(It.IsAny<User>()))
                .Returns(Task.CompletedTask);

            await _userService.AddAsync(_validUser);

            _mockUserRepo.Verify(r => r.AddAsync(_validUser), Times.Once);
        }

        [Test]
        public void AddAsync_EmptyUsername_ThrowsException()
        {
            var user = new User
            {
                Username = "",
                Email = "a@a.com",
                Phone = "0888",
                Password = "pass"
            };

          
            Assert.ThrowsAsync<Exception>(() => _userService.AddAsync(user));
        }

        [Test]
        public void AddAsync_EmptyEmail_ThrowsException()
        {
            var user = new User
            {
                Username = "john",
                Email = "",
                Phone = "0888",
                Password = "pass"
            };

            Assert.ThrowsAsync<Exception>(() => _userService.AddAsync(user));
        }

        [Test]
        public void AddAsync_EmptyPassword_ThrowsException()
        {
            var user = new User
            {
                Username = "john",
                Email = "a@a.com",
                Phone = "0888",
                Password = ""
            };

            Assert.ThrowsAsync<Exception>(() => _userService.AddAsync(user));
        }



        [Test]
        public async Task GetByIdAsync_ExistingId_ReturnsUser()
        {
            _mockUserRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(_validUser);

            var result = await _userService.GetByIdAsync(1);

            Assert.That(result.Username, Is.EqualTo("testuser"));
        }

        [Test]
        public void GetByIdAsync_NotFound_ThrowsException()
        {
            _mockUserRepo
                .Setup(r => r.GetByIdAsync(99))
                .ReturnsAsync((User)null);

            var ex = Assert.ThrowsAsync<Exception>(() => _userService.GetByIdAsync(99));
            Assert.That(ex.Message, Is.EqualTo("No found user"));
        }


        [Test]
        public async Task GetAllAsync_UsersExist_ReturnsList()
        {
            _mockUserRepo
                .Setup(r => r.GetAllAsync())
                .ReturnsAsync(new List<User> { _validUser });

            var result = await _userService.GetAllAsync();

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public void GetAllAsync_NoUsers_ThrowsException()
        {
            _mockUserRepo
                .Setup(r => r.GetAllAsync())
                .ReturnsAsync(new List<User>());

            var ex = Assert.ThrowsAsync<Exception>(() => _userService.GetAllAsync());
            Assert.That(ex.Message, Is.EqualTo("No users found"));
        }



        [Test]
        public async Task Delete_ExistingUser_CallsRepoDelete()
        {
            _mockUserRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(_validUser);

            _mockUserRepo
                .Setup(r => r.DeleteAsync(_validUser))
                .Returns(Task.CompletedTask);

            await _userService.Delete(_validUser);

            _mockUserRepo.Verify(r => r.DeleteAsync(_validUser), Times.Once);
        }

        [Test]
        public void Delete_NullUser_ThrowsException()
        {
            var ex = Assert.ThrowsAsync<Exception>(() => _userService.Delete(null));
            Assert.That(ex.Message, Is.EqualTo("User is null"));
        }

        [Test]
        public void Delete_UserNotFound_ThrowsException()
        {
            _mockUserRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync((User)null);

            var ex = Assert.ThrowsAsync<Exception>(() => _userService.Delete(_validUser));
            Assert.That(ex.Message, Is.EqualTo("No user found! Can not delete."));
        }


        [Test]
        public async Task Update_ExistingUser_CallsRepoUpdate()
        {
            _mockUserRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync(_validUser);

            _mockUserRepo
                .Setup(r => r.UpdateAsync(_validUser))
                .Returns(Task.CompletedTask);

            await _userService.Update(_validUser);

            _mockUserRepo.Verify(r => r.UpdateAsync(_validUser), Times.Once);
        }

        [Test]
        public void Update_UserNotFound_ThrowsException()
        {
            _mockUserRepo
                .Setup(r => r.GetByIdAsync(1))
                .ReturnsAsync((User)null);

            var ex = Assert.ThrowsAsync<Exception>(() => _userService.Update(_validUser));
            Assert.That(ex.Message, Is.EqualTo("No found user"));
        }
    }
}