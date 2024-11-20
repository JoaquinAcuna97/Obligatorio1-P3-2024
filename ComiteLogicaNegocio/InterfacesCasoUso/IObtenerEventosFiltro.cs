﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiteLogicaNegocio.InterfacesCasoUso
{
    public interface IObtenerEventosFiltro<T>
    {
        IEnumerable<T> Ejecutar();
    }
}
