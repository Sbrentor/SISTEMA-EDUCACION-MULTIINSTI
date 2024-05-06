using System;
using System.Collections.Generic;

namespace DATA;

public partial class Recurso
{
    public long Id { get; set; }

    public string Recurso1 { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int CantDisponible { get; set; }

    public string Ubicacion { get; set; } = null!;
}
