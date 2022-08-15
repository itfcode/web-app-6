using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Static.ColumnSettings
{
    public static partial class ColumnSettingSets
    {
        public static IReadOnlyList<ColumnSetting<FoodModel>> Foods =>
            new List<ColumnSetting<FoodModel>>
            {
                Create<FoodModel>(name: nameof(FoodModel.Name), label: "Наименование", view: x => x.Name),
                Create<FoodModel>(name: nameof(FoodModel.Calories), label: "Каллории", view: x => x.Calories),
                Create<FoodModel>(name: nameof(FoodModel.Proteins), label: "Белки", view: x => x.Proteins),
                Create<FoodModel>(name: nameof(FoodModel.Fats), label: "Жири", view: x => x.Fats),
                Create<FoodModel>(name: nameof(FoodModel.Carbohydrates), label: "Углеводы", view: x => x.Carbohydrates),
            };

        public static IReadOnlyList<ColumnSetting<PersonModel>> Persons =>
            new List<ColumnSetting<PersonModel>>
            {
                Create<PersonModel>(name: nameof(PersonModel.FirstName), label: "Имя",  view: x => x.FirstName),
                Create<PersonModel>(name: nameof(PersonModel.MiddleName),label: "Отчество", view: x => x.MiddleName),
                Create<PersonModel>(name: nameof(PersonModel.LastName), label: "Фамилия", view: x => x.LastName),
                Create<PersonModel>(name: nameof(PersonModel.Utr), label: "ИНН", view: x => x.Utr),
            };

        public static IReadOnlyList<ColumnSetting<GoodModel>> Goods =>
            new List<ColumnSetting<GoodModel>>
            {
                Create<GoodModel>(name: nameof(GoodModel.Name), label: "Наименование", view: x => x.Name),
                Create<GoodModel>(name: nameof(GoodModel.RevenueItemName), label: "Статья доходов", view: x => x.RevenueItemName),
                Create<GoodModel>(name: nameof(GoodModel.ExpenseItemName), label: "Статья расходов", view: x => x.ExpenseItemName),
                Create<GoodModel>(name: nameof(GoodModel.Comment), label: "Комментарий", view: x => x.Comment),
            };

        public static IReadOnlyList<ColumnSetting<ContractorModel>> Contractors =>
            new List<ColumnSetting<ContractorModel>> 
            {
                Create<ContractorModel>(name: nameof(ContractorModel.Name), label: "Наименование", view: x => x.Name),
                Create<ContractorModel>(name: nameof(ContractorModel.TaxNumber), label: "Налоговый номер", view: x => x.TaxNumber),
                Create<ContractorModel>(name: nameof(ContractorModel.Comment), label: "Комментарий", view: x => x.Comment),
            };

        public static IReadOnlyList<ColumnSetting<ContractModel>> Contracts =>
            new List<ColumnSetting<ContractModel>> 
            {
                Create<ContractModel>(name: nameof(ContractModel.ContractorName), label: "Контрагент", view: x => x.Name),
                Create<ContractModel>(name: nameof(ContractModel.Name), label: "Наименование", view: x => x.Name),
                Create<ContractModel>(name: nameof(ContractModel.StartDate), label: "Дата начала", view: x => x.StartDate),
                Create<ContractModel>(name: nameof(ContractModel.FinishDate), label: "Дата окончания", view: x => x.FinishDate),
                Create<ContractModel>(name: nameof(ContractModel.TotalCost), label: "Сумма", view: x => x.Name),
            };

        public static IReadOnlyList<ColumnSetting<CurrencyModel>> Currencies =>
            new List<ColumnSetting<CurrencyModel>>
            {
                Create<CurrencyModel>(name: nameof(CurrencyModel.Code), label: "Код цифровой", view: x => x.Code),
                Create<CurrencyModel>(name: nameof(CurrencyModel.ShortName), label: "Код буквенный ", view: x => x.ShortName),
                Create<CurrencyModel>(name: nameof(CurrencyModel.Name), label: "Наименование", view: x => x.Name),
            };

        public static IReadOnlyList<ColumnSetting<RevenueItemModel>> RevenueItems =>
            new List<ColumnSetting<RevenueItemModel>>
            {
                Create<RevenueItemModel>(name: nameof(RevenueItemModel.Name), label: "Наименование", view: x => x.Name),
            };

        public static IReadOnlyList<ColumnSetting<ExpenseItemModel>> ExpenseItems =>
            new List<ColumnSetting<ExpenseItemModel>>
            {
                Create<ExpenseItemModel>(name: nameof(ExpenseItemModel.Name), label: "Наименование", view: x => x.Name),
            };
    }
}