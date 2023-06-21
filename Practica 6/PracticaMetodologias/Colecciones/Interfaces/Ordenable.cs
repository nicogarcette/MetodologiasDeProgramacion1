using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    internal interface Ordenable {

        void SetOrdenInicio(OrdenEnAula1 orden);
        void SetOrdenLlegaAlumno(OrdenEnAula2 orden);
        void SetOrdenAulaLlena(OrdenEnAula1 orden);
    }
}
