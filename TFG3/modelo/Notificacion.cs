using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace TFG3.Modelo
{
    [Table("notificaciones")]
    public class Notificacion : BaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }

        [Column("id_trabajador")]
        public string id_trabajador { get; set; }

        [Column("titulo")]
        public string titulo { get; set; }

        [Column("mensaje")]
        public string mensaje { get; set; }

        [Column("tipo")]
        public string tipo { get; set; }

        [Column("leido")]
        public bool leido { get; set; }

        [Column("fecha")]
        public DateTime? fecha { get; set; }
    }
}