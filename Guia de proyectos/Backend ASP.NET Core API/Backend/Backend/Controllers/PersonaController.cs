using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Backend.Controllers.Repository;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet("search/{search}")]
        public List<PersonaDatos> GetPersonaDatos(string search) => Repository.persona.Where(p => p.name.ToUpper().Contains(search.ToUpper())).ToList();
    }
}
