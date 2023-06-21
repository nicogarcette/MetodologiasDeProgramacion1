using System;
using System.Collections.Generic;


namespace PracticaMetodologias {
    public class FabricaAlumno : FabricaComparables {
        public override Comparable CrearAleatorio() {
            GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
            return new Alumno(dato.StringAleatorio(4),dato.NumeroAleatorio(50),dato.NumeroAleatorio(30),dato.NumeroAleatorio(10));
        }

        public override Comparable CrearPorTeclado() {
            LectorDeDatos dato = new LectorDeDatos();
            return new Alumno(dato.StringPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado());
        }
    }
}
