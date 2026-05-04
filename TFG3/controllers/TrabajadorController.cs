using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class TrabajadorController
    {
        public async Task<List<Trabajador>> ObtenerTodosLosTrabajadores()
        {
            List<Trabajador> listaFinal = new List<Trabajador>();

            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Trabajador>()
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

        public async Task<Trabajador> ObtenerTrabajadorPorId(string id)
        {
            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Trabajador>()
                    .Where(t => t.id == id)
                    .Single();

                return resultado;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Trabajador> ObtenerTrabajadorPorEmail(string email)
        {
            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Trabajador>()
                    .Where(t => t.email == email)
                    .Single();

                return resultado;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task EliminarTrabajador(string id)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Trabajador>()
                    .Where(t => t.id == id)
                    .Delete();

                using (var http = new System.Net.Http.HttpClient())
                {
                    http.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc3Mjc4OTgyNiwiZXhwIjoyMDg4MzY1ODI2fQ.FF2_M4801S3t459p14Au3yVgpER9bJx5edT6aWnNdqw");
                    http.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc3Mjc4OTgyNiwiZXhwIjoyMDg4MzY1ODI2fQ.FF2_M4801S3t459p14Au3yVgpER9bJx5edT6aWnNdqw");
                    await http.DeleteAsync("https://pfjpwiweholeuspcdicf.supabase.co/auth/v1/admin/users/" + id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task ActualizarTrabajador(Trabajador trabajador)
        {
            try
            {
                await SupabaseConexion.Client
                    .From<Trabajador>()
                    .Where(t => t.id == trabajador.id)
                    .Set(t => t.telefono, trabajador.telefono)
                    .Set(t => t.rol, trabajador.rol)
                    .Set(t => t.dias_vacaciones, trabajador.dias_vacaciones)
                    .Update();
                MessageBox.Show("Actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task<string> CrearTrabajador(string numeroEmpleado, string password, Trabajador nuevoTrabajador)
        {
            string email = numeroEmpleado + "@dhl.com";
            string userId = null;

            try
            {
                var sesion = await SupabaseConexion.AdminClient.Auth.SignUp(email, password);

                if (sesion == null || sesion.User == null)
                {
                    return "Error al crear el usuario";
                }

                userId = sesion.User.Id;

                nuevoTrabajador.id = userId;
                nuevoTrabajador.email = email;

                await SupabaseConexion.Client
                    .From<Trabajador>()
                    .Upsert(nuevoTrabajador);

                return null;
            }
            catch (Exception ex)
            {
                if (userId != null)
                {
                    try
                    {
                        using (var http = new System.Net.Http.HttpClient())
                        {
                            http.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc3Mjc4OTgyNiwiZXhwIjoyMDg4MzY1ODI2fQ.FF2_M4801S3t459p14Au3yVgpER9bJx5edT6aWnNdqw");
                            http.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InBmanB3aXdlaG9sZXVzcGNkaWNmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc3Mjc4OTgyNiwiZXhwIjoyMDg4MzY1ODI2fQ.FF2_M4801S3t459p14Au3yVgpER9bJx5edT6aWnNdqw");
                            await http.DeleteAsync("https://pfjpwiweholeuspcdicf.supabase.co/auth/v1/admin/users/" + userId);
                        }
                    }
                    catch
                    {
                    }
                }

                return ex.Message;
            }
        }


        public async Task ActualizarDiasVacaciones(string idTrabajador, int nuevosDias)
        {
            try
            {
                var client = SupabaseConexion.Client;
                await client.From<Trabajador>()
                    .Where(t => t.id == idTrabajador)
                    .Set(t => t.dias_vacaciones, nuevosDias)
                    .Update();

                
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error al actualizar días: " + ex.Message);
            }
        }



    }
}