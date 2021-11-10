using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CrudPeople.Models
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
    
        public PersonRepository(DataContext context)
        {           
            this.context = context;
        }

        public void Create(Person person)
        {
            person.city = context.cities.Find(person.city.Id);
            context.Add(person);
            context.SaveChanges();
        }
        public List<Person> GetAll()
        {
            return context.people.Include(x=>x.city).ToList();
            /*
            select *
            from pessoas p inner join cidades c
                on p.cid_id = c.id
            */
        }
        
        public Person GetById(int id)
        {
            return context.people.Include(x=>x.city).SingleOrDefault(i=>i.id == id);
        }
        
        public void Delete(int id)
        {
            context.people.Remove(GetById(id));
            context.SaveChanges();

        }
        public void Update(Person person)
        {
            person.city = context.cities.Find(person.city.Id);
            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<Person> GetAllByAge()
        {
            throw new System.NotImplementedException();
        }
    }
}