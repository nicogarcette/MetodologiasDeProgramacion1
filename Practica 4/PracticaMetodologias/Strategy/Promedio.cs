using System;
using System.Collections.Generic;


namespace PracticaMetodologias {
    public class Promedio : EstrategiaComparacion {
        public bool SosIgual(Alumno a, Alumno a1) {
            return a.GetPromedio() == a1.GetPromedio();
        }

        public bool SosMayor(Alumno a, Alumno a1) {

            return a.GetPromedio() > a1.GetPromedio();
        }

        public bool SosMenor(Alumno a, Alumno a1) {
            return a.GetPromedio() < a1.GetPromedio();
        }
    }
}
