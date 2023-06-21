using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class FabricaAlumno : FabricaComparables {
        public override Comparable CrearAleatorio() {
            GeneradorDeDatosAleatorios dato = GeneradorDeDatosAleatorios.GetInstance();
            return new Alumno(dato.StringAleatorio(4),dato.NumeroAleatorio(50),dato.NumeroAleatorio(30),dato.NumeroAleatorio(10));
        }

        public override Comparable CrearPorTeclado() {
            LectorDeDatos dato = LectorDeDatos.GetInstance();
            return new Alumno(dato.StringPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado());
        }
    }
}
