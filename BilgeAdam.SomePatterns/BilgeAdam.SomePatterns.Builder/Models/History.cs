using System;
using System.Collections.Generic;

namespace BilgeAdam.SomePatterns.Builder.Models
{
    class History
    {
        public History()
        {
            historyData = new List<HistoryData>();
        }

        public void AddHistory(Team team)
        {
            var data = new HistoryData(team);
            historyData.Add(data);
        }
        private List<HistoryData> historyData { get; set; }
        public IReadOnlyCollection<HistoryData> HistoryData => historyData.AsReadOnly();
    }
}