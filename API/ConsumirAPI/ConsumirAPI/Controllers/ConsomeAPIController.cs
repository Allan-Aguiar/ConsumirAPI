using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ConsumirAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConsumirAPI.Controllers
{
    public class ConsomeAPIController : Controller
    {
        public IActionResult Index()
        {
            string ApiBaseUrl = "http://localhost:1255/"; // endereço da sua api
            string MetodoPath = "api/Clientes"; //caminho do método a ser chamado

            var model = new ClientesViewModel();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var retorno = JsonConvert.DeserializeObject<List<string>>(streamReader.ReadToEnd());

                    if (retorno != null)
                        model.ListaClientes = retorno;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return View();
        }
    }
}