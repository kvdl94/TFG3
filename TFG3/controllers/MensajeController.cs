using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class MensajeController
    {
        public async Task<List<Mensaje>> ObtenerMensajes(string idEmpleado)
        {
            List<Mensaje> listaFinal = new List<Mensaje>();
            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Mensaje>()
                    .Where(m => m.id_remitente == idEmpleado || m.id_destinatario == idEmpleado)
                    .Order(m => m.fecha, Supabase.Postgrest.Constants.Ordering.Ascending)
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

        public async Task EnviarMensaje(string idRemitente, string idDestinatario, string texto)
        {
            try
            {
                Mensaje nuevo = new Mensaje();
                nuevo.id_remitente = idRemitente;
                nuevo.id_destinatario = idDestinatario;
                nuevo.mensaje = texto;
                nuevo.leido = false;

                await SupabaseConexion.Client
                    .From<Mensaje>()
                    .Insert(nuevo);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task MarcarComoLeido(int id)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Mensaje>()
                    .Where(m => m.id == id)
                    .Set(m => m.leido, true)
                    .Update();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}