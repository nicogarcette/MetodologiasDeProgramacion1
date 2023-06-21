using PracticaMetodologias.iterator;
using System;
using System.Threading;

namespace PracticaMetodologias {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Metodologias de programacion 1 : Practica 3\n");

            //1- En la practica 1 en los metodos se requeria castear dependiendo la clase en la que se debia informar.
            //En mi caso  creo diferentes metodos con el mismo comportamiento solo que correspondia a un solo tipo de dato.
            Console.WriteLine("\nEjercicio 3\n");
            Ejercicio6(3);
            Console.ReadKey();
            Console.Clear();

            // 7- una fabrica de coleccionables

            //9 - En vendedor compare por bonus EsMayor y EsMenor. Esigual compara como Persona,
            // ya que si comparaba por bonus, no iba a poder agregarlo a la lista del gerente, porque siempre serian iguales.

            //10- lo que tiene en comun la clase vendedor y alumno es que ambos son personas
            // se podria ampliar la jerarquia de clases de fabricas, creando una fabrica persona y que
            // delege si crea una alumno  o vendedor.
            Console.WriteLine("\nEjercicio 14\n");
            Ejercicio14();

            Console.ReadKey();
        }
       
        //ejercicio 6: Unica funcion llenar y unica funcion informar
        public static void Llenar(ref Coleccionable coleccion, int opcion) {

            Comparable comparable;

            for (int i = 0; i < 20; i++) {

                comparable = FabricaComparables.CrearAleatorio(opcion);
                coleccion.Agregar(comparable);
            }
        }
   
        public static void Informar(Coleccionable coleccionable, int opcion) {

            Console.WriteLine($"\nCantidad: {coleccionable.Cuantos()}");
            Console.WriteLine($"Maximo: {coleccionable.Maximo()}");
            Console.WriteLine($"Minimo: {coleccionable.Minimo()}");

            Comparable comparable = FabricaComparables.CrearPorTeclado(opcion);

            if (coleccionable.Contiene(comparable)) {
                Console.WriteLine("El elemento pertenece a la coleccion!");
            } else
                Console.WriteLine("El elemento no pertenece a la coleccion!");
        }

        public static void JornadaDeVentas(Coleccionable coleccion) {

            Iterador iterador = ((Iterable)coleccion).GetIterador();
            Random random = new Random();

            while (!iterador.fin()) {

                int monto = random.Next(1,7000);

                ((Vendedor)iterador.actual()).Venta(monto);

                iterador.siguiente();
            }
        }

        public static void AgregarObserver(Coleccionable coleccion, IObservador observer) {

            Iterador iterador = ((Iterable)coleccion).GetIterador();

            while (!iterador.fin()) {
                ((Observado)iterador.actual()).Agregar(observer);

                iterador.siguiente();
            }
        }


        public static void Ejercicio6(int opcion) { 

            Coleccionable pila = new Pila();
            Coleccionable cola = new Cola();
            Coleccionable multiple = new ColeccionMultiple(pila, cola);

            Llenar(ref pila,opcion);
            ImprimirElementos(pila);
            Llenar(ref cola, opcion);
            ImprimirElementos(cola);

            Informar(multiple,opcion);
        }
        public static void Ejercicio14() {

            Coleccionable pila = new Pila();
            Llenar(ref pila,3);
            Informar(pila,3);

            Gerente gerente = new Gerente();
            AgregarObserver(pila,gerente);
            
            JornadaDeVentas(pila);

            gerente.Cerrar();
        }

        // ejercicio 7 - 
        public static void ImprimirElementos(Coleccionable coleccionable) {

            Iterador ite = ((Iterable)coleccionable).GetIterador();
            while (!ite.fin()) {

                Console.WriteLine(ite.actual());
                ite.siguiente();
            }
        }

    }
}
