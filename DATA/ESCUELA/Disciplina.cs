using System;
using System.Collections.Generic;

namespace DATA;

public partial class Disciplina
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
