using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Documents
{
    /// <summary>
    /// Регистрация веса дням
    /// </summary>
    public class WeightRegistratorRow : RegistratorRowBase
    {
        public DateTimeOffset DateDay { get; set; }

        public decimal Weight { get; set; }

        public WeightRegistrator WeightRegistrator { get; set; }
    }
}