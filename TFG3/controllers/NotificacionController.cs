using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class NotificacionController
    {
        public async Task<List<Notificacion>> ObtenerTodas()
        {
            List<Notificacion> listaFinal = new List<Notificacion>();
            try
            {
                var resultado = await SupabaseConexion.Client
    .From<Notificacion>()
    .Order(n => n.leido, Supabase.Postgrest.Constants.Ordering.Ascending)
    .Order(n => n.fecha, Supabase.Postgrest.Constants.Ordering.Descending)
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

        public async Task CrearNotificacion(string idTrabajador, string titulo, string mensaje, string tipo)
        {
            try
            {
                Notificacion nueva = new Notificacion();
                nueva.id_trabajador = idTrabajador;
                nueva.titulo = titulo;
                nueva.mensaje = mensaje;
                nueva.tipo = tipo;
                nueva.leido = false;

                await SupabaseConexion.Client
                    .From<Notificacion>()
                    .Insert(nueva);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error notificacion: " + ex.Message);
            }
        }

        public async Task MarcarComoLeida(int id)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Notificacion>()
                    .Where(n => n.id == id)
                    .Set(n => n.leido, true)
                    .Update();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}