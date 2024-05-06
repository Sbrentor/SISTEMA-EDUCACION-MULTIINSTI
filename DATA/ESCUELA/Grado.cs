using System;
using System.Collections.Generic;

namespace DATA;

public partial class Grado
{
    public long Id { get; set; }

    public string NombreGrado { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Horario { get; set; } = null!;

    public string Profesor { get; set; } = null!;
}
