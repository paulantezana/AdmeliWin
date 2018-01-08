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

        public WebService()
        {
            this.urlBase = "http://www.lineatienda.com";
            //this.urlBase = "http://192.168.1.10/admeli/~admeli";
            //this.urlBase = "http://192.168.1.57:8085/admeli/~admeli";
            //this.urlBase = "http://192.168.1.10/admeli/~admeli_mysql";
        }

        /**
         *  MetodoGet
         *      servicio
         *      metodo
         * */
        public async Task<dynamic> MetodoGet(string servicio, string metodo)
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);
                string contenido;// = "{\"mensaje:error\"}";
                dynamic datosTabla;// = JsonConvert.DeserializeObject(contenido);
                var cliente = new HttpClient();
                var message = await cliente.GetAsync(url);
                if (message.StatusCode == HttpStatusCode.OK)
                {
                    contenido = await message.Content.ReadAsStringAsync();
                    datosTabla = JsonConvert.DeserializeObject(contenido);
                }
                else
                {
                    datosTabla = message.StatusCode.ToString();// devolvería un string?
                }
                return datosTabla;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                throw;
            }
        }
        // USADO PARA: Llamar servicios web, que nos devuelva si tabla de datos
        public async Task<dynamic> MetodoGet(string servicio, string metodo, object[,] variables)
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);
                for (int i = 0; i < variables.Length / 2; i++)
                {
                    if (i == 0)
                        url += "?" + variables[i, 0].ToString() + "=" + variables[i, 1].ToString();
                    else
                        url += "&" + variables[i, 0].ToString() + "=" + variables[i, 1].ToString();
                }
                string contenido;
                dynamic datosTabla;
                var cliente = new HttpClient();
                var message = await cliente.GetAsync(url);
                if (message.StatusCode == HttpStatusCode.OK)
                {
                    contenido = await message.Content.ReadAsStringAsync();
                    //intento deserealizar si es un json si no se puede debe ser un texto sin formato json y eso lo muestro
                    try
                    {
                        //[{"idUsuario": 3}], [], mensaje de error de la base de datos u otro error
                        datosTabla = JsonConvert.DeserializeObject(contenido);
                    }
                    catch
                    {
                        datosTabla = null;
                    }
                }
                else
                {
                    datosTabla = null;// mensaje de error
                }
                return datosTabla;
            }
            catch (Exception ex)
            {
                string aux = ex.ToString();
                throw;
            }
        }
        // USADO PARA: Llamar servicios web y que esperamos un mensaje de respuesta
        public async Task<string> MetodoGetString(string servicio, string metodo, object[,] variables)
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);
                for (int i = 0; i < variables.Length / 2; i++)
                {
                    if (i == 0)
                        url += "?" + variables[i, 0].ToString() + "=" + variables[i, 1].ToString();
                    else
                        url += "&" + variables[i, 0].ToString() + "=" + variables[i, 1].ToString();
                }
                string contenido;
                var cliente = new HttpClient();
                var message = await cliente.GetAsync(url);
                if (message.StatusCode == HttpStatusCode.OK)
                {
                    var json = await message.Content.ReadAsStringAsync();
                    contenido = Convert.ToString(json);
                }
                else
                {
                    contenido = message.ReasonPhrase.ToString();
                }
                return contenido;
            }
            catch (Exception ex)
            {
                string aux = ex.ToString();
                throw;
            }
        }

        public async Task<dynamic> MetodoPost(string servicio, string metodo, object[,] variables)
        {
            try
            {
                // Formando la URL unicode resource lacator
                HttpClient client = new HttpClient();
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);

                // Encodificando Para el metodo POST
                var body = new List<KeyValuePair<string, string>>();
                for (int i = 0; i < variables.Length / 2; i++)
                    body.Add(new KeyValuePair<string, string>(variables[i, 0].ToString(), variables[i, 1].ToString()));
                var content = new FormUrlEncodedContent(body);

                string contenido;
                dynamic datosTabla;
                var cliente = new HttpClient();
                var message = cliente.PostAsync(url, content).Result;

                if (message.StatusCode == HttpStatusCode.OK)
                {
                    contenido = await message.Content.ReadAsStringAsync();
                    //intento deserealizar si es un json si no se puede debe ser un texto sin formato json y eso lo muestro
                    try
                    {
                        //[{"idUsuario": 3}], [], mensaje de error de la base de datos u otro error
                        datosTabla = JsonConvert.DeserializeObject(contenido);
                    }
                    catch (Exception e)
                    {
                        datosTabla = null;
                    }
                }
                else
                {
                    datosTabla = null;// mensaje de error
                }
                return datosTabla;
            }
            catch (Exception)
            {
                // return ex.Message;
                throw;
            }
        }

        public async Task<string> MetodoPostString(string servicio, string metodo, object[,] variables)
        {
            try
            {
                // Formando la URL unicode resource lacator
                HttpClient client = new HttpClient();
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);

                // Encodificando Para el metodo POST
                var body = new List<KeyValuePair<string, string>>();
                for (int i = 0; i < variables.Length / 2; i++)
                    body.Add(new KeyValuePair<string, string>(variables[i, 0].ToString(), variables[i, 1].ToString()));
                var content = new FormUrlEncodedContent(body);
                string contenido;
                var cliente = new HttpClient();
                var message = cliente.PostAsync(url, content).Result;

                if (message.StatusCode == HttpStatusCode.OK)
                {
                    var json = await message.Content.ReadAsStringAsync();
                    contenido = Convert.ToString(json);
                }
                else
                {
                    contenido = message.ReasonPhrase.ToString();
                }
                return contenido;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        //Nuevos servicios que no son Async
        public async Task<dynamic> JsonMetodoGet(string servicio, string metodo)
        {
            try
            {
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "GET";
                var httpResponse = await httpWebRequest.GetResponseAsync();
                //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                //Si la respuesta es correcta 
                //if (httpResponse.StatusCode == HttpStatusCode.OK)
                //{

                //}
                Stream receiveStream = httpResponse.GetResponseStream();
                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                var result = readStream.ReadToEnd();
                //Devolvemos el resultado al cookie
                //Agregar los cookies obtenidos al CookieContainer
                //foreach (Cookie unacookie in httpResponse.Cookies)
                //{
                //    cookies.Add(unacookie);
                //}
                //---------------------
                //result = result.Trim(' ','\n');
                dynamic datosTabla;
                //result =JsonConvert.SerializeObject(result, Formatting.Indented);
                datosTabla = JsonConvert.DeserializeObject(result);
                return datosTabla;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                throw;
            }
        }

        public async Task<dynamic> JsonMetodoPost(string servicio, string metodo, object[,] variables)
        {
            try
            {
                string url = string.Format("{0}/{1}/{2}", this.urlBase, servicio, metodo);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                string json = "{";
                //poner los parametros a texto plano
                for (int i = 0; i < variables.Length / 2; i++)
                {
                    json += "\"" + variables[i, 0].ToString() + "\"" + ":\"" + variables[i, 1].ToString() + "\"";
                    if (i != (variables.Length / 2) - 1)
                    {
                        json += ",";
                    }
                }
                json += "}";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    //string json = "{\"usuario\":\"admin\"," + "\"password\":\"admin\"}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Stream receiveStream = httpResponse.GetResponseStream();

                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                var result = readStream.ReadToEnd();
                //Devolvemos el contenido del cookie
                //Agregar los cookies obtenidos al CookieContainer
                //foreach (Cookie unacookie in httpResponse.Cookies)
                //{
                //    cookies.Add(unacookie);
                //}
                //result = result.Trim(' ','\n');
                dynamic datosTabla;
                //result =JsonConvert.SerializeObject(result, Formatting.Indented);
                datosTabla = JsonConvert.DeserializeObject(result);
                return datosTabla;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                throw;
            }
        }
    }

}
