using System;
using System.Collections.Generic;

namespace DATA;

public partial class Estudiante
{
    public long Id { get; set; }

    public string Nombrecompleto { get; set; } = null!;

    public DateTime Fechanacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public string Grado { get; set; } = null!;

    public string Direccion { get; set; } = null!;
}
