using System;
using System.Collections.Generic;

namespace databaseDAL.Modelo
{
    /// <summary>
    /// Entidad que regula las asignaturas del centro
    /// </summary>
    public partial class Asignatura
    {
        public long AsignaturaId { get; set; }
        public string AsignaturaNombre { get; set; } = null!;
    }
}
