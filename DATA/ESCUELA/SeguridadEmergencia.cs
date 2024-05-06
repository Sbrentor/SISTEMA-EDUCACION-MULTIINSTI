using System;
using System.Collections.Generic;

namespace DATA;

public partial class SeguridadEmergencia
{
    public long Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string AccionesTomadas { get; set; } = null!;
}
