using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key, Column("idCliente")]
        public int idCliente { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Contrato")]
        public string Contrato { get; set; }
    }
}
