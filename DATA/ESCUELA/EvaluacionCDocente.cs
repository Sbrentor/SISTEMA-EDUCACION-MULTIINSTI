using System;
using System.Collections.Generic;

namespace DATA;

public partial class EvaluacionCDocente
{
    public long Id { get; set; }

    public string Profesor { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string CompetenciasEvaluadas { get; set; } = null!;

    public int Puntuacion { get; set; }
}
