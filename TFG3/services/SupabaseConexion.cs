using System;
using System.Threading.Tasks;
using Supabase;

namespace TFG3.services
{
    internal class SupabaseConexion
    {
        private static Client _client;
        private static Client _adminClient;

        public static Client Client
        {
            get
            {
                if (_client == null)
                    throw new Exception("Supabase no inicializado");
                return _client;
            }
        }

        public static Client AdminClient
        {
            get
            {
                if (_adminClient == null)
                    throw new Exception("Supabase admin no inicializado");
                return _adminClient;
            }
        }

        public static async Task InicializarAsync()
        {
            string url = "https://pfjpwiweholeuspcdicf.supabase.co";
            string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzI3ODk4MjYsImV4cCI6MjA4ODM2NTgyNn0.gCFW9aK_t6SrvMLcBTiRUcUxjqd06PMDV78zqc1vHkk";
            string serviceKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc3Mjc4OTgyNiwiZXhwIjoyMDg4MzY1ODI2fQ.FF2_M4801S3t459p14Au3yVgpER9bJx5edT6aWnNdqw";

            SupabaseOptions options = new SupabaseOptions
            {
                AutoRefreshToken = true,
                AutoConnectRealtime = false
            };
            _client = new Client(url, key, options);
            await _client.InitializeAsync();

            SupabaseOptions adminOptions = new SupabaseOptions
            {
                AutoRefreshToken = false,
                AutoConnectRealtime = false
            };
            _adminClient = new Client(url, serviceKey, adminOptions);
            await _adminClient.InitializeAsync();
        }
    }
}