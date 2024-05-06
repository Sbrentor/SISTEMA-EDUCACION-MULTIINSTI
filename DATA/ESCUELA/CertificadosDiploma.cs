using System;
using System.Collections.Generic;

namespace DATA;

public partial class CertificadosDiploma
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime FechaEmision { get; set; }

    public string Descripcion { get; set; } = null!;
}
