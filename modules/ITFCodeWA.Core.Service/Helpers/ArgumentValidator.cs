namespace ITFCodeWA.Core.Services.Helpers
{
    public static class ArgumentValidator
    {
        public static void ValidateNull((object argumentValue, string argumentName) first, params (object argumentValue, string argumentName)[] other)
        {
            var args = new List<(object argumentValue, string argumentName)> { first };

            foreach (var arg in args.Concat(other))
            {
                ArgumentNullException.ThrowIfNull(arg.argumentValue, arg.argumentName);
            }
        }

        public static void ValidateEmpty((string argumentValue, string argumentName) first, params (string argumentValue, string argumentName)[] other)
        {
            var args = new List<(string argumentValue, string argumentName)> { first };

            foreach (var arg in args.Concat(other))
            {
                if (string.IsNullOrWhiteSpace(arg.argumentValue))
                    throw new ArgumentException("Can not be empty", arg.argumentName);
            }
        }
    }
}
