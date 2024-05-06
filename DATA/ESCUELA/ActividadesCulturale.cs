using System;
using System.Collections.Generic;

namespace DATA;

public partial class ActividadesCulturale
{
    public long Id { get; set; }

    public string Actividad { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Responsable { get; set; } = null!;
}
