using System.Net;
using Xunit;

namespace FootballStatsTests
{
    public class BasicTests
    {
        [Fact]
        public void WebClientTest()
        {
            string footballJson = "https://functionapp2018071101324.blob.core.windows.net/data/atches_latest.json"; // I altered the api url, so it's invalid
            using WebClient wc = new WebClient();

            Assert.Throws<WebException>( () => wc.DownloadString(footballJson) );
        }
    }
}
