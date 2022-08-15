using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Documents
{
    /// <summary>
    /// Регистрация работы сердца: давление и сердцебиение
    /// </summary>
    public class HeartWorkRegistrator : RegistratorBase
    {
        public int SystolicValue { get; set; } // нижнее давление

        public int DiastolicValue { get; set; } // верхнее давление

        public int RateValue { get; set; } // кол-во сокращений в минуту
    }
}
