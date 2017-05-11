using System;

namespace KnowledgeTest.BLL.Model.Test
{
    public class TestSettingsModel
    {
        public bool IsLimitedTime { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public bool IsSpendingTimeShow { get; set; }
        public bool IsShowResults { get; set; }
    }
}
