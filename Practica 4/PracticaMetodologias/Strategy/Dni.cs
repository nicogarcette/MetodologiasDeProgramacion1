using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class Dni : EstrategiaComparacion {
        public bool SosIgual(Alumno a, Alumno a1) {
            return a.GetDni() == a1.GetDni();
        }

        public bool SosMayor(Alumno a, Alumno a1) {
            return a.GetDni() > a1.GetDni();
        }

        public bool SosMenor(Alumno a, Alumno a1) {
            return a.GetDni() < a1.GetDni();
        }
    }
}
