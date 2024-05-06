using System;
using System.Collections.Generic;

namespace DATA;

public partial class ProgresoAcademico
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Observacion { get; set; } = null!;
}
