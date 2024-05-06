using System;
using System.Collections.Generic;

namespace DATA;

public partial class PrestamosLibro
{
    public long Id { get; set; }

    public string Estudiante { get; set; } = null!;

    public string Libro { get; set; } = null!;

    public DateTime FechaPrestamo { get; set; }

    public DateTime FechaDevolucion { get; set; }
}
