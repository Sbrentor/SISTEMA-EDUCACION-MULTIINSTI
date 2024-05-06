using System;
using System.Collections.Generic;

namespace DATA;

public partial class ComedorEscolar
{
    public long Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Menu { get; set; } = null!;

    public string Estudiante { get; set; } = null!;
}
