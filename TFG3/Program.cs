namespace TFG3.services  
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
           
            ApplicationConfiguration.Initialize();
            await TFG3.services.SupabaseConexion.InicializarAsync();
            Application.Run(new Login());
        }
    }
}