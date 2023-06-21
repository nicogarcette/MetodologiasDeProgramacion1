using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public interface EstrategiaComparacion {

         bool SosMenor(IAlumno a,IAlumno a1);
         bool SosMayor(IAlumno a, IAlumno a1);
         bool SosIgual(IAlumno a, IAlumno a1);

    }
}
