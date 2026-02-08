namespace ElCerrojoServices.Logging
{
    public static class Logger
    {
        private static readonly string LogDir =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

        public static void LogError(Exception ex)
        {
            try
            {
                if (!Directory.Exists(LogDir))
                    Directory.CreateDirectory(LogDir);

                var filePath = Path.Combine(
                    LogDir,
                    $"error_{DateTime.Now:yyyyMMdd}.log");

                var log =
                        $@"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]
                        Tipo: {ex.GetType().FullName}
                        Mensaje: {ex.Message}
                        StackTrace:
                        {ex.StackTrace}

                        --------------------------------------------------";

                File.AppendAllText(filePath, log);
            }
            catch
            {
                // JAMÁS tirar excepción desde el logger
            }
        }
    }
}
