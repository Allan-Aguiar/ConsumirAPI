using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExemploWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConsumirAPI.Controllers
{
    public class CRUDController : Controller
    {
        public async Task<IActionResult> CRUD()
        {
            var httpClient = new HttpClient();
            var Json = await httpClient.GetStringAsync("http://localhost:1255/api/Clientes");

            var clientesList = JsonConvert.DeserializeObject<List<Cliente>>(Json);

            return View(clientesList);
        }
    }
}