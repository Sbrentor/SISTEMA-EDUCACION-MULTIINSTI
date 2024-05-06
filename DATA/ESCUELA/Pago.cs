using System;
using System.Collections.Generic;

namespace DATA;

public partial class Pago
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public decimal Monto { get; set; }

    public DateTime Fecha { get; set; }

    public string MetodoPago { get; set; } = null!;
}
