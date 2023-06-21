using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Diccionario : Coleccionable,Iterable {

        private Conjunto _conjunto;
        private Random random = new Random();

        public Diccionario() {
            this._conjunto = new Conjunto();
        }

        // se forzo a que las claves se repitan, para demostrar funcionamiento.
        public Comparable ClaveUnica() {

            // se debio poner el ramdon como atributo si no al instanciar nuevamente generaba el mismo numero.
            int num = random.Next(1, 20);
            Comparable value = new Numero(num);

            return value;
        }

        public Comparable ValorDe(Comparable c) {

            ClaveValor value = (ClaveValor)_conjunto.Buscar(c);

            if (value == null) {
                return null;
            } else { 
                return value.Valor;
            }

        }

        //Interface methods
        public void Agregar(Comparable c) {

            // si hay clave repetida la actuliza.
            ClaveValor claveValor = new ClaveValor(this.ClaveUnica(), c);

            if (!_conjunto.Pertenece(claveValor)) {

                _conjunto.Agregar(claveValor);

            } else {
                _conjunto.Delete(_conjunto.Buscar(claveValor));
                _conjunto.Agregar(claveValor);
            }
        }

        public bool Contiene(Comparable c) {
            return _conjunto.Contiene(c);
        }

        public int Cuantos() {
            return _conjunto.Cuantos();
        }

        public Comparable Maximo() {
            return _conjunto.Maximo();
        }

        public Comparable Minimo() {
            return _conjunto.Minimo();
        }

        public Iterador GetIterador() {
            return _conjunto.GetIterador();
        }
    }
}
