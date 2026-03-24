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
               
            }
            catch (Exception ex)
            {
                
            }
        }





    }
}