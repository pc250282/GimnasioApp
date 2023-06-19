using Gimnasio.Clases;
using Gimnasio.Clases.Dto;
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
        
        [Route("/Pagos/Historico")]
        [HttpGet]
        public ActionResult<List<Pagos>> GetAllPagos() => pagosServices.getHistorialDePagos();
 

        [Route("/Pagos/Reporte")]
        [HttpGet]
        public IEnumerable<PagoDto> GetPagos() => pagosServices.getPagos();


        // GET api/<PagosController>/5
        [Route("/Pagos/ReportePorNumPago")]
        [HttpGet]
        public ActionResult<PagoDto> getPagoById(int id)
        {
            var pago = pagosServices.getPagoById(id);

            if (pago == null)
                return NotFound();

            return pago;
        }

        // POST api/<PagosController>
        [Route("/Pagos/RegistrarPago")]
        [HttpPost]
        public IActionResult insertarPago (Pagos nuevoPago) 
        {
            pagosServices.insertPago(nuevoPago);
            return CreatedAtAction(nameof(getPagoById), new { id = nuevoPago.idPago }, nuevoPago);
        } 
            
  

        // PUT api/<PagosController>/5
        [Route("/Pagos/CambiarFormaDePago")]
        [HttpPut]
        public IActionResult cambiarFormaDePago(int idPago, int idMdp)
        {
            var pagoExiste = pagosServices.getPagoById(idPago);
            if (pagoExiste is null)
                return NotFound();

            pagosServices.editarFormaDePago(idPago, idMdp);

            return NoContent();

        }

        // DELETE api/<PagosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
