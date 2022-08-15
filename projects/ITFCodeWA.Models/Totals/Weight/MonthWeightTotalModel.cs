namespace ITFCodeWA.Models.Totals.Weight
{
    public class MonthWeightTotalsModel : PeriodWeightTotalsModel
    {
        public MonthWeightTotalsModel()
            => Type = PeriodWeightTotalType.Month;
    }
}