using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Documents
{
    /// <summary>
    /// Регистрация веса
    /// </summary>
    public class WeightRegistrator : RegistratorBase
    {
        public DateTimeOffset DateMonth { get; set; }

        public ICollection<WeightRegistratorRow> Rows { get; set; }

    }
}
