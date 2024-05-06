using System;
using System.Collections.Generic;

namespace DATA;

public partial class ClubesEstudiante
{
    public long Id { get; set; }

    public string Club { get; set; } = null!;

    public string Responsable { get; set; } = null!;

    public string DiaReunion { get; set; } = null!;
}
