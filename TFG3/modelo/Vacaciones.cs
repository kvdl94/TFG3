using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace TFG3.Modelo
{
    [Table("vacaciones")]
    public class Vacaciones : BaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }

        [Column("id_trabajador")]
        public string id_trabajador { get; set; }

        [Column("fecha_inicio")]
        public DateTime? fecha_inicio { get; set; }

        [Column("fecha_fin")]
        public DateTime? fecha_fin { get; set; }

        [Column("estado_solicitud")]
        public string estado_solicitud { get; set; }

        [Column("motivo")]
        public string motivo { get; set; }

        [Column("revisado_por")]
        public string revisado_por { get; set; }

        [Column("fecha_revision")]
        public DateTime? fecha_revision { get; set; }

        [Column("motivo_rechazo")]
        public string motivo_rechazo { get; set; }


    }
}