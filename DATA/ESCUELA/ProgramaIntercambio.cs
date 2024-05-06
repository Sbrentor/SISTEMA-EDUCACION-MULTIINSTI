using System;
using System.Collections.Generic;

namespace DATA;

public partial class ProgramaIntercambio
{
    public long Id { get; set; }

    public string Programa { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string PaisDestino { get; set; } = null!;

    public string Duracion { get; set; } = null!;
}
