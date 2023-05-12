using System;
using System.Diagnostics;
using System.IO;

namespace Log.Logging
{
    public static class FWLogger
    {
        private static readonly string today = $"{DateTime.Now:yyyy-MM-dd}";
        private static readonly string path = @"c:\temp\logs\";
        private static readonly string fullPath = $@"{path}{today}-LogDllLynx.log";
    
        public static void LogInfo(string msg)
        {
            DoLog(LogLevel.INFO, msg);
        }

        public static void LogError(string msg)
        {
            DoLog(LogLevel.ERROR, msg);
        }

        public static void LogFatal(string msg)
        {
            DoLog(LogLevel.FATAL, msg);
        }

        public static void LogDebug(string msg)
        {
            DoLog(LogLevel.DEBUG, msg);
        }

        private static void CheckFileExists()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(fullPath))
            {
                File.Create(fullPath);
            }
        }

        private static void DoLog(LogLevel logLevel, string message)
        {
            var logText = $"{logLevel} - {DateTime.Now:dd-MM-yyyy HH:mm:ss} - {message} \n";

            try
            {
                CheckFileExists();
                File.AppendAllText(fullPath, logText);
            }
            catch (Exception ex)
            {
                LogEvent($"Não foi possível criar o log no arquivo {fullPath}. \n Conteúdo do log: {logText} \n"
                   + $"Descrição do erro: {ex.Message} \n"
                   + $"Inner Exception: {ex.InnerException} \n"
                   + $"Stack Trace: {ex.StackTrace}"
                );
            }
        }

        private static void LogEvent(string msg)
        {
            try
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry($"{msg}", EventLogEntryType.Information, 101, 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
