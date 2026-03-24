using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace TFG3.Modelo
{
    [Table("trabajadores")]
    public class Trabajador : BaseModel
    {
        [PrimaryKey("id")]
        public string id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string foto_url { get; set; }
        public string rol { get; set; }
        public int? id_departamento { get; set; }
        public bool activo { get; set; }

        public DateTime? created_at { get; set; }
        public int? dias_vacaciones { get; set; }
    }
}