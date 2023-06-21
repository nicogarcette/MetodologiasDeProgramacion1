using System;
using System.Collections.Generic;
using System.Threading;

namespace PracticaMetodologias {
    public class GeneradorDeDatosAleatorios {

        private Random random = new Random(DateTime.Now.Millisecond);

        public int NumeroAleatorio(int numMax) {
            Thread.Sleep(1);
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
