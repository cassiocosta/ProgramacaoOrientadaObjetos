using System.ComponentModel.DataAnnotations;
namespace CrudPeople.Models
{
    public class Person
    {
        public Person(){}

        public Person(int id, string name, string address, City city)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            
        }        
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; } 
        public City city { get; set; } 
    }
}