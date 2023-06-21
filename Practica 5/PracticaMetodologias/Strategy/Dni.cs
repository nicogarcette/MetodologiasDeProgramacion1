using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class Dni : EstrategiaComparacion {
        public bool SosIgual(IAlumno a, IAlumno a1) {
            return a.GetDni() == a1.GetDni();
        }

        public bool SosMayor(IAlumno a, IAlumno a1) {
            return a.GetDni() > a1.GetDni();
        }

        public bool SosMenor(IAlumno a, IAlumno a1) {
            return a.GetDni() < a1.GetDni();
        }
    }
}
