using ComiteCompartido.Dtos.Atletas;
using ComiteCompartido.Dtos.Eventos;
using ComiteLogicaNegocio.InterfacesCasoUso;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class EventosController : Controller
    {
        IObtenerEventosFiltro<EventoConAtletaListadoDto> _obtener;
        public EventosController(
            IObtenerEventosFiltro<EventoConAtletaListadoDto> obtener)
        {
            _obtener = obtener;
        }

        // GET: api/<EventosController>
        [HttpGet("Eventos/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ObtenerEventos()
        {
            try
            {
                var eventos = _obtener.Ejecutar();
                if (eventos == null)
                {
                    return StatusCode(204);
                }
                return Ok(eventos);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
