using System;
using System.Collections.Generic;

namespace DATA;

public partial class AsistenciaProfesore
{
    public long Id { get; set; }

    public string Profesor { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public bool Asistemcia { get; set; }
}
