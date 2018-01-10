using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PersonalModel
    {
        public static bool logged { get; set; }

        public static Personal personal { get; set; }

        private WebService webService = new WebService();

        /**
         *  Login del usuario
         *      Usuario y Contraseña
         * */
        public async Task loginPersonal(string usuario, string password)
        {
            try
            {
                object[,] variables = new object[,] { { "usuario", usuario }, { "password", password } };
                dynamic result = await webService.JsonMetodoPost("personal", "buscar", variables);

                if (result != null)
                {
                    if (result.Count == 0) throw new Exception("Usuario o contraseña incorrectos");
                }

                Personal user = new Personal();
                user.idPersonal = result[0].idPersonal;
                user.nombres = result[0].nombres;
                user.apellidos = result[0].apellidos;
                user.tipoDocumento = result[0].tipoDocumento;
                user.numeroDocumento = result[0].numeroDocumento;
                user.sexo = result[0].sexo;
                user.email = result[0].email;
                user.telefono = result[0].telefono;
                user.celular = result[0].celular;
                user.direccion = result[0].direccion;
                user.estado = result[0].estado;
                user.idDocumento = result[0].idDocumento;
                user.usuario = result[0].usuario;
                PersonalModel.personal = user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }
        public void cambiarClave()
        {

        }
        public async Task<dynamic> listar(string page, string items)
        {
            try
            {
                List<Personal> listPersonal = new List<Personal>();
                dynamic result = await webService.JsonMetodoGet("personales", String.Format("estado/{0}/{1}", page, items));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
