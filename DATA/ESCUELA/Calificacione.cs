using System;
using System.Collections.Generic;

namespace DATA;

public partial class Calificacione
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public string Grado { get; set; } = null!;

    public int Calificacion { get; set; }
}
