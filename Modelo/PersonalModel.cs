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
         *      usuario y contraseña
         * */
        public async void loginPersonal(string usuario, string password)
        {
            try
            {
                object[,] variables = new object[,] { { "usuario", usuario }, { "password", password } };
                dynamic result = await webService.JsonMetodoPost("services.php/personal", "buscar", variables);

                if (result != null)
                {
                    if (result.count == 0) throw new Exception("Usuario o contraseña incorrectos");
                }
                
                personal.idPersonal = result[0].idPersonal;
                personal.nombres = result[0].nombres;
                personal.apellidos = result[0].apellidos;
                personal.tipoDocumento = result[0].tipoDocumento;
                personal.numeroDocumento = result[0].numeroDocumento;
                personal.sexo = result[0].sexo;
                personal.email = result[0].email;
                personal.telefono = result[0].telefono;
                personal.celular = result[0].celular;
                personal.direccion = result[0].direccion;
                personal.estado = result[0].estado;
                personal.idDocumento = result[0].idDocumento;
                personal.usuario = result[0].usuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
