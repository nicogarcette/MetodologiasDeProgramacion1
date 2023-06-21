using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias.iterator {
    public interface Iterador {

        void siguiente();
        bool fin();
        void primero();
        Comparable actual();

    }
}
