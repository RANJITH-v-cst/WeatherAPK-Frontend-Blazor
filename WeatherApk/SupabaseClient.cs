  using Supabase;
    using System.Threading.Tasks;

    public class SupabaseClient
    {
        private static Supabase.Client? _client;
        private const string SupabaseUrl = "https://vnaozyyxkykblskcrrzm.supabase.co";
        private const string SupabaseAnonKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InZuYW96eXl4a3lrYmxza2NycnptIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDE4Mzg5MDgsImV4cCI6MjA1NzQxNDkwOH0.SLOHIDyrSXJEhemKNkh_OUmeSWc2pPuus5iFIHt0YVw";

        public Supabase.Client GetClient()
        {
            if (_client == null)
            {
                _client = new Supabase.Client(SupabaseUrl, SupabaseAnonKey, new SupabaseOptions
                {
                    AutoConnectRealtime = true
                });
            }
            return _client;
        }
    }

