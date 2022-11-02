using System;
using System.Collections.Generic;

namespace databaseDAL.Modelo
{
    /// <summary>
    /// Entidad que regula los alumnos del centro
    /// </summary>
    public partial class Alumno
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
    }
}
