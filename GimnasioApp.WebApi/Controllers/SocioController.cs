using Microsoft.AspNetCore.Mvc;
using Gimnasio.Clases;
using Gimnasio.Services;
using Gimnasio.Clases.Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GimnasioApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        APISocioServices sociosService = new APISocioServices();
        // GET: api/<SocioController>
        [HttpGet]
        [Route("/socios/allSocios")]
        public IEnumerable<SocioAdmin> GetAllSocios()
        {
            return sociosService.getSocios();
        }

        // GET by Id action
        [HttpGet]
        [Route("/socios/socioById")]
        public ActionResult<SocioAdmin> GetById(int id)
        {
            var socio = sociosService.getSocioById(id);

            if (socio == null)
                return NotFound();

            return socio;
        }


        // POST api/<SocioController>
        [HttpPost]
        [Route("/socios/crearSocio")]
        public void crearSocio(Persona newPerson)
        {
            int idPerson=sociosService.insertPersona(newPerson);
            sociosService.insertSocio(idPerson);

        }


        //PUT api/<SocioController>/5
        [HttpPut("{id}")]
        //[Route("CambiarAbono")]
        public IActionResult updateAbonoSocio(SocioDto socio, int id)
        {
            if (id != socio.IdSocio)
                return BadRequest();

            var existingSocio = sociosService.getSocioById(id);
            if (existingSocio is null)
                return NotFound();

            sociosService.editarAbonoSocio(id, socio);

            return NoContent();
        }

        // DELETE api/<SocioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
