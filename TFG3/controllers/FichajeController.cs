using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class FichajeController
    {
        public async Task<List<Fichaje>> ObtenerFichajesPorEmpleado(string idTrabajador)
        {
            List<Fichaje> listaFinal = new List<Fichaje>();

            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Fichaje>()
                    .Where(f => f.id_trabajador == idTrabajador)
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

        public async Task<List<Fichaje>> ObtenerTodos()
        {
            List<Fichaje> listaFinal = new List<Fichaje>();

            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Fichaje>()
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




    }
}