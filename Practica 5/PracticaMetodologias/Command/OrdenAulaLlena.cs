using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class OrdenAulaLlena : OrdenEnAula1 {

        private Aula _aula;

        public OrdenAulaLlena(Aula aula) {

            _aula = aula;
        }

        public void Ejecutar() {
            _aula.ClaseLista();
        }
    }
}
