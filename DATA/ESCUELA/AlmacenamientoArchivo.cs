using System;
using System.Collections.Generic;

namespace DATA;

public partial class AlmacenamientoArchivo
{
    public long Id { get; set; }

    public string Archivo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
