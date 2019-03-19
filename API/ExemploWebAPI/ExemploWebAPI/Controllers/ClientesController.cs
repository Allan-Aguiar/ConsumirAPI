using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get()
        {
            return clientes;
        }
        
        public void Post(int id, string nome, string contrato)
        {
            if (!string.IsNullOrEmpty(nome) && id != 0 && !string.IsNullOrEmpty(contrato))
            {
                clientes.Add(new Cliente(id,nome,contrato));
            }            
        }

        public void Delete(int id)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.IdCliente.Equals(id))));
        }
    }
}
