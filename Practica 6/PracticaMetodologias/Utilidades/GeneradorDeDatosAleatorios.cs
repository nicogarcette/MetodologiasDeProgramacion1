using System;
using System.Collections.Generic;
using System.Threading;

namespace PracticaMetodologias {
    public class GeneradorDeDatosAleatorios {

        private static GeneradorDeDatosAleatorios _generadorUnico = null;
        private static Random random = new Random(DateTime.Now.Millisecond);

        private GeneradorDeDatosAleatorios() { }

        public static GeneradorDeDatosAleatorios GetInstance() {

            if (_generadorUnico == null) {
                _generadorUnico = new GeneradorDeDatosAleatorios();
            }
            return _generadorUnico;
        }

        public int NumeroAleatorio(int numMax) {
            int numeroRandom = random.Next(0, numMax);
            return numeroRandom;
        }

        public string StringAleatorio(int length) {

            string stringAleatorio = string.Empty;

            for (int i = 0; i < length; i++) {
                int numeroRandom = random.Next(97, 122);

                stringAleatorio += Convert.ToChar(numeroRandom);
            }

            return stringAleatorio;
        }
    }
}
