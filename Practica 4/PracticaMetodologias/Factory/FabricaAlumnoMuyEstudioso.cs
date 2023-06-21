using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class FabricaAlumnoMuyEstudioso : FabricaComparables {
        public override Comparable CrearAleatorio() {

            GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
            return new AlumnoMuyEstudioso(dato.StringAleatorio(4), dato.NumeroAleatorio(50), dato.NumeroAleatorio(30), dato.NumeroAleatorio(10));
        }

        public override Comparable CrearPorTeclado() {
            LectorDeDatos dato = new LectorDeDatos();
            return new AlumnoMuyEstudioso(dato.StringPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado());
        }
    }
}
