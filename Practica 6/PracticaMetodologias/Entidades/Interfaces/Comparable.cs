using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public interface Comparable {
        bool SosMayor(Comparable c);
        bool SosMenor(Comparable c);
        bool SosIgual(Comparable c);
    }
}
