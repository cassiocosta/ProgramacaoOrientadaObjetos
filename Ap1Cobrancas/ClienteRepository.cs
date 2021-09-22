using System.Collections.Generic;
using Ap1Cobrancas;

namespace Cobrancas
{
    public class ClienteRepository : IClienteRepository
    {
        public static List<Cliente> clientes = new List<Cliente>();
    
        public ClienteRepository()
        {           
        }

        public void Create(Cliente cliente)
        {
            clientes.Add(cliente);
        }
        public List<Cliente> GetAll()
        {
            return clientes;
        }
        
        public Cliente GetById(int id)
        {
            return clientes.Find(i=>i.Id == id);
        }
        
        public void Delete(int id)
        {
            clientes.Remove(GetById(id));

        }
        public void Update(Cliente cliente)
        {
            var index  = clientes.FindIndex(x=>x.Id == cliente.Id);
            clientes[index].Nome = cliente.Nome;
            clientes[index].Fone = cliente.Fone;

        }
    }
}