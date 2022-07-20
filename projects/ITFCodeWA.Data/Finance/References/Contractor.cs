using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.Finance.References
{
    /// <summary>
    /// Контрагент: поставщик товаров или услуг, потребитель товаров и услуг
    /// </summary>
    public class Contractor : ReferenceBase
    {
        public ICollection<Contract> Contracts { get; set; }
    }
}
