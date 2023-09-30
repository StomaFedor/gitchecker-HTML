namespace GitChecker.Tests
{
    public class GitCheckerTests
    {
        [Fact]
        public void CorrectGenerateHtmlFile()
        {
            // Arrange
            var repos = new List<string>() { "repo1", "repo2", "repo3" };
            var matrix = new List<List<string>>() {
                new List<string>() { "100", "44", "77" },
                new List<string>() { "44", "100", "33" },
                new List<string>() { "77", "33", "100" }
            };

            // Act
            var res = GitCheckerHtml.GenerateHTML(repos, matrix);
            // Assert: check downloads!!!
            Assert.Equal(res, true);
        }
    }
}