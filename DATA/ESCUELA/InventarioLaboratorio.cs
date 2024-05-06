using System;
using System.Collections.Generic;

namespace DATA;

public partial class InventarioLaboratorio
{
    public long Id { get; set; }

    public string Articulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Cantidad { get; set; }

    public string Estado { get; set; } = null!;
}
