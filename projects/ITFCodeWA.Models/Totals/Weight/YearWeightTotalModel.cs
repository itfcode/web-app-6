namespace ITFCodeWA.Models.Totals.Weight
{
    public class YearWeightTotalsModel : PeriodWeightTotalsModel
    {
        public YearWeightTotalsModel()
            => Type = PeriodWeightTotalType.Year;
    }
}