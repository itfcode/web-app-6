namespace ITFCodeWA.Models.Totals.Weight
{
    public class WeekWeightTotalsModel : PeriodWeightTotalsModel
    {
        public WeekWeightTotalsModel()
            => Type = PeriodWeightTotalType.Week;
    }
}