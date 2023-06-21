using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class DecoradorAsterisco : DecoradorAlumno {
        public DecoradorAsterisco(IAlumno alumno) : base(alumno) {
        }

        public override string MostrarResultado() {

            string cadena = base.MostrarResultado();
            string asteriscos = string.Empty;
            for (int i = 0; i < cadena.Length + 4; i++) {
                asteriscos += "*";
            }

            string newCadena = $"{asteriscos}\n* {cadena} *\n{asteriscos}";
      
            return newCadena;
        }
    }
}
