using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class VacacionesController
    {
        public async Task<List<Vacaciones>> ObtenerTodas()
        {
            List<Vacaciones> listaFinal = new List<Vacaciones>();

            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Vacaciones>()
                    .Get();

                if (resultado == null)
                {
                    return listaFinal;
                }

                if (resultado.Models == null)
                {
                    return listaFinal;
                }

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

        public async Task AprobarVacacion(int id, string idTrabajador)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Vacaciones>()
                    .Where(v => v.id == id)
                    .Set(v => v.estado_solicitud, "aprobada")
                    .Set(v => v.fecha_revision, DateTime.Now)
                    .Update();

                NotificacionController notifController = new NotificacionController();
                await notifController.CrearNotificacion(
                    idTrabajador,
                    "Vacaciones aprobadas",
                    "Tu solicitud de vacaciones ha sido aprobada.",
                    "vacaciones"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task RechazarVacacion(int id, string motivo, string idTrabajador)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Vacaciones>()
                    .Where(v => v.id == id)
                    .Set(v => v.estado_solicitud, "rechazada")
                    .Set(v => v.motivo_rechazo, motivo)
                    .Set(v => v.fecha_revision, DateTime.Now)
                    .Update();

                NotificacionController notifController = new NotificacionController();
                await notifController.CrearNotificacion(
                    idTrabajador,
                    "Vacaciones rechazadas",
                    "Tu solicitud de vacaciones ha sido rechazada. Motivo: " + motivo,
                    "vacaciones"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}