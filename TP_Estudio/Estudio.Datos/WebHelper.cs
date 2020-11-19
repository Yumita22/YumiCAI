using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Datos
{


    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;
        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net";
            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        public static string Get(string url)
        {
            string urlCompleta = rutaBase + url;
            string responseString = client.DownloadString(urlCompleta);
            return responseString;
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":true,\"id\":5,\"error\":null}";
            }
        }
    }
}

//          public static class WebHelper

//    {
//        public static WebClient webClient;
//        public static string rutaBase;

//        static WebHelper()
//        {
//            webClient = new WebClient();
//            webClient.Encoding = Encoding.UTF8;
//            //rutaBase = ConfigurationManager.AppSettings["URL_API"];
//            rutaBase = "https://cai-api.azurewebsites.net//api/v1/estudiocontable/";
//            webClient.Headers.Add("ContentType", "application/json");
//            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

//        }

//        //public static List<T> Get<T>(string Url)
//        //{
//        //    var uri = rutaBase + Url;

//        //    var responseString = webClient.DownloadString(uri);

//        //    List<T> rta = JsonToObjectList<T>(responseString);
//        //    return rta;
//        //}

//        public static string Get(string Url)
//        {
//            var uri = rutaBase + Url;

//            var responseString = webClient.DownloadString(uri);

//            return responseString;
//        }


//        public static string Post(string url, NameValueCollection parametros)
//        {
//            string uri = rutaBase + url;

//            try
//            {
//                var response = webClient.UploadValues(uri, parametros);

//                var responseString = Encoding.Default.GetString(response);

//                return responseString;
//            }
//            catch (Exception ex)
//            {
//                return "{ \"isOk\":true,\"id\":5,\"error\":null}";
//            }
//        }

//        public static string Post(string url, object objetoMap)
//        {
//            string uri = rutaBase + url;
//            NameValueCollection parametros = ObjectToJson(objetoMap);
//            parametros.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
//            //parametros.Add("Usuario", "894022");
//            try
//            {
//                var response = webClient.UploadValues(uri, parametros);

//                var responseString = Encoding.Default.GetString(response);

//                return responseString;
//            }
//            catch (Exception ex)
//            {
//                return "Error";
//            }

//        }


//        private static NameValueCollection ObjectToJson(object origen)
//        {
//            Type sourcetype = origen.GetType();

//            var sourceProperties = sourcetype.GetProperties();
//            NameValueCollection n = new NameValueCollection();

//            foreach (var match in sourceProperties)
//            {
//                n.Add(match.Name, match.GetValue(origen) != null ? match.GetValue(origen).ToString() : null);

//            }
//            return n;
//        }

//        private static List<T> JsonToObjectList<T>(string origen)
//        {
//            List<T> obj = JsonConvert.DeserializeObject<List<T>>(origen);
//            return obj;
//        }

//        public static T JsonToObject<T>(string origen)
//        {
//            T obj = JsonConvert.DeserializeObject<T>(origen);
//            return obj;
//        }



//    }
//    //{
//    //    public static WebClient webClient;
//    //    public static string rutaBase;

//    //    static WebHelper()
//    //    {
//    //        webClient = new WebClient();
//    //        webClient.Encoding = Encoding.UTF8;
//    //        rutaBase = ConfigurationManager.AppSettings["URL_API"];
//    //        webClient.Headers.Add("ContentType", "application/json");
//    //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

//    //    }

//    //    public static string Get(string Url)
//    //    {
//    //        var uri = rutaBase + Url;

//    //        var responseString = webClient.DownloadString(uri);

//    //        return responseString;
//    //    }

//    //    public static string Post(string url, NameValueCollection objetoMap)
//    //    {
//    //        string uri = rutaBase + url;
//    //        NameValueCollection parametros = ObjectToJson(objetoMap);
//    //        parametros.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

//    //        try
//    //        {
//    //            var response = webClient.UploadValues(uri, parametros);
//    //            var responseString = Encoding.Default.GetString(response);
//    //            return responseString;
//    //        }
//    //        catch (Exception ex)
//    //        {
//    //            return "Error";
//    //        }

//    //    }


//    //    private static NameValueCollection ObjectToJson(object origen)
//    //    {
//    //        Type sourcetype = origen.GetType();

//    //        var sourceProperties = sourcetype.GetProperties();
//    //        NameValueCollection n = new NameValueCollection();

//    //        foreach (var match in sourceProperties)
//    //        {
//    //            n.Add(match.Name, match.GetValue(origen).ToString());

//    //        }
//    //        return n;
//    //    }

//    //    private static List<T> JsonToObject<T>(string origen)
//    //    {
//    //        List<T> obj = JsonConvert.DeserializeObject<List<T>>(origen);
//    //        return obj;
//    //    }


//}

