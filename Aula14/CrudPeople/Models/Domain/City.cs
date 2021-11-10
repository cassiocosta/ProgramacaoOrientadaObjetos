using System.Collections.Generic;

namespace CrudPeople.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }
        public List<Person> people { get; set; }
    }
}