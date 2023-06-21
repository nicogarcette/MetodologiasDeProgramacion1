using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Diccionario : Coleccionable, Iterable , Ordenable {

        private Conjunto _conjunto;
        private Random random = new Random();

        public Diccionario() {
            this._conjunto = new Conjunto();
        }

        public Comparable ClaveUnica() {

            // tuve que poner el ramdon como atributo si no al instanciar nuevamente generaba el mismo numero
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

            // si hay clave repetida, va actualizar no voy a validar eso.
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
            // hacerlo por el valor.
            return _conjunto.Maximo();
        }

        public Comparable Minimo() {
            // hacerlo por el valor.
            return _conjunto.Minimo();
        }

        public Iterador GetIterador() {

            return _conjunto.GetIterador();
        }

        public void SetOrdenInicio(OrdenEnAula1 orden) {
            _conjunto.SetOrdenInicio(orden);
        }

        public void SetOrdenLlegaAlumno(OrdenEnAula2 orden) {
            _conjunto.SetOrdenLlegaAlumno(orden);
        }

        public void SetOrdenAulaLlena(OrdenEnAula1 orden) {
            _conjunto.SetOrdenAulaLlena(orden);
        }
    }
}
