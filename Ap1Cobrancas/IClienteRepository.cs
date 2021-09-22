using System.Collections.Generic;
using Cobrancas;

namespace Ap1Cobrancas
{
    public interface IClienteRepository
    {
         void Create(Cliente cliente);
         void Update(Cliente cliente);
         void Delete(int id);

         Cliente GetById(int id);
         List<Cliente> GetAll();

         
    }
}