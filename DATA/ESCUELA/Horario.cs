using System;
using System.Collections.Generic;

namespace DATA;

public partial class Horario
{
    public long Id { get; set; }

    public string Grado { get; set; } = null!;

    public string DiasSemana { get; set; } = null!;

    public int HoraInicio { get; set; }

    public int HoraFinal { get; set; }
}
