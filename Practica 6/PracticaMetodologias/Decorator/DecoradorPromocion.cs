using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class DecoradorPromocion : DecoradorAlumno {
        public DecoradorPromocion(IAlumno alumno) : base(alumno) {
        }

        public override string MostrarResultado() {

            string cadena = base.MostrarResultado();

            int nota = this.GetCalicacion();
            string promocion = string.Empty;

            if (nota >= 7) {
                promocion = "(APROBADO)";
            } else {
                promocion = "(DESAPROBADO)";
            }

            return cadena + promocion;
        }
    }
}
