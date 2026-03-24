using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace TFG3.Modelo
{
    [Table("departamentos")]
    public class Departamento : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }
        public string nombre_dep { get; set; }
        public string hora_entrada_est { get; set; }
        public string hora_salida_est { get; set; }
    }
}