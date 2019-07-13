using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sisso.BL.Service;

namespace Sisso.Service.Controllers
{
    [Route("api/Personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private IPersonaService PersonaService { get; set; }

        public PersonaController(IPersonaService personaService)
        {
            PersonaService = personaService;
        }

        // GET: api/Persona
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await PersonaService.Info();
            return Ok(response);
        }

        // GET: api/Persona/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Persona
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Persona/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
