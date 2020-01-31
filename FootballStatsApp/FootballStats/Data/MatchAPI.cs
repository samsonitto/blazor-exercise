using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;

namespace FootballStats.Data
{
    public class MatchAPI
    {
        public List<Match> matches;
        public List<Match> GetMatches()
        {
            string footballJson = "https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(footballJson);
                var result = JsonSerializer.Deserialize<List<Match>>(json);
                return result;
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
