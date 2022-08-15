using ITFCodeWA.Data.Health.Documents.Base;

namespace ITFCodeWA.Data.Documents
{
    /// <summary>
    /// Регистрация ходьбы: время и расстояние 
    /// </summary>
    public class WalkingRegistrator : RegistratorBase
    {
        public int Duration { get; set; } // пройденное время в минутах

        public double Distance { get; set; } // пройденное расстояние в километрах
    }
}