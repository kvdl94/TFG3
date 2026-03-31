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
    }
}