using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public abstract class DecoradorAlumno : IAlumno{
        protected IAlumno alumno;

        public DecoradorAlumno(IAlumno alumno) {
            
            this.alumno = alumno;   
        }
        public virtual string MostrarResultado() {
            return alumno.MostrarResultado();
        }

        public int GetCalicacion() {
            return this.alumno.GetCalicacion();
        }

        public int GetLegajo() {
            return this.alumno.GetLegajo();
        }

        public IAlumno GetAlumno() {
            return this.alumno.GetAlumno();
        }

        public bool SosMayor(Comparable c) {
            return ((Alumno)alumno.GetAlumno()).SosMayor(c);
        }

        public bool SosMenor(Comparable c) {
            return ((Alumno)alumno.GetAlumno()).SosMenor(c);
        }

        public bool SosIgual(Comparable c) {

            return ((Alumno)alumno.GetAlumno()).SosIgual(c);
        }

        public string GetNombre() {
            return alumno.GetNombre();
        }

        public void SetCalificacion(int c) {
            alumno.SetCalificacion(c);
        }

        public int ResponderPregunta(int pregunta) {
            return alumno.ResponderPregunta(pregunta);
        }
    }
}
