using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiatil_Uni
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Grado { get; set; }
        public EstadoEstudiante Estado { get; set; }
    }
    public enum EstadoEstudiante
    {
        Becado,
        Regular
    }
}
