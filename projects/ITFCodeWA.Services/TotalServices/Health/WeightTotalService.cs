using ITFCodeWA.Domain.Repositories.Documents.Interfaces;
using ITFCodeWA.Extensions.DateTimeOffsetExtendors;
using ITFCodeWA.Models.Totals;
using ITFCodeWA.Models.Totals.Weight;
using ITFCodeWA.Services.TotalServices.Base;
using ITFCodeWA.Services.TotalServices.Health.Interfaces;
using Microsoft.EntityFrameworkCore;
using static System.Math;

namespace ITFCodeWA.Services.TotalServices.Health
{
    public class WeightTotalService : TotalService, IWeightTotalService
    {
        protected IWeightRegistratorRepository _repository;

        public WeightTotalService(IWeightRegistratorRepository repository)
        {
            _repository = repository;
        }

        public async Task<PersonWeightTotalsModel> GetPersonTotalsAsync(int personId, CancellationToken cancellationToken = default)
        {
            var items = await _repository.GetDBSetQuery()
                .Where(x => x.PersonId == personId)
                .SelectMany(x => x.Rows)
                .Where(x => x.Weight != 0)
                .Select(x => new
                {
                    Date = x.DateDay,
                    x.Weight
                })
                .ToListAsync();

            var totals = items.GroupBy(x => x.Date.Year)
                .Select(x => new YearWeightTotalsModel
                {
                    Period = x.Key,
                    PeriodDate = x.First().Date.YearStart(),
                    Avg = Round(x.Average(a => a.Weight), 1),
                    Min = Round(x.Min(a => a.Weight), 1),
                    Max = Round(x.Max(a => a.Weight), 1),
                    SubTotals = x.GroupBy(m => m.Date.Month)
                        .Select(m => new MonthWeightTotalsModel
                        {
                            Period = m.Key,
                            PeriodDate = m.First().Date.MonthStart(),
                            Max = Round(m.Max(a => a.Weight), 1),
                            Min = Round(m.Min(a => a.Weight), 1),
                            Avg = Round(m.Average(a => a.Weight), 1)
                        } as PeriodWeightTotalsModel)
                        .ToList()
                } as PeriodWeightTotalsModel)
                .ToList();

            var weekCounter = 0;
            var weekTotals = items.GroupBy(x => x.Date.WeekStart())
                .Select(x => new WeekWeightTotalsModel
                {
                    Period = ++weekCounter,
                    PeriodDate = x.Key,
                    Avg = Round(x.Average(a => a.Weight), 1),
                    Min = Round(x.Min(a => a.Weight), 1),
                    Max = Round(x.Max(a => a.Weight), 1),
                })
                .ToList();

            return new PersonWeightTotalsModel
            {
                PersonId = personId,
                PersonFullname = "DDD",
                Totals = totals,
                WeekTotals = weekTotals
            };
        }

        #region Private & Protected Methods 


        #endregion
    }
}