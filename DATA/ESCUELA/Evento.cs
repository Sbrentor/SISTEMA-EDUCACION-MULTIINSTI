using System;
using System.Collections.Generic;

namespace DATA;

public partial class Evento
{
    public long Id { get; set; }

    public string Evento1 { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime Fecha { get; set; }

    public string Lugar { get; set; } = null!;
}
