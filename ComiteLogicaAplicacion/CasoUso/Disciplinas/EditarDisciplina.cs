
using ComiteCompartido.Dtos.Mappers;
using ComiteCompartido.Dtos.Disciplinas;
using ComiteLogicaNegocio.Entidades;
using ComiteLogicaNegocio.InterfacesCasoUso;
using ComiteLogicaNegocio.InterfacesRepositorios;
using ComiteCompartido.Dtos.MappersDisciplina;

namespace ComiteLogicaAplicacion.CasoUso.Disciplinas
{
    public class EditarDisciplina : IEditar<DisciplinasAltaDto>
    {
        IRepositorioDisciplina _repositorio;

        public EditarDisciplina(IRepositorioDisciplina repositorio)
        {
            _repositorio = repositorio;
        }

        public void Ejecutar(DisciplinasAltaDto obj)
        {
            try
            {
                _repositorio.Edit(DisciplinaMapper.FromDto(obj));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la disciplina");
            }

        }
    }
}
