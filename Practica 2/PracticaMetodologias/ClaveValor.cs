using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    internal class ClaveValor: Comparable {

        private Comparable _clave; 
        private Comparable _valor;

        public Comparable Valor {
            get { return _valor; }
        }
        public Comparable Clave {
            get { return _clave; }
        }

        public ClaveValor(Comparable c, Comparable v) { 
            this._clave = c;
            this._valor = v;
        }

        public bool SosIgual(Comparable c) {

            ClaveValor value = (ClaveValor)c;
            return _clave.SosIgual(value.Clave);
        }

        public bool SosMayor(Comparable c) {

            ClaveValor value = (ClaveValor)c;
            return _valor.SosMayor(value.Valor);
        }

        public bool SosMenor(Comparable c) {

            ClaveValor value = (ClaveValor)c;
            return _valor.SosMayor(value.Valor);
        }

        public override string ToString() {
            return $"Clave: {_clave} Valor: {_valor}";
        }
    }
}
