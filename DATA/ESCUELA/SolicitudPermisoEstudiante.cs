using System;
using System.Collections.Generic;

namespace DATA;

public partial class SolicitudPermisoEstudiante
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Estado { get; set; } = null!;
}
