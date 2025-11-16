using System;
using System.Collections.Generic;

namespace PIA_EQJOSEPE.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsu { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly? Cumpleaños { get; set; }
}
