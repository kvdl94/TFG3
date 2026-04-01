using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace TFG3.Modelo
{
    [Table("mensajes")]
    public class Mensaje : BaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }

        [Column("id_remitente")]
        public string id_remitente { get; set; }

        [Column("id_destinatario")]
        public string id_destinatario { get; set; }

        [Column("mensaje")]
        public string mensaje { get; set; }

        [Column("leido")]
        public bool leido { get; set; }

        [Column("fecha")]
        public DateTime? fecha { get; set; }
    }
}