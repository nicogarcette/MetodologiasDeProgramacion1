using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class AdaptadorAlumno : Student {

        private IAlumno alumno;
 
        public AdaptadorAlumno(IAlumno d) {
            this.alumno = d;
        }
        public IAlumno GetStudent() { 
            return alumno.GetAlumno();
        }

        public bool equals(Student student) {

            IAlumno alum = ((AdaptadorAlumno)student).GetStudent();
            return alumno.SosIgual(alum);
        }

        public string getName() {
            return alumno.GetNombre();
        }

        public bool greaterThan(Student student) {
            IAlumno alum = ((AdaptadorAlumno)student).GetStudent();
            return alumno.SosMayor(alum);
        }

        public bool lessThan(Student student) {
            IAlumno alum = ((AdaptadorAlumno)student).GetStudent();
            return alumno.SosMenor(alum);
        }

        public void setScore(int score) {
            this.alumno.SetCalificacion(score);
        }

        public string showResult() {
            return alumno.MostrarResultado();
        }

        public int yourAnswerIs(int question) {
            return alumno.ResponderPregunta(question);
        }
    }
}
