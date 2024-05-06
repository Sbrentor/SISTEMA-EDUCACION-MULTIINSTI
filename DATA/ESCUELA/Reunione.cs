using System;
using System.Collections.Generic;

namespace DATA;

public partial class Reunione
{
    public long Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Lugar { get; set; } = null!;

    public int Participantes { get; set; }
}
