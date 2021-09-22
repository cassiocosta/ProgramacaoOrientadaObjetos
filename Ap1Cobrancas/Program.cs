using System.Net.NetworkInformation;
using System.Linq;
using System.IO.Enumeration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Ap1Cobrancas;

namespace Cobrancas
{
    class Program
    {
        static void Main(string[] args,
            ISampleInterface _pInterface,
            IClienteRepository _clienteRepository)
        {
            CobrancaRepository _repository = new CobrancaRepository();
            string fileName = "cob.json";
            string jsonString = File.ReadAllText(fileName);            

            _repository.Create(JsonSerializer.Deserialize<List<Cobranca>>(jsonString));
            var somenteDaJoana = _repository.GetAllByName("joana");

            ISampleInterface _interface = _pInterface;
            IClienteRepository _cliente = _clienteRepository;            
        }
    }
}
