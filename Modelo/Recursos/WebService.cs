using Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Recursos
{
    public class WebService
    {
        public string urlBase { get; set; }
        public string domainName { get; set; }
        public string directory { get; set; }

        public WebService()
        {
            //this.domainName = "http://www.lineatienda.com";
            this.domainName = "http://localhost:8080";
            //this.domainName = "http://192.168.1.45:8080";

            //this.directory = "services.php";
            this.directory = "admeli/xcore/services.php";

            this.urlBase = String.Format("{0}/{1}", domainName, directory);
        }

        //////// ================================== CRETE ADMELI ==================================
        /*
        public async Task<Response> POSTSend<T>(string servicio, string metodo, T param)
        {
            try
            {
                // creando el contenido apartir de un jsonString
                string request = JsonConvert.SerializeObject(param);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                // Creando un nuevo cliente
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}/{2}", this.directory, servicio, metodo);
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Validando la respuesta
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                Response res = JsonConvert.DeserializeObject<Response>(result);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public async Task<Response> POSTSend<T>(string servicio, T param)
        {
            try
            {
                // creando el contenido apartir de un jsonString
                string request = JsonConvert.SerializeObject(param);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                // Creando un nuevo cliente
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}", this.directory, servicio);
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Validando la respuesta
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                Response res = JsonConvert.DeserializeObject<Response>(result);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */


        /// <summary>
        /// Enviar y recivir datos mediante el metodo POST  donde T = al dato k se envia y K es el dato que responde
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="servicio"></param>
        /// <param name="metodo"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<K> POST<T,K>(string servicio, string metodo, T param)
        {
            try
            {
                // Serializando el objeto
                string request = JsonConvert.SerializeObject(param);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                // Creando un nuevo cliente
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}/{2}", this.directory, servicio, metodo);
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Validando la respuesta
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                K dataResponse = JsonConvert.DeserializeObject<K>(result);
                return dataResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<K> POST<T, K>(string servicio, T param)
        {
            try
            {
                // Serializando el objeto
                string request = JsonConvert.SerializeObject(param);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                // Creando un nuevo cliente
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}", this.directory, servicio);
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Validando la respuesta
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                K dataResponse = JsonConvert.DeserializeObject<K>(result);
                return dataResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<T>> POSTResponse<T>(string servicio, T param)
        {
            try
            {
                // creando el contenido apartir de un jsonString
                string request = JsonConvert.SerializeObject(param);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                // Creando un nuevo cliente
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}", this.directory, servicio);
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Validando la respuesta
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                List<T> res = JsonConvert.DeserializeObject<List<T>>(result);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        /*
        public async Task<List<T>> POST<T>(string servicio, T param)
        {
            try
            {
                // Serializando el objeto
                string request = JsonConvert.SerializeObject(param);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                // Creando un nuevo cliente
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}/", this.directory, servicio);
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Validando la respuesta
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                List<T> dataResponse = JsonConvert.DeserializeObject<List<T>>(result);
                return dataResponse;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */


        #region ============== Metododo GET que retorna un objeto generico ==============
        public async Task<T> GET<T>(string servicio, string metodo)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}/{2}", this.directory, servicio, metodo);
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();
                T objeto = JsonConvert.DeserializeObject<T>(result);
                return objeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> GET<T>(string servicio)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(this.domainName);
                string url = string.Format("{0}/{1}", this.directory, servicio);
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ToString());
                }
                string result = await response.Content.ReadAsStringAsync();
                T objeto = JsonConvert.DeserializeObject<T>(result);
                return objeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        #endregion

    }
}
