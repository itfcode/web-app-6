namespace ITFCodeWA.ClientMudBlazor.Services.Api
{
    public static class ApiEndPoints
    {
//        public const string ROOT = "https://localhost:44333/api/v1";
        public const string ROOT = "https://localhost:7100/api/v1";

        public static class References
        {
            public const string CONTRACTORS = ROOT + "/contractors";
            public const string CONTRACTS = ROOT + "/contracts";
            public const string CURRENCIES = ROOT + "/currencies";
            public const string EXPENSE_ITEMS = ROOT + "/expense-items";
            public const string FOODS = ROOT + "/foods";
            public const string GOODS = ROOT + "/goods";
            public const string PERSONS = ROOT + "/persons";
            public const string REVENUE_ITEMS = ROOT + "/revenue-items";
        }

        public static class Documents
        {
            public const string WEIGHT_REGISTRATORS = ROOT + "/weight-registrator";
        }

        public static class Totals
        {
            public const string WEIGHT_TOTALS = ROOT + "/weight-totals";
        }
    }
}
