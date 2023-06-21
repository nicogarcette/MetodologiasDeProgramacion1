using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias.iterator {
    internal class Lista : Iterador {

        private List<Comparable> iterados;
        private int indice = 0;

        public Lista(List<Comparable> list) {

            this.iterados = list;
        }

        public Comparable actual() {
            return this.iterados[indice];
        }

        public bool fin() {
            return this.indice == this.iterados.Count;
        }

        public void primero() {
            this.indice = 0;
        }

        public void siguiente() {
            this.indice++;
        }
    }
}
