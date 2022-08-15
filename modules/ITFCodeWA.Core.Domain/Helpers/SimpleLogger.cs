namespace ITFCodeWA.Core.Domain.Helpers
{
    public static class SimpleLogger
    {
        private static readonly string _filePath = @"d:\simplelog.txt";

        static SimpleLogger()
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);
        }

        public static void Log(string message)
            => AddLine($"LOG  : {message}");

        public static void Err(string message)
            => AddLine($"ERROR: {message}");

        public static void Warn(string message)
            => AddLine($"WARN : {message}");

        private static void AddLine(string message)
            => File.AppendAllText(_filePath, $"{message}\n");
    }
}