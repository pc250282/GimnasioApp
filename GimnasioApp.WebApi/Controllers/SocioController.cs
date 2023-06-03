using Microsoft.AspNetCore.Mvc;
using Gimnasio.Clases;
using Gimnasio.Services;
using GimnasioApp.WebApi.Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GimnasioApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        SecurityServices sociosService = new SecurityServices();
        // GET: api/<SocioController>
        [HttpGet]
        public IEnumerable<SocioAdmin> GetAllSocios()
        {
            return sociosService.getSocios();
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<SocioAdmin> Get(int id)
        {
            var socio = sociosService.getSocioById(id);

            if (socio == null)
                return NotFound();

            return socio;
        }

        // POST api/<SocioController>
        [HttpPost]
        public void crearSocio(Persona newPerson)
        {
            int idPerson=sociosService.insertPersona(newPerson);
            sociosService.insertSocio(idPerson);

        }

        // PUT api/<SocioController>/5
        [HttpPut("{id}")]
        public IActionResult updateSocio(SocioDto socio, int id)
        {
            if (id != socio.IdSocio)
                return BadRequest();

            var existingSocio = sociosService.getSocioById(id);
            if (existingSocio is null)
                return NotFound();

            sociosService.actualizarFechaPagoSocio(id,DateTime.Now);

            return NoContent();
        }

        // DELETE api/<SocioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
