using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Contrato { get; set; }

        public Cliente(int id, string nome, string contrato)
        {
            this.IdCliente = id;
            this.Nome = nome;
            this.Contrato = contrato;
        }
    }
}
