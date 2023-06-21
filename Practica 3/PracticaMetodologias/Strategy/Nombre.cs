using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    internal class Nombre : EstrategiaComparacion {
        public bool SosIgual(Alumno a, Alumno a1) {
            return a.GetNombre() == a1.GetNombre();
        }

        public bool SosMayor(Alumno a, Alumno a1) {
            return a.GetNombre().Length > a1.GetNombre().Length;
        }

        public bool SosMenor(Alumno a, Alumno a1) {
            return a.GetNombre().Length < a1.GetNombre().Length;
        }
    }
}
