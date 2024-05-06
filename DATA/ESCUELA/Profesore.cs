using System;
using System.Collections.Generic;

namespace DATA;

public partial class Profesore
{
    public long Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime Fechanacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public string Materia { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int Telefono { get; set; }

    public string Mail { get; set; } = null!;
}
