using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Backend.Controllers.Repository;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet("all")]

        public List<PersonaDatos> GetPersonaDatos() => Repository.persona;

        [HttpGet("{id}")]
        public ActionResult<PersonaDatos> Get(int id)
        {
            var persona = Repository.persona.FirstOrDefault(p => p.id == id);

            if (persona == null)
            {
                return NotFound();
            }

            return Ok(persona);
        }


        [HttpGet("search/{search}")]
        public List<PersonaDatos> Get(string search) => 
            Repository.persona.Where(p => p.name.ToUpper().Contains(search.ToUpper())).ToList();


       
    }
}
