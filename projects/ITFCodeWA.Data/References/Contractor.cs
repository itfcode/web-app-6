using ITFCodeWA.Core.Data.References;

namespace ITFCodeWA.Data.References
{
    /// <summary>
    /// Контрагент: поставщик товаров или услуг, потребитель товаров и услуг
    /// </summary>
    public class Contractor : ReferenceBase
    {
        public string TaxNumber { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
