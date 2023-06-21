using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public interface FabricaDeComparables {
        Comparable CrearAleatorio();
        Comparable CrearPorTeclado();
    }
}
