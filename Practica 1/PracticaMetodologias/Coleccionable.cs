using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public interface Coleccionable {
        int Cuantos();
        Comparable Minimo();
        Comparable Maximo();
        void Agregar(Comparable c);
        bool Contiene(Comparable c);
    }
}
