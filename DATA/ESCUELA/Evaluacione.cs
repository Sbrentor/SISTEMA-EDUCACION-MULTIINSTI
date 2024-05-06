using System;
using System.Collections.Generic;

namespace DATA;

public partial class Evaluacione
{
    public long Id { get; set; }

    public string Grado { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string TipoEvaluacion { get; set; } = null!;
}
