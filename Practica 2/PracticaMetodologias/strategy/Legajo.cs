using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Legajo : EstrategiaComparacion {
        public bool SosIgual(Alumno a, Alumno a1) {
            return a.GetLegajo() == a1.GetLegajo();
        }

        public bool SosMayor(Alumno a, Alumno a1) {
            return a.GetLegajo() > a1.GetLegajo();
        }

        public bool SosMenor(Alumno a, Alumno a1) {
            return a.GetLegajo() < a1.GetLegajo();
        }
    }
}
