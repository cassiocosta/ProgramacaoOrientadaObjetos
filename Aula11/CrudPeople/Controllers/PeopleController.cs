using System.Collections;
using System.Collections.Generic;
using CrudPeople.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudPeople.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        public PeopleController()
        {
        }

        private PersonRepository _repository = new PersonRepository();

        [HttpGet()]
        public IEnumerable<Person> Get()
        {

            if(_repository.GetAll().Count==0)
            {            
                _repository.Create(new Person(10,"Diego","Rua X"));
                _repository.Create(new Person(11,"Gean","Rua Y"));
                _repository.Create(new Person(12,"Luiz Carlos","Rua Z"));
            }
            return _repository.GetAll();
        }
         
    }
}