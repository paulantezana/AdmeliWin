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
                Personal personal = new Personal();
                personal.usuario = usuario;
                personal.password = password;

                List<Personal> user =  await  webService.POSTList<Personal>("personal", "buscar", personal);
                PersonalModel.personal = user[0];
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
        public async Task<RootObject<Personal>> listar(int page, int items)
        {
            try
            {
                RootObject<Personal> personales = await webService.GETRoot<Personal>("personales", String.Format("estado/{0}/{1}", page, items));
                return personales;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Personal>> listarPersonalCompras(int idSucursal)
        {
            try
            {
                List<Personal> list = await webService.GETLis<Personal>("listarpersonalcompras", String.Format("sucursal/{0}",idSucursal));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
