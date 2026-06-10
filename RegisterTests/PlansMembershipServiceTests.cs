using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES;
using Moq;
using NUnit.Framework;

namespace FitnessStudioApp.Tests
{
    [TestFixture]
    public class PlansMembershipServiceTests
    {
        private Mock<MembershipRepository> _membershipRepoMock;

        private PlansMembershipService _service;

        [SetUp]
        public void Setup()
        {
            var db = new FitnessStudioAppDbContext();

            _membershipRepoMock =
                new Mock<MembershipRepository>(db);

            _service =
                new PlansMembershipService(
                    _membershipRepoMock.Object);
        }

        [Test]
        public async Task CreateMembershipAsync_ShouldThrow_WhenMembershipIsNull()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () =>
                await _service.CreateMembershipAsync(null));
        }

        [Test]
        public async Task CreateMembershipAsync_ShouldAddMembership_WhenValid()
        {
            Membership membership = new()
            {
                MembershipId = 1,
            };

            await _service.CreateMembershipAsync(membership);

            _membershipRepoMock.Verify(
                x => x.AddAsync(membership),
                Times.Once);
        }

        [Test]
        public async Task GetMembershipByIdAsync_ShouldThrow_WhenMembershipDoesNotExist()
        {
            _membershipRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync((Membership)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.GetMembershipByIdAsync(1));
        }

        [Test]
        public async Task GetMembershipByIdAsync_ShouldReturnMembership_WhenExists()
        {
            Membership membership = new()
            {
                MembershipId = 1
            };

            _membershipRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(membership);

            var result =
                await _service.GetMembershipByIdAsync(1);

            Assert.That(result, Is.Not.Null);

            Assert.That(
                result.MembershipId,
                Is.EqualTo(1));
        }

        [Test]
        public async Task DeleteMembershipAsync_ShouldThrow_WhenMembershipDoesNotExist()
        {
            _membershipRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync((Membership)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.DeleteMembershipAsync(1));
        }

        [Test]
        public async Task DeleteMembershipAsync_ShouldDeleteMembership_WhenExists()
        {
            Membership membership = new()
            {
                MembershipId = 1
            };

            _membershipRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(membership);

            await _service.DeleteMembershipAsync(1);

            _membershipRepoMock.Verify(
                x => x.DeleteAsync(membership),
                Times.Once);
        }

        [Test]
        public async Task UpdateMembershipAsync_ShouldThrow_WhenMembershipIsNull()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () =>
                await _service.UpdateMembershipAsync(null));
        }

        [Test]
        public async Task UpdateMembershipAsync_ShouldUpdateMembership_WhenValid()
        {
            Membership membership = new()
            {
                MembershipId = 1
            };

            await _service.UpdateMembershipAsync(membership);

            _membershipRepoMock.Verify(
                x => x.UpdateAsync(membership),
                Times.Once);
        }

        [Test]
        public async Task AssignMembershipToClientAsync_ShouldThrow_WhenMembershipDoesNotExist()
        {
            _membershipRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync((Membership)null);

            Assert.ThrowsAsync<Exception>(async () =>
                await _service.AssignMembershipToClientAsync(1, 1));
        }

        [Test]
        public async Task AssignMembershipToClientAsync_ShouldAssignClient_WhenMembershipExists()
        {
            Membership membership = new()
            {
                MembershipId = 1,
                ClientId = 0
            };

            _membershipRepoMock
                .Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(membership);

            await _service.AssignMembershipToClientAsync(1, 5);

            Assert.That(
                membership.ClientId,
                Is.EqualTo(5));

            _membershipRepoMock.Verify(
                x => x.UpdateAsync(membership),
                Times.Once);
        }

        [Test]
        public async Task GetAllMembershipsAsync_ShouldReturnMemberships()
        {
            List<Membership> memberships = new()
            {
                new Membership(),
                new Membership()
            };

            _membershipRepoMock
                .Setup(x => x.GetAllAsync())
                .ReturnsAsync(memberships);

            var result =
                await _service.GetAllMembershipsAsync();

            Assert.That(result.Count(), Is.EqualTo(2));
        }
    }
}