using System;
using System.Collections.Generic;

namespace DATA;

public partial class SubvencioneBeca
{
    public long Id { get; set; }

    public string Beneficiario { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public decimal Monto { get; set; }

    public DateTime FechaOtorgamiento { get; set; }
}
