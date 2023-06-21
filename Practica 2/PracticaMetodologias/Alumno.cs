using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Alumno : Persona {

        private int _legajo;
        private int _promedio;
        private EstrategiaComparacion strategy;

        public Alumno(string n, int d, int legajo, int promedio) : base(n, d) {
            _legajo = legajo;
            _promedio = promedio;
            strategy = new Dni();
        }

        public void SetStrategy(EstrategiaComparacion es) {
            this.strategy = es; 
        }

        public int GetLegajo() {

            return _legajo;
        }
        public int GetPromedio() {

            return _promedio;
        }

        public override bool SosIgual(Comparable c) {
            Alumno a = (Alumno)c;
            return strategy.SosIgual(this, a);
        }

        public override bool SosMayor(Comparable c) {
            Alumno a = (Alumno)c;
            return strategy.SosMayor(this, a);
        }

        public override bool SosMenor(Comparable c) {
            Alumno a = (Alumno)c;
            return strategy.SosMenor(this, a);
        }

        public override string ToString() {
            return $"[ Nombre: {_nombre} dni: {_dni} promedio: {_promedio} legajo:{_legajo} ]";
        }
    }
}
