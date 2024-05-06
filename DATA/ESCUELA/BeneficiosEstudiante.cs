using System;
using System.Collections.Generic;

namespace DATA;

public partial class BeneficiosEstudiante
{
    public long Id { get; set; }

    public string Beneficio { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Requisitos { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFinal { get; set; }
}
