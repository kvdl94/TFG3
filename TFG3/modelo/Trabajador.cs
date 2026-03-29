using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace TFG3.Modelo
{
    [Table("trabajadores")]
    public class Trabajador : BaseModel
    {
        [PrimaryKey("id", false)]
        public string id { get; set; }

        [Column("dni")]
        public string dni { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }

        [Column("apellidos")]
        public string apellidos { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("telefono")]
        public string telefono { get; set; }

        [Column("foto_url")]
        public string foto_url { get; set; }

        [Column("rol")]
        public string rol { get; set; }

        [Column("id_departamento")]
        public int? id_departamento { get; set; }

        [Column("activo")]
        public bool activo { get; set; }

        [Column("created_at")]
        public DateTime? created_at { get; set; }

        [Column("dias_vacaciones")]
        public int? dias_vacaciones { get; set; }
    }
}