using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public interface EstrategiaComparacion {

         bool SosMenor(Alumno a,Alumno a1);
         bool SosMayor(Alumno a, Alumno a1);
         bool SosIgual(Alumno a, Alumno a1);

    }
}
