using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Legajo : EstrategiaComparacion {
        public bool SosIgual(IAlumno a, IAlumno a1) {
            return a.GetLegajo() == a1.GetLegajo();
        }

        public bool SosMayor(IAlumno a, IAlumno a1) {
            return a.GetLegajo() > a1.GetLegajo();
        }

        public bool SosMenor(IAlumno a, IAlumno a1) {
            return a.GetLegajo() < a1.GetLegajo();
        }
    }
}
