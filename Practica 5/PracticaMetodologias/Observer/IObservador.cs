using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public interface IObservador {
        void Actualizar(IObservado o);
    }
}
