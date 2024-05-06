using System;
using System.Collections.Generic;

namespace DATA;

public partial class RegistroAcceso
{
    public long Id { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string TipoAcceso { get; set; } = null!;

    public string Resultado { get; set; } = null!;
}
