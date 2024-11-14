
using ComiteAccesoADatos.EF;
using ComiteCompartido.Dtos.Disciplinas;
using ComiteLogicaAplicacion.CasoUso.Disciplinas;
using ComiteLogicaNegocio.CasoUso.Disciplinas;
using ComiteLogicaNegocio.InterfacesCasoUso;
using ComiteLogicaNegocio.InterfacesRepositorios;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IRepositorioDisciplina, RepositorioDisciplina>();

            builder.Services.AddScoped<IAlta<DisciplinasAltaDto>, AltaDisciplina>();
            builder.Services.AddScoped<IObtenerTodos<DisciplinasListadoDto>, ObtenerDisciplinas>();
            builder.Services.AddScoped<IObtener<DisciplinasAltaDto>, ObtenerDisciplina>();
            builder.Services.AddScoped<IEliminar<DisciplinasAltaDto>, EliminarDisciplina>();
            builder.Services.AddScoped<IEditar<DisciplinasAltaDto>, EditarDisciplina>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // inyectando la Comite Contex
            builder.Services.AddDbContext<ComiteContext>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
