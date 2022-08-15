using ITFCodeWA.ClientMudBlazor.Extensions;
using ITFCodeWA.ClientMudBlazor.Models.ColumnSettings;
using ITFCodeWA.Models.References;

namespace ITFCodeWA.ClientMudBlazor.Static.ColumnSettings
{
    public static partial class ColumnSettingSets
    {
        public static IReadOnlyList<ColumnSetting<FoodModel>> Foods =>
            new List<ColumnSetting<FoodModel>>()
                .AddSetting(name: nameof(FoodModel.Name), label: "Наименование")
                .AddSetting(name: nameof(FoodModel.FoodGroupName), label: "Группа")
                .AddSetting(name: nameof(FoodModel.Calories), label: "Каллории")
                .AddSetting(name: nameof(FoodModel.Proteins), label: "Белки")
                .AddSetting(name: nameof(FoodModel.Fats), label: "Жири")
                .AddSetting(name: nameof(FoodModel.Carbohydrates), label: "Углеводы")
            ;

        public static IReadOnlyList<ColumnSetting<FoodGroupModel>> FoodGroups =>
            new List<ColumnSetting<FoodGroupModel>>()
                .AddSetting(name: nameof(FoodModel.Name), label: "Наименование", view: x => x.Name)
            ;

        public static IReadOnlyList<ColumnSetting<PersonModel>> Persons =>
            new List<ColumnSetting<PersonModel>>()
                .AddSetting(name: nameof(PersonModel.FirstName), label: "Имя", view: x => x.FirstName)
                .AddSetting(name: nameof(PersonModel.MiddleName), label: "Отчество", view: x => x.MiddleName)
                .AddSetting(name: nameof(PersonModel.LastName), label: "Фамилия", view: x => x.LastName)
                .AddSetting(name: nameof(PersonModel.Utr), label: "ИНН", view: x => x.Utr)
            ;

        public static IReadOnlyList<ColumnSetting<GoodModel>> Goods =>
            new List<ColumnSetting<GoodModel>>()
                .AddSetting(name: nameof(GoodModel.Name), label: "Наименование", view: x => x.Name)
                .AddSetting(name: nameof(GoodModel.GroupName), label: "Группа", view: x => x.GroupName)
                .AddSetting(name: nameof(GoodModel.RevenueItemName), label: "Статья доходов", view: x => x.RevenueItemName)
                .AddSetting(name: nameof(GoodModel.ExpenseItemName), label: "Статья расходов", view: x => x.ExpenseItemName)
                .AddSetting(name: nameof(GoodModel.Comment), label: "Комментарий", view: x => x.Comment)
            ;

        public static IReadOnlyList<ColumnSetting<ContractorModel>> Contractors =>
            new List<ColumnSetting<ContractorModel>>()
                .AddSetting(name: nameof(ContractorModel.Name), label: "Наименование", view: x => x.Name)
                .AddSetting(name: nameof(ContractorModel.TaxNumber), label: "Налоговый номер", view: x => x.TaxNumber)
                .AddSetting(name: nameof(ContractorModel.Comment), label: "Комментарий", view: x => x.Comment)
            ;

        public static IReadOnlyList<ColumnSetting<ContractModel>> Contracts =>
            new List<ColumnSetting<ContractModel>>()
                .AddSetting(name: nameof(ContractModel.ContractorName), label: "Контрагент", view: x => x.Name)
                .AddSetting(name: nameof(ContractModel.Name), label: "Наименование", view: x => x.Name)
                .AddSetting(name: nameof(ContractModel.StartDate), label: "Дата начала", view: x => x.StartDate)
                .AddSetting(name: nameof(ContractModel.FinishDate), label: "Дата окончания", view: x => x.FinishDate)
                .AddSetting(name: nameof(ContractModel.TotalCost), label: "Сумма", view: x => x.Name)
            ;

        public static IReadOnlyList<ColumnSetting<CurrencyModel>> Currencies =>
            new List<ColumnSetting<CurrencyModel>>()
                .AddSetting(name: nameof(CurrencyModel.Code), label: "Код цифровой", view: x => x.Code)
                .AddSetting(name: nameof(CurrencyModel.ShortName), label: "Код буквенный ", view: x => x.ShortName)
                .AddSetting(name: nameof(CurrencyModel.Name), label: "Наименование", view: x => x.Name)
            ;

        public static IReadOnlyList<ColumnSetting<RevenueItemModel>> RevenueItems =>
            new List<ColumnSetting<RevenueItemModel>>()
                .AddSetting(name: nameof(RevenueItemModel.Name), label: "Наименование", view: x => x.Name)
                .AddSetting(name: nameof(RevenueItemModel.GroupName), label: "Группа", view: x => x.GroupName)
            ;

        public static IReadOnlyList<ColumnSetting<RevenueGroupModel>> RevenueGroups =>
            new List<ColumnSetting<RevenueGroupModel>>()
                .AddSetting(name: nameof(RevenueGroupModel.Name), label: "Наименование", view: x => x.Name)
            ;

        public static IReadOnlyList<ColumnSetting<ExpenseItemModel>> ExpenseItems =>
            new List<ColumnSetting<ExpenseItemModel>>()
                .AddSetting(name: nameof(ExpenseItemModel.Name), label: "Наименование", view: x => x.Name)
                .AddSetting(name: nameof(ExpenseItemModel.GroupName), label: "Группа", view: x => x.GroupName)
            ;

        public static IReadOnlyList<ColumnSetting<ExpenseGroupModel>> ExpenseGroups =>
            new List<ColumnSetting<ExpenseGroupModel>>()
                .AddSetting(name: nameof(ExpenseGroupModel.Name), label: "Наименование", view: x => x.Name)
            ;
    }
}