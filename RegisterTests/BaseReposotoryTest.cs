using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class BaseReposotoryTest
    {
        private BaseRepository<User> _baseRepository;
        private FitnessStudioAppDbContext _dbContext;
        [SetUp]
        public void SetUp()
        {
            _dbContext = new FitnessStudioAppDbContext();
            _baseRepository = new BaseRepository<User>(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
        }

        [Test]

        public async Task UserAddAsync_ValidEntity_AddsToDatabase()
        {
            
            User user = new User
            {
                Username = "Test",
                Email = "test@email.com",
                Phone = "123",
                Password = "123"

            };
            var allBefore = _dbContext.Set<User>().ToList().Count();
            await _baseRepository.AddAsync(user);
            var allAfter = _dbContext.Set<User>().ToList().Count();
            Assert.That(allAfter, Is.EqualTo(allBefore + 1));
        }

    }
}
