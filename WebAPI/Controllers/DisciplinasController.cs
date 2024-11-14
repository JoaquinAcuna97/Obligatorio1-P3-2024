using ComiteCompartido.Dtos.Disciplinas;
using ComiteLogicaNegocio.Excepciones;
using ComiteLogicaNegocio.InterfacesCasoUso;
using ComiteLogicaNegocio.Vo.Generic;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DisciplinasController : ControllerBase
    {

        IAlta<DisciplinasAltaDto> _alta;
        IObtenerTodos<DisciplinasListadoDto> _obtenerTodos;
        IObtener<DisciplinasAltaDto> _obtener;
        IEliminar<DisciplinasAltaDto> _eliminar;
        IEditar<DisciplinasAltaDto> _editar;

        public DisciplinasController(
            IAlta<DisciplinasAltaDto> alta,
            IObtenerTodos<DisciplinasListadoDto> obtenerTodos,
            IObtener<DisciplinasAltaDto> obtener,
            IEliminar<DisciplinasAltaDto> eliminar,
            IEditar<DisciplinasAltaDto> editar
        ){
            _alta = alta;
            _obtenerTodos = obtenerTodos;
            _obtener = obtener;
            _eliminar = eliminar;
            _editar = editar;
        }

        // GET: api/<DisciplinasController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            try
            {
                var disciplinas = _obtenerTodos.Ejecutar();
                if (disciplinas.Count() == 0)
                {
                    return StatusCode(204);
                }
                return Ok(disciplinas);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<DisciplinasController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DisciplinasAltaDto> GetId(int id)
        {

            try
            {
                var disciplina = _obtener.Ejecutar(id);
                return disciplina;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // GET api/<DisciplinasController>/nombre/Boxeo
        [HttpGet("nombre/{nombre}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DisciplinasAltaDto> GetByName(string nombre)
        {
            try
            {
                var disciplina = _obtener.Ejecutar(nombre); // Assuming _obtenerPorNombre is the method to fetch by name
                if (disciplina == null)
                {
                    return NotFound(); // Return 404 if not found
                }
                return Ok(disciplina); // Return 200 OK with the data
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Create(DisciplinasAltaDto disciplina)
        {
            try
            {
                _alta.Ejecutar(disciplina);
                var d = _obtener.Ejecutar(disciplina.Nombre);
                return Ok(d);

            }
            catch (LogicaNegocioException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Update(int id, [FromBody] DisciplinasAltaDto disciplina)
        {

            try
            {
                DisciplinasAltaDto d = new DisciplinasAltaDto(id, disciplina.Nombre, disciplina.Year);
                _editar.Ejecutar(d);

                return Ok();
            }
            catch (LogicaNegocioException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Delete(int id)
        {

            try
            {
                DisciplinasAltaDto d = new DisciplinasAltaDto(id, "", 0);
                _eliminar.Ejecutar(d);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}
