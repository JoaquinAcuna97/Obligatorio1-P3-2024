﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiteCompartido.Dtos.Usuarios
{
    public record LoginDto (
        string Password,
        string Email
        )
    {
    }
}
