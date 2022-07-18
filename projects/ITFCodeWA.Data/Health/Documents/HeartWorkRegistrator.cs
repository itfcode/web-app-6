using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Health.Documents
{
    public class HeartRegistrator : RegistratorBase
    {
        public int SystolicValue { get; set; }

        public int DiastolicValue { get; set; }

        public int RateValue { get; set; }
    }
}
