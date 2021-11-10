using System.Collections.Generic;
using CrudPeople.Models.Interfaces;

namespace CrudPeople.Models
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        List<Person> GetAllByAge();
    }
}