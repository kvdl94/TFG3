using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace TFG3.Modelo
{
    [Table("fichajes")]
    public class Fichaje : BaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }

        [Column("id_trabajador")]
        public string id_trabajador { get; set; }

        [Column("fecha")]
        public DateTime? fecha { get; set; }

        [Column("hora_entrada")]
        public TimeSpan? hora_entrada { get; set; }

        [Column("hora_salida")]
        public TimeSpan? hora_salida { get; set; }

        [Column("tipo")]
        public string tipo { get; set; }

        [Column("notas")]
        public string notas { get; set; }
    }
}