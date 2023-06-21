using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Cola : Coleccionable {

        private List<Comparable> _cola;

        public Cola() {

            _cola = new List<Comparable>();

        }

        public void Agregar(Comparable c) {

            _cola.Add(c);
        }
        public int Cuantos() {
            return _cola.Count;
        }

        public bool Contiene(Comparable c) {

            foreach (var item in _cola) {

                if (item.SosIgual(c))
                    return true;

            }
            return false;
        }

        public Comparable Maximo() {

            Comparable c = _cola[0];

            for (int i = 1; i < _cola.Count; i++) {

                if (!c.SosMayor(_cola[i]))
                    c = _cola[i];
            }
            return c;
        }

        public Comparable Minimo() {

            Comparable c = _cola[0];

            for (int i = 1; i < _cola.Count; i++) {

                if (!c.SosMenor(_cola[i]))
                    c = _cola[i];
            }
            return c;
        }

    }
}
