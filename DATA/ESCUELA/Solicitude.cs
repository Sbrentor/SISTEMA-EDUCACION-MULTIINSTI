using System;
using System.Collections.Generic;

namespace DATA;

public partial class Solicitude
{
    public long Id { get; set; }

    public string TipoSolicitud { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
