using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    internal class ColeccionMultiple : Coleccionable {
        private Coleccionable _pila;
        private Coleccionable _cola;

        public ColeccionMultiple(Coleccionable p, Coleccionable c) {

            _pila = p;
            _cola = c;
        }

        public void Agregar(Comparable c) {
            throw new NotImplementedException();
        }

        public bool Contiene(Comparable c) {

            return _pila.Contiene(c) && _cola.Contiene(c);
        }

        public int Cuantos() {
            return _pila.Cuantos() + _cola.Cuantos();
        }

        public Comparable Maximo() {

            if (_cola.Maximo().SosMenor(_pila.Maximo()))
                return _pila.Maximo();

            return _cola.Maximo();
        }

        public Comparable Minimo() {

            if (_cola.Minimo().SosMayor(_pila.Minimo()))
                return _pila.Minimo();

            return _cola.Minimo();
        }

    }
}
