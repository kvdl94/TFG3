using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace TFG3.Modelo
{
    [Table("tareas")]
    public class Tarea : BaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }

        [Column("id_trabajador")]
        public string id_trabajador { get; set; }

        [Column("titulo")]
        public string titulo { get; set; }

        [Column("descripcion")]
        public string descripcion { get; set; }

        [Column("estado")]
        public string estado { get; set; }

        [Column("prioridad")]
        public string prioridad { get; set; }

        [Column("fecha_limite")]
        public DateTime? fecha_limite { get; set; }

        [Column("asignado_por")]
        public string asignado_por { get; set; }


        [Column("created_at")]
        public DateTime? created_at { get; set; }
    }
}