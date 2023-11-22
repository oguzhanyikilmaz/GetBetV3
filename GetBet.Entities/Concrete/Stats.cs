namespace GetBet.Entities.Concrete
{
    public class Stats : BaseModel
    {
        public int TotalPlay { get; set; }
        public int TwoUpGoalsPlay { get; set; }
        public int HasMutualScoringPlay { get; set; }
        public int LosePlay { get; set; }
        public DateTime CreateDate { get; set; }
        public double SuccessRatio { get; set; }
    }
}
