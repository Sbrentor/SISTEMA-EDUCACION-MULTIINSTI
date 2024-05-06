using System;
using System.Collections.Generic;

namespace DATA;

public partial class TransporteEscolar
{
    public long Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Ruta { get; set; } = null!;

    public string Conductor { get; set; } = null!;

    public string Estudiante { get; set; } = null!;
}
