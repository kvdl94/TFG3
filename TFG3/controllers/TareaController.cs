using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class TareaController
    {
        public async Task<List<Tarea>> ObtenerTodas()
        {
            List<Tarea> listaFinal = new List<Tarea>();

            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Tarea>()
                    .Get();

                if (resultado == null) return listaFinal;
                if (resultado.Models == null) return listaFinal;

                for (int i = 0; i < resultado.Models.Count; i++)
                {
                    listaFinal.Add(resultado.Models[i]);
                }

                return listaFinal;
            }
            catch (Exception ex)
            {
                return listaFinal;
            }
        }

        public async Task CambiarEstado(int id, string nuevoEstado)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Tarea>()
                    .Where(t => t.id == id)
                    .Set(t => t.estado, nuevoEstado)
                    .Update();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task EliminarTarea(int id)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Tarea>()
                    .Where(t => t.id == id)
                    .Delete();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task CrearTarea(Tarea tarea)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Tarea>()
                    .Insert(tarea);

                NotificacionController notifController = new NotificacionController();
                await notifController.CrearNotificacion(
                    tarea.id_trabajador,
                    "Nueva tarea asignada",
                    "Se te ha asignado la tarea: " + tarea.titulo,
                    "tarea"
                );


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}