using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Health.Documents
{
    public class BloodPressureRegistrator : RegistratorBase
    {
        public int SystolicValue { get; set; }

        public int DiastolicValue { get; set; }
    }
}
