using System;
using System.Collections.Generic;


namespace PracticaMetodologias {
    public class Promedio : EstrategiaComparacion {
        public bool SosIgual(IAlumno a, IAlumno a1) {
            return a.GetPromedio() == a1.GetPromedio();
        }

        public bool SosMayor(IAlumno a, IAlumno a1) {

            return a.GetPromedio() > a1.GetPromedio();
        }

        public bool SosMenor(IAlumno a, IAlumno a1) {
            return a.GetPromedio() < a1.GetPromedio();
        }
    }
}
