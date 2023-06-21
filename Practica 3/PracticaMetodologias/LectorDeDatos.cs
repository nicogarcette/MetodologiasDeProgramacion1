using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class LectorDeDatos {

        public int NumeroPorTeclado() {

            int value;
            bool esNum;
            do {
                Console.Write("Ingrese dato: ");
                esNum = int.TryParse(Console.ReadLine(), out value);
            }
            while (!esNum);

            return value;
        }

        public string StringPorTeclado() {

            Console.Write("Ingrese dato: ");
            string value = Console.ReadLine();
          
            return value;
        }
    }
}
