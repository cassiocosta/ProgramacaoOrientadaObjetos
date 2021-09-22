using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Xml.XPath;
using System.Net.Http.Headers;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;

namespace Cobrancas
{
    public class CobrancaRepository
    {
        public static List<Cobranca> cobrancas = new List<Cobranca>();
    
        public CobrancaRepository()
        {           
        }

        public void Create(Cobranca cobranca)
        {
            cobrancas.Add(cobranca);
            
        }
        public void Create(List<Cobranca> cobs)
        {
            cobrancas = cobs;            
        }
        public List<Cobranca> GetAll()
        {
            return cobrancas;
        }
        
        public Cobranca GetById(int id)
        {
            return cobrancas.Find(i=>i.Id == id);
        }

        public List<Cobranca> GetAllByName(string nome)
        {
            return cobrancas.Where(x=>x.Cliente.Nome.ToLower().Contains(nome.ToLower())).ToList();
        }
        public List<Cobranca> GetOpen()
        {
            return cobrancas.Where(x=>x.DataPgto==null).ToList();
        }       

        public List<Cobranca> GetClose()
        {
            return cobrancas.Where(x=>x.DataPgto!=null).ToList();
        }
        
        public void Delete(int id)
        {
            cobrancas.Remove(GetById(id));

        }
        public void Update(Cobranca cobranca)
        {
            var index  = cobrancas.FindIndex(x=>x.Id == cobranca.Id);
            cobrancas[index].Valor = cobranca.Valor;
            cobrancas[index].DataPgto = cobranca.DataPgto;

        }
    }
}