using ITFCodeWA.Data.Health.Documents;
using ITFCodeWA.Models.Documents;

namespace ITFCodeWA.Helper.DataCollector.Factories
{
    internal static class WeightRegistratorModelFactory
    {
        public static WeightRegistratorModel Create(int number, DateTimeOffset dateMonth, IDictionary<DateTimeOffset, decimal> data)
        {
            var documentId = Guid.NewGuid();
            var rows = new List<WeightRegistratorRowModel>();

            foreach (var row in data)
            {
                rows.Add(new WeightRegistratorRowModel
                {
                    DateDay = row.Key,
                    Weight = row.Value,
                    RowNumber = rows.Count + 1,
                    DocumentId = documentId,
                });
            }

            return new WeightRegistratorModel
            {
                Id = documentId,
                AuthorId = 16,
                Comment = "Создано автоматическим помошником",
                Commited = true,
                Date = DateTimeOffset.Now,
                Marked = false,
                Number = number,
                DateMonth = dateMonth,
                PersonId = 16,
                Rows = rows,
            };
        }
    }
}