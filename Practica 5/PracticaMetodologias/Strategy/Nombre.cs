using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    internal class Nombre : EstrategiaComparacion {
        public bool SosIgual(IAlumno a, IAlumno a1) {
            return a.GetNombre() == a1.GetNombre();
        }

        public bool SosMayor(IAlumno a, IAlumno a1) {
            return a.GetNombre().Length > a1.GetNombre().Length;
        }

        public bool SosMenor(IAlumno a, IAlumno a1) {
            return a.GetNombre().Length < a1.GetNombre().Length;
        }
    }
}
