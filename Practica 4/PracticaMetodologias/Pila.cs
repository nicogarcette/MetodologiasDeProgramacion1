using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class Pila : Coleccionable,Iterable {
        private List<Comparable> _pila;

        public Pila() {

            _pila = new List<Comparable>();
        }

        public void Agregar(Comparable c) {

            _pila.Add(c);
        }
        public int Cuantos() {
            return _pila.Count;
        }

        public bool Contiene(Comparable c) {

            foreach (var item in _pila) {

                if (item.SosIgual(c))
                    return true;

            }
            return false;
        }

        public Comparable Maximo() {

            Comparable c = _pila[0];

            for (int i = 1; i < _pila.Count; i++) {

                if (!c.SosMayor(_pila[i]))
                    c = _pila[i];
            }
            return c;
        }

        public Comparable Minimo() {

            Comparable c = _pila[0];

            for (int i = 1; i < _pila.Count; i++) {

                if (!c.SosMenor(_pila[i]))
                    c = _pila[i];
            }
            return c;
        }

        public Iterador GetIterador() {
            return new Lista(this._pila);
        }
    }
}
