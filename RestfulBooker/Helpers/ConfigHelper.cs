using System;
using System.Configuration;
using NUnit.Framework;

namespace RestfulBooker.Helpers
{
    public class ConfigHelper
    {
        public static string WEB_API_URL { get; }

        static ConfigHelper()
        {
            WEB_API_URL = ReadConfiguration("apiUrl");
        }

        private static string ReadConfiguration(string key)
        {
            string value;

            Console.WriteLine("Reading configuration for key: " + key + " from .runsettings");
            value = TestContext.Parameters[key];

            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Reading configuration for key: " + key + " from .config");
                value = ConfigurationManager.AppSettings.Get(key);
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Configuration parameter: '" + key + "' could not be found in any of the expected sources: runsettings, config or environment variable");
            }
            return value;
        }
    }
}