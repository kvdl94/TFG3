using System;
using System.Threading.Tasks;
using Supabase;

namespace TFG3.services
{
    internal class SupabaseConexion
    {
        private static Client _client;
        private static Client _adminClient;
        public static string UsuarioActualId { get; set; }
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
            string url = Secrets.SupabaseUrl;
            string key = Secrets.SupabaseAnonKey;
            string serviceKey = Secrets.SupabaseServiceKey;

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
