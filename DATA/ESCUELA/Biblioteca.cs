using System;
using System.Collections.Generic;

namespace DATA;

public partial class Biblioteca
{
    public long Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string Disponibilidad { get; set; } = null!;
}
