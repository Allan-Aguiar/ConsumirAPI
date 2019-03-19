using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models.repository
{
    public interface ICliente
    {
        IEnumerable<Clientes> GetAll();
        IEnumerable<Clientes> GetByID(string ID);
        void Post(Clientes cargo);
        void Put(Clientes cargo);
        void Delete(string ID);
    }
}
