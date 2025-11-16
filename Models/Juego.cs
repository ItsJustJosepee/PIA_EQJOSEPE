using System;
using System.Collections.Generic;

namespace PIA_EQJOSEPE.Models;

public partial class Juego
{
    public int IdJuego { get; set; }

    public string? Creador { get; set; }

    public string? NombreJuego { get; set; }

    public string? Categoria { get; set; }

    public string? Modalidad { get; set; }

    public string? Tipo { get; set; }
}
