using System;

namespace BilgeAdam.SomePatterns.Builder.Models
{
    class HistoryData
    {
        public HistoryData(Team team)
        {
            RegistrationDate = DateTime.Now;
            Team = team;
        }
        public DateTime RegistrationDate { get; }
        public Team Team { get; }
    }
}