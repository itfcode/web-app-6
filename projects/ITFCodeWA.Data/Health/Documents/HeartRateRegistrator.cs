using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Health.Documents
{
    /// <summary>
    /// Регистрация сердцебиения 
    /// </summary>
    public class HeartRateRegistrator : RegistratorBase
    {
        public int Value { get; set; }
    }
}
