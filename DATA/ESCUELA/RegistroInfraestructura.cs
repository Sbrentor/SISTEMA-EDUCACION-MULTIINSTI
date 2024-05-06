using System;
using System.Collections.Generic;

namespace DATA;

public partial class RegistroInfraestructura
{
    public long Id { get; set; }

    public string Edificio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime FechaUltimoMantenimiento { get; set; }
}
