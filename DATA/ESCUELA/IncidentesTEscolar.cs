using System;
using System.Collections.Generic;

namespace DATA;

public partial class IncidentesTEscolar
{
    public long Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public string RutaAfectada { get; set; } = null!;

    public string AccionTomada { get; set; } = null!;
}
