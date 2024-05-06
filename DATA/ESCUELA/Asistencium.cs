using System;
using System.Collections.Generic;

namespace DATA;

public partial class Asistencium
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public bool Asistencia { get; set; }
}
