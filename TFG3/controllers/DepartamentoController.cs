using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class DepartamentoController
    {
        public async Task<List<Departamento>> ObtenerTodos()
        {
            List<Departamento> listaFinal = new List<Departamento>();

            try
            {
                var resultado = await SupabaseConexion.Client
                    .From<Departamento>()
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
