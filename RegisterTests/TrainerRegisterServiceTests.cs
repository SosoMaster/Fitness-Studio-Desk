using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.Enums;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class TrainerRegisterServiceTests
    {
        private Mock<ITrainerRepository> _mockTrainerRepo;
        private TrainerRegisterService _trainerRegisterService;

        [SetUp]
        public void SetUp()
        {
            _mockTrainerRepo = new Mock<ITrainerRepository>();
            _trainerRegisterService = new TrainerRegisterService(_mockTrainerRepo.Object);
        }


        [Test]
        public async Task RegisterTrainerAsync_ValidTrainer_CallsRepoAdd()
        {
            var trainer = new Trainer
            {
                UserId = 1,
                Specialty = Specialty.Fitness
            };

            _mockTrainerRepo
                .Setup(r => r.AddAsync(It.IsAny<Trainer>()))
                .Returns(Task.CompletedTask);

            await _trainerRegisterService.RegisterTrainerAsync(trainer);

            _mockTrainerRepo.Verify(r => r.AddAsync(trainer), Times.Once);
        }

        [Test]
        public void RegisterTrainerAsync_UserIdZero_ThrowsException()
        {
            var trainer = new Trainer
            {
                UserId = 0,
                Specialty = Specialty.Yoga
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _trainerRegisterService.RegisterTrainerAsync(trainer));

            Assert.That(ex.Message, Is.EqualTo("Invalid user reference."));
        }

        [Test]
        public void RegisterTrainerAsync_NegativeUserId_ThrowsException()
        {
            var trainer = new Trainer
            {
                UserId = -5,
                Specialty = Specialty.Cardio
            };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _trainerRegisterService.RegisterTrainerAsync(trainer));

            Assert.That(ex.Message, Is.EqualTo("Invalid user reference."));
        }

        [Test]
        public async Task RegisterTrainerAsync_AllSpecialties_DoNotThrow()
        {
            foreach (Specialty specialty in Enum.GetValues(typeof(Specialty)))
            {
                var trainer = new Trainer
                {
                    UserId = 1,
                    Specialty = specialty
                };

                _mockTrainerRepo
                    .Setup(r => r.AddAsync(It.IsAny<Trainer>()))
                    .Returns(Task.CompletedTask);

                Assert.DoesNotThrowAsync(
                    () => _trainerRegisterService.RegisterTrainerAsync(trainer),
                    $"Specialty.{specialty} should be valid but threw.");
            }
        }

        [Test]
        public async Task RegisterTrainerAsync_ValidTrainer_RepoAddCalledOnce()
        {
            var trainer = new Trainer
            {
                UserId = 7,
                Specialty = Specialty.Bodybuilding
            };

            _mockTrainerRepo
                .Setup(r => r.AddAsync(It.IsAny<Trainer>()))
                .Returns(Task.CompletedTask);

            await _trainerRegisterService.RegisterTrainerAsync(trainer);

            _mockTrainerRepo.Verify(
                r => r.AddAsync(It.Is<Trainer>(t => t.UserId == 7)),
                Times.Once);
        }
    }
}