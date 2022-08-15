namespace ITFCodeWA.API.Constants
{
    public static class ApiRoutes
    {
        public const string API_ROOT = "api/v1";

        public static class References { }
        public static class Documents { }
        public static class Totals { }

        #region References Section 

        public const string CONTRACTORS = API_ROOT + "/contractors";
        public const string CONTRACTS = API_ROOT + "/contracts";
        public const string CURRENCIES = API_ROOT + "/currencies";
        public const string EXPENSE_ITEMS = API_ROOT + "/expense-items";
        public const string FOODS = API_ROOT + "/foods";
        public const string GOODS = API_ROOT + "/goods";
        public const string PERSONS = API_ROOT + "/persons";
        public const string REVENUE_ITEMS = API_ROOT + "/revenue-items";

        #endregion

        #region Documents Section

        public const string WEIGHT_REGISTRATORS = API_ROOT + "/weight-registrator";

        #endregion

        #region Totals Section

        public const string WEIGHT_TOTALS = API_ROOT + "/weight-totals";

        #endregion
    }
}