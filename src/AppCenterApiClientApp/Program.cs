namespace AppCenterApiClientApp
{
    using AppCenterApiClientApp.Engine;
    using AppCenterApiClientLib.Client;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "App Center platform API client";

            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] != "--api-key")
                {
                    continue;
                }

                if (i >= args.Length - 1)
                {
                    throw new Exception("ApiKey wasn't provided!");
                }

                var apiKey = args[i + 1];

                // .NET 4.8 doesn't support System.CommandLine, so emulate it
                Run(apiKey);
                return;
            }

            throw new Exception("ApiKey wasn't provided!");
        }

        /// <summary>
        /// Runs builds on App Center platform.
        /// </summary>
        /// <param name="apiKey">The private apiKey used to build.</param>
        private static void Run(string apiKey)
        {
            // Configure API key authorization: APIToken
            Configuration.Default.AddApiKey("X-API-Token", apiKey);
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-Token", "Bearer");

            var ownerName = "alex-c-akv";  // string | The name of the owner
            var appName = "appcenter-sampleapp-android";  // string | The name of the application
            
            // create & run api engine
            var apiEngine = new BuildEngine(ownerName, appName);
            apiEngine.Run();

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
