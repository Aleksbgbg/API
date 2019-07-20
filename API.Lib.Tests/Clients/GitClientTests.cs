namespace Api.Lib.Tests.Clients
{
    using System.Threading.Tasks;

    using Api.Lib.Areas;
    using Api.Lib.Clients;

    using Moq;

    using Xunit;

    public class GitClientTests
    {
        private readonly Mock<IWingmanToolAreaProvider> _wingmanAreaMock;

        private readonly GitClient _gitClient;

        public GitClientTests()
        {
            _wingmanAreaMock = new Mock<IWingmanToolAreaProvider>();

            _gitClient = new GitClient(_wingmanAreaMock.Object);
        }

        [Fact]
        public async Task TestGetGitAttributes()
        {
            const string attributes = "SomeAttributes";
            SetupGet("attributes", attributes);

            string getResult = await _gitClient.GetGitAttributes();

            Assert.Equal(attributes, getResult);
        }

        [Fact]
        public async Task TestGetGitIgnore()
        {
            const string ignore = "SomeIgnore";
            SetupGet("ignore", ignore);

            string getResult = await _gitClient.GetGitIgnore();

            Assert.Equal(ignore, getResult);
        }

        private void SetupGet(string handler, string result)
        {
            _wingmanAreaMock.Setup(area => area.Get($"git/{handler}"))
                            .Returns(Task.FromResult(result));
        }
    }
}