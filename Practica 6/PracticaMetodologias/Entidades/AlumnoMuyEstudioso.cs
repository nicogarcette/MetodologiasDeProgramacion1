using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class AlumnoMuyEstudioso : Alumno {
        public AlumnoMuyEstudioso(string n, int d, int legajo, int promedio) : base(n, d, legajo, promedio) {
        }

        public override int ResponderPregunta(int pregunta) {

            return pregunta % 3;
        }

    }
}
