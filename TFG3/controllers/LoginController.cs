using System;
using System.Threading.Tasks;
using Supabase.Gotrue;
using TFG3.Modelo;
using TFG3.services;

namespace TFG3.Controllers
{
    public class LoginController
    {
        private TrabajadorController trabajadorController;

        public LoginController()
        {
            trabajadorController = new TrabajadorController();
        }

        public async Task<Trabajador> ValidarAcceso(string numeroEmpleado, string password)
        {
            try
            {
                string email = numeroEmpleado + "@dhl.com";

                Session sesion = await SupabaseConexion.Client.Auth.SignIn(email, password);

                if (sesion == null)
                {
                    return null;
                }

                if (sesion.User == null)
                {
                    return null;
                }

                Trabajador trabajador = await trabajadorController.ObtenerTrabajadorPorEmail(email);

                return trabajador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}