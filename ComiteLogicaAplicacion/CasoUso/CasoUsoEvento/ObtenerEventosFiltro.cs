using ComiteCompartido.Dtos.Eventos;
using ComiteCompartido.Dtos.Mappers;
using ComiteLogicaNegocio.InterfacesCasoUso;
using ComiteLogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiteLogicaAplicacion.CasoUso.CasoUsoEvento
{
    public class ObtenerEventosFiltro : IObtenerEventosFiltro<EventoConAtletaListadoDto>
    {
        IRepositorioEvento _repositorio;

        public ObtenerEventosFiltro(IRepositorioEvento repositorio)
        {
            _repositorio = repositorio;
        }
        public IEnumerable<EventoConAtletaListadoDto> Ejecutar()
        {
            // Fetch events, including related Disciplina, EventoAtletas, and Atletas
            var eventos = _repositorio.GetAll();

            // Map the events to the new DTO format
            var eventoDtos = EventoMapper.ToListaConAtletasDto(eventos);

            return eventoDtos;
        }
    }
}
