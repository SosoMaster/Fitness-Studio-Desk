using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class ProgressServiceTests
    {
        private Mock<IProgressRepository> _mockProgressRepo;
        private ProgressService _progressService;

        [SetUp]
        public void SetUp()
        {
            _mockProgressRepo = new Mock<IProgressRepository>();
            _progressService = new ProgressService(_mockProgressRepo.Object);
        }

        [Test]
        public void CalculateBMI_NormalValues_ReturnsCorrectBMI()
        {
            double bmi = _progressService.CalculateBMI(80, 180);
            Assert.That(bmi, Is.EqualTo(24.69).Within(0.01));
        }

        [Test]
        public void CalculateBMI_LightweightShortPerson_ReturnsCorrectBMI()
        {
            double bmi = _progressService.CalculateBMI(50, 160);
            Assert.That(bmi, Is.EqualTo(19.53).Within(0.01));
        }

        [Test]
        public void CalculateBMI_HeavyweightTallPerson_ReturnsCorrectBMI()
        {
            double bmi = _progressService.CalculateBMI(120, 190);
            Assert.That(bmi, Is.EqualTo(33.24).Within(0.01));
        }

        [TestCase(80, 180, 24.69)]
        [TestCase(60, 170, 20.76)]
        [TestCase(100, 175, 32.65)]
        public void CalculateBMI_MultipleInputs_ReturnsExpected(double weight, int height, double expected)
        {
            double bmi = _progressService.CalculateBMI(weight, height);
            Assert.That(bmi, Is.EqualTo(expected).Within(0.01));
        }


        [Test]
        public void CalculateBodyFat_Male30BMI27_ReturnsApprox23()
        {
            double bf = _progressService.CalculateBodyFat(27, 30, "Male");
            Assert.That(bf, Is.EqualTo(23.1).Within(0.1));
        }

        [Test]
        public void CalculateBodyFat_Female_ReturnsHigherThanMale()
        {
            double bfFemale = _progressService.CalculateBodyFat(22, 25, "Female");
            double bfMale = _progressService.CalculateBodyFat(22, 25, "Male");
            Assert.That(bfFemale, Is.GreaterThan(bfMale));
        }

        [Test]
        public void CalculateBodyFat_OlderPerson_ReturnsHigherThanYounger()
        {
            double bfOld = _progressService.CalculateBodyFat(25, 60, "Male");
            double bfYoung = _progressService.CalculateBodyFat(25, 25, "Male");
            Assert.That(bfOld, Is.GreaterThan(bfYoung));
        }

        [Test]
        public void CalculateBodyFat_GenderCaseInsensitive_ReturnsSameResult()
        {
            double bf1 = _progressService.CalculateBodyFat(25, 30, "Male");
            double bf2 = _progressService.CalculateBodyFat(25, 30, "male");
            Assert.That(bf1, Is.EqualTo(bf2).Within(0.001));
        }


        [Test]
        public void HealthyBodyFatRange_YoungMale_Returns8To19()
        {
            var (min, max) = _progressService.HealthyBodyFatRange("Male", 25);
            Assert.That(min, Is.EqualTo(8));
            Assert.That(max, Is.EqualTo(19));
        }

        [Test]
        public void HealthyBodyFatRange_YoungFemale_Returns21To33()
        {
            var (min, max) = _progressService.HealthyBodyFatRange("Female", 25);
            Assert.That(min, Is.EqualTo(21));
            Assert.That(max, Is.EqualTo(33));
        }

        [Test]
        public void HealthyBodyFatRange_MiddleAgeMale_Returns11To22()
        {
            var (min, max) = _progressService.HealthyBodyFatRange("Male", 50);
            Assert.That(min, Is.EqualTo(11));
            Assert.That(max, Is.EqualTo(22));
        }

        [Test]
        public void HealthyBodyFatRange_MiddleAgeFemale_Returns23To35()
        {
            var (min, max) = _progressService.HealthyBodyFatRange("Female", 50);
            Assert.That(min, Is.EqualTo(23));
            Assert.That(max, Is.EqualTo(35));
        }

        [Test]
        public void HealthyBodyFatRange_OldMale_Returns13To25()
        {
            var (min, max) = _progressService.HealthyBodyFatRange("Male", 65);
            Assert.That(min, Is.EqualTo(13));
            Assert.That(max, Is.EqualTo(25));
        }

        [Test]
        public void HealthyBodyFatRange_OldFemale_Returns24To36()
        {
            var (min, max) = _progressService.HealthyBodyFatRange("Female", 65);
            Assert.That(min, Is.EqualTo(24));
            Assert.That(max, Is.EqualTo(36));
        }


        [Test]
        public void LoseFatRecommendation_BodyFatWithinRange_ReturnsMaintainMessage()
        {
            string result = _progressService.LoseFatRecommendation(15, 22, "Male", 25);
            Assert.That(result, Does.Contain("already within the healthy range"));
        }

        [Test]
        public void LoseFatRecommendation_BodyFatAboveRange_ReturnsRecommendation()
        {
            string result = _progressService.LoseFatRecommendation(28, 27, "Male", 25);
            Assert.That(result, Does.Contain("caloric deficit"));
            Assert.That(result, Does.Contain("cardio"));
        }

        [Test]
        public void LoseFatRecommendation_AboveRange_ContainsExcessFatValue()
        {
            string result = _progressService.LoseFatRecommendation(28, 27, "Male", 25);
            Assert.That(result, Does.Contain("9.0%").Or.Contain("9,0%"));
        }

        [Test]
        public void LoseFatRecommendation_FemaleWithinRange_ReturnsMaintainMessage()
        {
            string result = _progressService.LoseFatRecommendation(30, 23, "Female", 25);
            Assert.That(result, Does.Contain("already within the healthy range"));
        }


        [Test]
        public void GainMuscleRecommendation_NormalBF_ReturnsMuscleAdvice()
        {
            string result = _progressService.GainMuscleRecommendation(15, 22, "Male", 25);
            Assert.That(result, Does.Contain("Caloric surplus"));
            Assert.That(result, Does.Contain("Protein"));
        }

        [Test]
        public void GainMuscleRecommendation_BFBelowMin_ContainsWarning()
        {
            string result = _progressService.GainMuscleRecommendation(5, 20, "Male", 25);
            Assert.That(result, Does.Contain("below the healthy minimum"));
        }

        [Test]
        public void GainMuscleRecommendation_BFAboveMin_NoUnderweightWarning()
        {
            string result = _progressService.GainMuscleRecommendation(15, 22, "Male", 25);
            Assert.That(result, Does.Not.Contain("below the healthy minimum"));
        }

        [Test]
        public void GainMuscleRecommendation_AlwaysContainsBMI()
        {
            string result = _progressService.GainMuscleRecommendation(15, 22, "Male", 25);
            Assert.That(result, Does.Contain("BMI"));
        }


        [Test]
        public async Task SaveProgressAsync_ValidProgress_CallsRepoAdd()
        {
            var progress = new Progress
            {
                ClientId = 1,
                Age = 25,
                Gender = "Male",
                Height = 180,
                Weight = 80
            };

            _mockProgressRepo
                .Setup(r => r.AddAsync(It.IsAny<Progress>()))
                .Returns(Task.CompletedTask);

            await _progressService.SaveProgressAsync(progress);

            _mockProgressRepo.Verify(r => r.AddAsync(progress), Times.Once);
        }

        [Test]
        public void SaveProgressAsync_InvalidClientId_ThrowsException()
        {
            var progress = new Progress { ClientId = 0, Height = 180, Weight = 80 };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _progressService.SaveProgressAsync(progress));

            Assert.That(ex.Message, Is.EqualTo("Invalid client reference."));
        }

        [Test]
        public void SaveProgressAsync_ZeroHeight_ThrowsException()
        {
            var progress = new Progress { ClientId = 1, Height = 0, Weight = 80 };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _progressService.SaveProgressAsync(progress));

            Assert.That(ex.Message, Is.EqualTo("Height must be greater than 0."));
        }

        [Test]
        public void SaveProgressAsync_ZeroWeight_ThrowsException()
        {
            var progress = new Progress { ClientId = 1, Height = 180, Weight = 0 };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _progressService.SaveProgressAsync(progress));

            Assert.That(ex.Message, Is.EqualTo("Weight must be greater than 0."));
        }

        [Test]
        public void SaveProgressAsync_NegativeWeight_ThrowsException()
        {
            var progress = new Progress { ClientId = 1, Height = 180, Weight = -5 };

            var ex = Assert.ThrowsAsync<Exception>(
                () => _progressService.SaveProgressAsync(progress));

            Assert.That(ex.Message, Is.EqualTo("Weight must be greater than 0."));
        }

        [Test]
        public async Task GetAllProgressAsync_ReturnsOnlyMatchingClientId()
        {
            var data = new List<Progress>
            {
                new Progress { ClientId = 1, Height = 180, Weight = 80 },
                new Progress { ClientId = 1, Height = 180, Weight = 75 },
                new Progress { ClientId = 2, Height = 170, Weight = 65 },
            };

            _mockProgressRepo
                .Setup(r => r.GetAllAsync())
                .ReturnsAsync(data);

            var result = await _progressService.GetAllProgressAsync(1);

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.All(p => p.ClientId == 1), Is.True);
        }

        [Test]
        public async Task GetAllProgressAsync_NoMatchingEntries_ReturnsEmptyList()
        {
            var data = new List<Progress>
            {
                new Progress { ClientId = 2, Height = 170, Weight = 65 }
            };

            _mockProgressRepo
                .Setup(r => r.GetAllAsync())
                .ReturnsAsync(data);

            var result = await _progressService.GetAllProgressAsync(99);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task GetAllProgressAsync_EmptyRepo_ReturnsEmptyList()
        {
            _mockProgressRepo
                .Setup(r => r.GetAllAsync())
                .ReturnsAsync(new List<Progress>());

            var result = await _progressService.GetAllProgressAsync(1);

            Assert.That(result, Is.Empty);
        }
    }
}