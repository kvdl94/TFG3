using System;
using System.Threading.Tasks;
using Supabase;

namespace TFG3.services
{
    internal class SupabaseConexion
    {
        private static Client _client;

        public static Client Client
        {
            get
            {
                if (_client == null)
                    throw new Exception("Supabase no inicializado");
                return _client;
            }
        }

        public static async Task InicializarAsync()
        {
            string url = "https://pfjpwiweholeuspcdicf.supabase.co";
            string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzI3ODk4MjYsImV4cCI6MjA4ODM2NTgyNn0.gCFW9aK_t6SrvMLcBTiRUcUxjqd06PMDV78zqc1vHkk";

            SupabaseOptions options = new SupabaseOptions
            {
                AutoRefreshToken = true,
                AutoConnectRealtime = false
            };

            _client = new Client(url, key, options);
            await _client.InitializeAsync();
        }
    }
}