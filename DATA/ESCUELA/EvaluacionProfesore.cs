using System;
using System.Collections.Generic;

namespace DATA;

public partial class EvaluacionProfesore
{
    public long Id { get; set; }

    public string Profesor { get; set; } = null!;

    public DateTime FechaEvaluacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Calificacion { get; set; }
}
