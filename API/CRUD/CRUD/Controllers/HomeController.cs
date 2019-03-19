using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        #region [ Construtor ]

        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        #endregion 

        public IActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Clientes clientes)
        {
            var httpCli = new HttpClient();
            var json = await httpCli.GetStringAsync("http://localhost:1255/api/Clientes");

            var clientesList = JsonConvert.DeserializeObject<List<Clientes>>(json);

            Clientes clienteSave = clientesList.Where(x => x.idCliente.Equals(clientes.idCliente)).FirstOrDefault();

            clientes.idCliente = 0;
            clientes.Nome = clienteSave.Nome;
            clientes.Contrato = clienteSave.Contrato;
            
            _context.Cliente.Add(clientes);

            int test = _context.SaveChanges();

            return Redirect("/");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
