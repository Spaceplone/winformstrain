using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace winformstrain
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var currentDirectory = AppContext.BaseDirectory;
            var builder = new ConfigurationBuilder()
                .SetBasePath(currentDirectory) // Set the base path
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static void ConfigureServices(Servicecolle)
    }
}