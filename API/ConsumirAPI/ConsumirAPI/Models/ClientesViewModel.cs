using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumirAPI.Models
{
    public class ClientesViewModel
    {
        public List<string> ListaClientes { get; set; }

        public ClientesViewModel()
        {
            ListaClientes = new List<string>();
        }
    }
}
