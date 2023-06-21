using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class OrdenInicio : OrdenEnAula1 {


        private Aula _aula;
        public OrdenInicio(Aula aula) {

            _aula = aula;
        }
        public void Ejecutar() {
            _aula.Comenzar();
        }
    }
}
