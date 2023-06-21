using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Aula {

        private Teacher _teacher;

        public void Comenzar() {
            Console.WriteLine("teacher created");
            _teacher = new Teacher();
        }
        public void NuevoAlumno(IAlumno alumno) {
            Student student = new AdaptadorAlumno(alumno);
            _teacher.goToClass(student);
        }

        public void ClaseLista() {
            _teacher.teachingAClass();
        }

    }
}
