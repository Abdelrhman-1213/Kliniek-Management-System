using kliniek.Forms;
using kliniek.Data;
using System.Threading.Tasks;
namespace kliniek
{
    internal static class Program
    {
        public static Data.DataStore SharedData = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            await SharedData.Load();
            Application.Run(new LoginForm());
        }
    }
}