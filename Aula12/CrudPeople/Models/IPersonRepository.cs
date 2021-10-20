using System.Collections.Generic;

namespace CrudPeople.Models
{
    public interface IPersonRepository
    {
        Person GetById(int id);
        List<Person>GetAll();
        void Create(Person person);
        void Delete(int id);
        void Update(Person person);

        
    }
}