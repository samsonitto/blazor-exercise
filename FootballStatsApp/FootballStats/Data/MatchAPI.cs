using System.Text.Json;
using System.Collections.Generic;
using System.Net;

namespace FootballStats.Data
{
    public class MatchAPI
    {
        public static string error;
        public List<Match> matches;
        public List<Match> GetMatches()
        {
            string footballJson = "https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json";
            using WebClient wc = new WebClient();
            try
            {
                var json = wc.DownloadString(footballJson);
                var result = JsonSerializer.Deserialize<List<Match>>(json);
                return result;
            }
            catch (System.Exception ex)
            {
                error = ex.Message.ToString();
                return null;
            }
        }

        public Match GetMatch(int id)
        {
            var matches = GetMatches();
            foreach(Match match in matches)
            {
                if(id == match.Id)
                {
                    return match;
                }
            }
            return null;
        }
    }
}
