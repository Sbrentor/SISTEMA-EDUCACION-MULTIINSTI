using System;
using System.Collections.Generic;

namespace DATA;

public partial class ActividadesExtra
{
    public long Id { get; set; }

    public string Actividad { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime Horario { get; set; }

    public string Responsable { get; set; } = null!;
}
