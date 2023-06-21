using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class DecoradorNotaEnLetras : DecoradorAlumno {
        public DecoradorNotaEnLetras(IAlumno alumno) : base(alumno) {
        }

        public override string MostrarResultado() {

            string[] letras = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };

            string cadena = base.MostrarResultado();
            string numero = $"({ letras[this.GetCalicacion()]})";

            return cadena + numero;
        }
    }
}
