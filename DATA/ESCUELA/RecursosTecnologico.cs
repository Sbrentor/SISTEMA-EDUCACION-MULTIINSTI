using System;
using System.Collections.Generic;

namespace DATA;

public partial class RecursosTecnologico
{
    public long Id { get; set; }

    public string Recurso { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;
}
