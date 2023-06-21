using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public abstract class Observado : IObservado {
        private List<IObservador> _observadores = new List<IObservador>();// conjunto probar
        public void Agregar(IObservador o) {
            _observadores.Add(o);
        }

        public void Eliminar(IObservador o) {
            _observadores.Remove(o);
        }

        public void Notificar() {
            foreach (var observer in _observadores) {
                observer.Actualizar(this);// se manda por parametro el obsevado.
            }
        }

        // se implemento observado en persona, ya que vendedor hereda no puede heredar de ambos.
    }
}
