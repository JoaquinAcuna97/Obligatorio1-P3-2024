﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCliente.Models.Dtos.Eventos
{
    public record EventoAltaDto(
    int id,
    int DisciplinaId,
    string Nombre,
    DateTime Inicio,
    DateTime Fin
    )
    {
    }
}
