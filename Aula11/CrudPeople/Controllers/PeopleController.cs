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

        [HttpGet("{Id}")] // localhost:5000/people/10
        public Person Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            _repository.Create(person);
            return Ok(person);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Person person)
        {
            _repository.Update(person);
            return Ok( new {
                message = "Atualizado com sucesso.",
                codeHttp=201,
                objetoCreated = person
            });
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok(new{
                message="Person foi deletado com sucesso.",
                id = id
            });
        }
         
    }
}