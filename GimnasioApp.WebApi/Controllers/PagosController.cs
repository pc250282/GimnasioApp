using Gimnasio.Clases;
using Gimnasio.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GimnasioApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        APIPagosServices pagosServices= new APIPagosServices();
        // GET: api/<PagosController>
        [HttpGet]
        public IEnumerable<Pagos> GetAllPagos()
        {
            return pagosServices.getHistorialDePagos();
        }

        // GET api/<PagosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PagosController>
        [HttpPost]
        public void registrarPago(Pagos nuevoPago)
        {
            pagosServices.insertPago(nuevoPago);
        }

        // PUT api/<PagosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PagosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
