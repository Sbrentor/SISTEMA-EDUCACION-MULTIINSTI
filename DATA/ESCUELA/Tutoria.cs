using System;
using System.Collections.Generic;

namespace DATA;

public partial class Tutoria
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public string Profesor { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFinal { get; set; }
}
