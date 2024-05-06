using System;
using System.Collections.Generic;

namespace DATA;

public partial class SolicitudesEmpleo
{
    public long Id { get; set; }

    public string Solicitante { get; set; } = null!;

    public string PuestoSolicitado { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Estado { get; set; } = null!;
}
