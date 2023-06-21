using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class FabricaNumero : FabricaComparables {
        public override Comparable CrearAleatorio() {
            GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
            return new Numero(dato.NumeroAleatorio(30));
        }

        public override Comparable CrearPorTeclado() {
            LectorDeDatos dato = new LectorDeDatos();
            return new Numero(dato.NumeroPorTeclado());
        }
    }
}
