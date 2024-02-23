namespace GetBet.Entities.Concrete
{
    public class Play : BaseModel
    {
        public string MatchId { get; set; }
        public DateTime DateTime { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public double? Data { get; set; }
        public double? ZeroAndOneGoal { get; set; }
        public double? FourFiveGoal { get; set; }
        public double? MS1 { get; set; }
        public double? MS2 { get; set; }
        public double? IY0 { get; set; }
        public double? IY1MS0 { get; set; }
        public double? IY2MS0 { get; set; }
        public double? Score10 { get; set; }
        public double? Score01 { get; set; }
        public int? ScoreTeam1 { get; set; }
        public int? ScoreTeam2 { get; set; }
        public double? HomeUp05 { get; set; }
        public double? AwayUp05 { get; set; }
        public double? KgRatio { get; set; }
        public double? Up15Ratio { get; set; }
        public double? Up25Ratio { get; set; }

        public bool HasMutualScoring { get; set; }
        public bool TwoUpGoals { get; set; }
        public bool IsIY0MS12 { get; set; }
    }
}
