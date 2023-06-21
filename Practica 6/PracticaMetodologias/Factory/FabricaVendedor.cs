﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class FabricaVendedor : FabricaComparables {
        public override Comparable CrearAleatorio() {
            GeneradorDeDatosAleatorios dato = GeneradorDeDatosAleatorios.GetInstance();
            return new Vendedor(dato.StringAleatorio(4), dato.NumeroAleatorio(50), dato.NumeroAleatorio(200));
        }

        public override Comparable CrearPorTeclado() {
            LectorDeDatos dato = LectorDeDatos.GetInstance();
            return new Vendedor(dato.StringPorTeclado(), dato.NumeroPorTeclado(), dato.NumeroPorTeclado());
        }
    }
}
