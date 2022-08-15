namespace ITFCodeWA.API.Constants
{
    public static class ApiRoutes
    {
        public const string API_ROOT = "api/v1";

        #region References Section 

        public const string CONTRACTORS = API_ROOT + "/contractors";
        public const string CONTRACTS = API_ROOT + "/contracts";
        public const string CURRENCIES = API_ROOT + "/currencies";
        public const string EXPENSE_GROUPS = API_ROOT + "/expense-groups";
        public const string EXPENSE_ITEMS = API_ROOT + "/expense-items";
        public const string FOOD_GROUPS = API_ROOT + "/food-groups";
        public const string FOODS = API_ROOT + "/foods";
        public const string GOOD_GROUPS = API_ROOT + "/good-groups";
        public const string GOODS = API_ROOT + "/goods";
        public const string PERSONS = API_ROOT + "/persons";
        public const string REVENUE_GROUPS = API_ROOT + "/revenue-groups";
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