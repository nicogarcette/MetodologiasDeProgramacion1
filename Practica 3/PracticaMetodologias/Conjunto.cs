using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Conjunto : Coleccionable, Iterable {

        //mepa que va ser de claveValor
        private List<Comparable> _lista;

        public Conjunto() { 
        
            this._lista = new List<Comparable>();
        }
        public bool Pertenece(Comparable c) {

            foreach (var item in _lista) {

                if (item.SosIgual(c)) {
                    return true;
                }
            }

            return false;
        }

        public void Agregar(Comparable c) {

            if (!Pertenece(c)) {

                this._lista.Add(c);
            }
        }

        public int Cuantos() {
            return _lista.Count;
        }

        public Comparable Minimo() {

            Comparable c = _lista[0];

            for (int i = 1; i < _lista.Count; i++) {

                if (!c.SosMenor(_lista[i]))
                    c = _lista[i];
            }
            return c;
        }

        public Comparable Maximo() {

            Comparable c = _lista[0];

            for (int i = 1; i < _lista.Count; i++) {

                if (!c.SosMayor(_lista[i]))
                    c = _lista[i];
            }
            return c;

        }

        public bool Contiene(Comparable c) {

            foreach (var item in _lista) {

                if (item.SosIgual(c)) 
                    return true;

            }

            return false;
        }

        public Iterador GetIterador() {
            return new Lista(this._lista);
        }


        public Comparable Buscar(Comparable c) {
            //lo dejo porque me ahorro que recorra la lista.Igualmente tengo que dejar el ultimo return
            if (!Pertenece(c)) 
                return null;

            foreach (var item in _lista) {

                if (item.SosIgual(c)) {
                    return item;
                }
            }
            return null;
        }


        public void Delete(Comparable c) {

            if (Pertenece(c)) {
                _lista.Remove(c);
            }
        }
    }
}
