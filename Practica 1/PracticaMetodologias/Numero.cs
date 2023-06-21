using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Numero : Comparable {

        private int valor;

        public Numero(int num) {
            this.valor = num;
        }

        public int GetValor() { return valor; }

        public bool SosIgual(Comparable c) {
            Numero x = (Numero)c;
            return this.valor == x.GetValor();
        }

        public bool SosMayor(Comparable c) {
            Numero x = (Numero)c;
            return this.valor > x.GetValor();
        }

        public bool SosMenor(Comparable c) {
            Numero x = (Numero)c;
            return this.valor < x.GetValor();
        }

        public override string ToString() {
            return $"{valor}";
        }
    }
}
