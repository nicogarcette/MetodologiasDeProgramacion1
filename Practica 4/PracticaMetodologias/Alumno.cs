using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class Alumno : Persona, IAlumno {

        private int _legajo;
        private int _promedio;
        private EstrategiaComparacion strategy;
        private int calificacion;

        public Alumno(string n, int d, int legajo, int promedio) : base(n, d) {
            _legajo = legajo;
            _promedio = promedio;
            strategy = new Dni();
        }

        public void SetStrategy(EstrategiaComparacion es) {
            this.strategy = es; 
        }
        public int GetPromedio() {

            return _promedio;
        }

        public virtual int ResponderPregunta(int pregunta) {

            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

            return generador.NumeroAleatorio(3);
        }

        public string MostrarCalificacion() {

            return $"{this._nombre} {this.calificacion}";
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

        // metodo IAlumno
        public string MostrarResultado() {
            return this.MostrarCalificacion();
        }

        public int GetCalicacion() {
           return calificacion;
        }
        public int GetLegajo() {
            return _legajo;
        }

        public IAlumno GetAlumno() {
            return this;
        }

        public void SetCalificacion(int c) {
           this.calificacion = c;
        }
    }
}
