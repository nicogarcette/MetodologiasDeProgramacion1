using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    internal class OrdenLlegaAlumno : OrdenEnAula2 {

        private Aula _aula;

        public OrdenLlegaAlumno(Aula aula) {

            _aula = aula;
        }
        
        public void Ejecutar(Comparable c) {
            _aula.NuevoAlumno((IAlumno)c);
        }
    }
}
