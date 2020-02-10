using System;
using System.Collections.Generic;

namespace FootballStats.Data
{
    public class Match
    {
        public int Id { get; set; }
        public object Round { get; set; }
        public int RoundNumber { get; set; }
        public DateTime MatchDate { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int Status { get; set; }
        public int PlayedMinutes { get; set; }
        public object SecondHalfStarted { get; set; }
        public DateTime? GameStarted { get; set; }
        public List<MatchEvent> MatchEvents { get; set; }
        public List<object> PeriodResults { get; set; }
        public bool OnlyResultAvailable { get; set; }
        public int Season { get; set; }
        public string Country { get; set; }
        public string League { get; set; }
    }
    

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public object Logo { get; set; }
        public string LogoUrl { get; set; }
        public int Ranking { get; set; }
        public string Message { get; set; }
    }

    public class MatchEvent
    {
        public long Id { get; set; }

        public long MatchId { get; set; }

        public long EventMinute { get; set; }

        public long ElapsedSeconds { get; set; }

        public long TeamId { get; set; }

        public string Description { get; set; }

        public string FullDescription { get; set; }

        public Uri EventTypeIcon { get; set; }

        public string EventType { get; set; }

        public long EventTypeEnum { get; set; }

        public long PlayerId { get; set; }

        public object Player { get; set; }

        public string Identifier { get; set; }

        public object AssistPlayers { get; set; }

        public object AssistPlayerNames { get; set; }

        public object Modifier { get; set; }

        public object Score { get; set; }

        public bool IsGoal { get; set; }
    }
}
