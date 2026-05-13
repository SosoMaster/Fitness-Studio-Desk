using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.Enums;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;
using System.Windows.Forms;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class ClientRegisterServiceTests
    {
        private Mock<IClientRepository> _mockClientRepo;
        private ClientRegisterService _clientRegisterService;

        [SetUp]
        public void SetUp()
        {
            _mockClientRepo = new Mock<IClientRepository>();
            _clientRegisterService = new ClientRegisterService(_mockClientRepo.Object);
        }


        [Test]
        public async Task RegisterClientAsync_ValidClient_CallsRepoAdd()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 25,
                Gender = "Male",
                Height = 180,
                Weight = 80
            };

            _mockClientRepo
                .Setup(r => r.AddAsync(It.IsAny<Client>()))
                .Returns(Task.CompletedTask);

            await _clientRegisterService.RegisterClientAsync(client);

            _mockClientRepo.Verify(r => r.AddAsync(client), Times.Once);
        }

        [Test]
        public void RegisterClientAsync_ValidClient_SetsMembershipStatusInactive()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 25,
                Gender = "Male",
                Height = 180,
                Weight = 80
            };

            _mockClientRepo
                .Setup(r => r.AddAsync(It.IsAny<Client>()))
                .Returns(Task.CompletedTask);

            _mockClientRepo
                .Setup(r => r.AddAsync(It.IsAny<Client>()))
                .Callback<Client>(c =>
                    Assert.That(c.MembershipStatus, Is.EqualTo(MembershipStatus.Inactive)))
                .Returns(Task.CompletedTask);

            Assert.DoesNotThrowAsync(() => _clientRegisterService.RegisterClientAsync(client));
        }

        [Test]
        public void RegisterClientAsync_AgeZero_ThrowsException()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 0,
                Gender = "Male",
                Height = 180,
                Weight = 80
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _clientRegisterService.RegisterClientAsync(client));

            Assert.That(ex.Message, Does.Contain("valid age"));
        }

        [Test]
        public void RegisterClientAsync_AgeOver120_ThrowsException()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 150,
                Gender = "Male",
                Height = 180,
                Weight = 80
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _clientRegisterService.RegisterClientAsync(client));

            Assert.That(ex.Message, Does.Contain("valid age"));
        }

        [Test]
        public void RegisterClientAsync_HeightZero_ThrowsException()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 25,
                Gender = "Male",
                Height = 0,
                Weight = 80
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _clientRegisterService.RegisterClientAsync(client));

            Assert.That(ex.Message, Does.Contain("valid height"));
        }

        [Test]
        public void RegisterClientAsync_WeightZero_ThrowsException()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 25,
                Gender = "Male",
                Height = 180,
                Weight = 0
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _clientRegisterService.RegisterClientAsync(client));

            Assert.That(ex.Message, Does.Contain("valid weight"));
        }

        [Test]
        public void RegisterClientAsync_EmptyGender_ThrowsException()
        {
            var client = new Client
            {
                UserId = 1,
                Age = 25,
                Gender = "",
                Height = 180,
                Weight = 80
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _clientRegisterService.RegisterClientAsync(client));

            Assert.That(ex.Message, Does.Contain("gender"));
        }


        [Test]
        public void Gender_MaleChecked_ReturnsMale()
        {
            var rdbMale = new RadioButton { Checked = true };
            var rdbFemale = new RadioButton { Checked = false };

            var result = _clientRegisterService.Gender(rdbMale, rdbFemale);

            Assert.That(result, Is.EqualTo("Male"));
        }

        [Test]
        public void Gender_FemaleChecked_ReturnsFemale()
        {
            var rdbMale = new RadioButton { Checked = false };
            var rdbFemale = new RadioButton { Checked = true };

            var result = _clientRegisterService.Gender(rdbMale, rdbFemale);

            Assert.That(result, Is.EqualTo("Female"));
        }

        [Test]
        public void Gender_NeitherChecked_ThrowsException()
        {
            var rdbMale = new RadioButton { Checked = false };
            var rdbFemale = new RadioButton { Checked = false };

            var ex = Assert.Throws<Exception>(
                () => _clientRegisterService.Gender(rdbMale, rdbFemale));

            Assert.That(ex.Message, Does.Contain("gender"));
        }
    }
}