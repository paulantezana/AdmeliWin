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
            // this.domainName = "http://www.lineatienda.com";
            this.domainName = "http://localhost";
            //this.domainName = "http://192.168.1.45:8080";

            // this.directory = "services.php";
            this.directory = "admeli/xcore/services.php";

            this.urlBase = String.Format("{0}/{1}", domainName, directory);
        }

        //////// ================================== CRETE ADMELI ==================================
        public async Task<Response> DELETE<T>(string servicio, string metodo, T param)
        {
            try
            {
                // creando el contenido apartir de un jsonString
                string json = JsonConvert.SerializeObject(param);
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = new StringContent(json, Encoding.UTF8, "application/json"),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(url)
                };

                HttpClient client = new HttpClient();
                HttpResponseMessage responseMessage = await client.SendAsync(request);

                // Validando la respuesta
                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception(responseMessage.ToString());
                }
                string result = await responseMessage.Content.ReadAsStringAsync();

                // retornando los valores en una lista de objetos
                Response res = JsonConvert.DeserializeObject<Response>(result);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public async Task<RootObject<T>> POSTRoot<T>(string servicio, string metodo, string jsonString)
        {
            try
            {
                // creando el contenido apartir de un jsonString
                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

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
                RootObject<T> list = JsonConvert.DeserializeObject<RootObject<T>>(result);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<T>> POSTList<T>(string servicio, string metodo, T param)
        {
            try
            {
                // Serializando el objeto
                string request =  JsonConvert.SerializeObject(param);
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
                List<T> list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region ============= Metodo GET que retorna un objeto RootObjet =============
        public async Task<RootObject<T>> GETRoot<T>(string servicio, string metodo)
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
                RootObject<T> rootObject = JsonConvert.DeserializeObject<RootObject<T>>(result);
                return rootObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<T>> GETRoot<T>(string servicio)
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
                RootObject<T> rootObject = JsonConvert.DeserializeObject<RootObject<T>>(result);
                return rootObject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        #endregion

        #region =============== Metodo GET que retorna una lista de objetos ===============
        public async Task<List<T>> GETLis<T>(string servicio, string metodo)
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
                List<T> list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<T>> GETLis<T>(string servicio)
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
                List<T> list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        #endregion

        #region ============== Metododo GET que retorna un solo objeto ==============
        public async Task<T> GETObject<T>(string servicio, string metodo)
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

        public async Task<T> GETObject<T>(string servicio)
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
