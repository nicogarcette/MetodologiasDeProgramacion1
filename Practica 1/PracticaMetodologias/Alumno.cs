using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Alumno : Persona {

        private int _legajo;
        private int _promedio;

        public Alumno(string n, int d, int legajo, int promedio) : base(n, d) {
            _legajo = legajo;
            _promedio = promedio;
        }

        public int GetLegajo() {

            return _legajo;
        }
        public int GetPromedio() {

            return _promedio;
        }

        public override bool SosIgual(Comparable c) {
            Alumno a = (Alumno)c;
            return _legajo == a.GetLegajo();
        }

        public override bool SosMayor(Comparable c) {
            Alumno a = (Alumno)c;
            return _promedio > a.GetPromedio();

        }

        public override bool SosMenor(Comparable c) {
            Alumno a = (Alumno)c;
            return _promedio < a.GetPromedio();
        }

        public override string ToString() {
            return $"[ Nombre: {_nombre} dni: {_dni} promedio: {_promedio} legajo:{_legajo} ]";
        }
    }
}
