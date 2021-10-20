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
            context.Add(person);
            context.SaveChanges();
        }
        public List<Person> GetAll()
        {
            return context.people.ToList();
        }
        
        public Person GetById(int id)
        {
            return context.people.SingleOrDefault(i=>i.id == id);
        }
        
        public void Delete(int id)
        {
            context.people.Remove(GetById(id));
            context.SaveChanges();

        }
        public void Update(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}