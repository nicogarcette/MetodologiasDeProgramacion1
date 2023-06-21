using PracticaMetodologias.iterator;
using System;

namespace PracticaMetodologias {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Metodologias de programacion 1 : Practica 2\n");

            //ejercicio 2: implemente en el main
            Console.WriteLine("-----Ejercicio 2------\n");
            Ejercicio2();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----Ejercicio 8------\n");
            Ejercicio8();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----Ejercicio 9------\n");
            Ejercicio10();
            Console.ReadKey();
            Console.Clear();


            // 11 - Si se agrega, la subclase AlumnoEgresado, primeramente habria que crear nuevos metodos
            // InformarAlumnoEgresado y LlenarAlumnoEgresado, ya que por el momento no hay solucion para
            // que el metodo Informar y LLenar sean genericos. Por otro lado, se podria agregar una nueva
            // estrategia por FechaDeEgreso.

            // 12 - Dado el ejemplo de un Alumno con promedio 7, si se quiere imprimir los alumnos
            // dentro del conjunto con mejor promedio a mi alumno, una solucion seria modificar ImprimirElementos
            // y colocar un condicional el cual solo imprima los alumnos mayores al promedio de nuestro alumno.
            // Pero sin modificar el Imprimir en absoluto, lo que se podria realizar es un Iterador con alguna
            // logica de comparacion.

            Console.ReadKey();
        }
       
        //ejercicio 2: se le agrego al metodo una estrategia por legajo
        public static void LlenarAlumnos(ref Coleccionable coleccion) {

            string[] nombres = { "pepe", "juan", "nico", "mario", "alan", "lu", "mar", "pedro", "pablo", "sofi", "tomas", "anto", "maria", "kari", "kevin", "gabi", "jose", "antoniooo", "pau", "facu" };

            Random random = new Random();

            for (int i = 0; i < 20; i++) {

                Alumno alum = new Alumno(nombres[i], random.Next(100, 200), i, random.Next(1, 10));
                alum.SetStrategy(new Legajo());
                coleccion.Agregar(alum);
            }
        }
   
        public static void InformarAlumno(Coleccionable coleccionable) {

            Console.WriteLine($"Cantidad: {coleccionable.Cuantos()}");
            Console.WriteLine($"Maximo: {coleccionable.Maximo()}");
            Console.WriteLine($"Minimo: {coleccionable.Minimo()}");

            int value = AskNumber();
            // no pregunta correctamente, ya que dependera de la estrategia que tenga.
            Console.WriteLine($"Contiene {value} ?: {coleccionable.Contiene(new Alumno("", 10, value, 10))}");
        }

        public static int AskNumber() {
            int value;
            bool esNum;
            do {
                Console.Write("Verificar si esta almacenado. Ingrese dato: ");
                esNum = int.TryParse(Console.ReadLine(), out value);
            }
            while (!esNum);

            return value;
        }
        // ejercicio 7 -
        public static void ImprimirElementos(Coleccionable coleccionable) {

            Iterador ite = ((Iterable)coleccionable).GetIterador();

            while (!ite.fin()) {

                Console.WriteLine(ite.actual());
                ite.siguiente();
            }
        }

        public static void CambiarEstrategia(Coleccionable coleccionable,EstrategiaComparacion e) {

            Iterador iterador = ((Iterable)coleccionable).GetIterador();
            while (!iterador.fin()) {

                ((Alumno)iterador.actual()).SetStrategy(e);

                iterador.siguiente();
            }
        }

        public static void Ejercicio2() {

            Coleccionable pila = new Pila();
            Coleccionable cola = new Cola();
            Coleccionable multiple = new ColeccionMultiple(pila, cola);

            LlenarAlumnos(ref pila);
            LlenarAlumnos(ref cola);
            InformarAlumno(multiple);
        }

        public static void Ejercicio8() {
            
            Coleccionable pila = new Pila();
            Coleccionable cola = new Cola();
            Coleccionable con = new Conjunto();
            Coleccionable dic = new Diccionario();

            LlenarAlumnos(ref pila);
            LlenarAlumnos(ref cola);
            LlenarAlumnos(ref con);
            LlenarAlumnos(ref dic);

            Console.WriteLine("\n------Elementos pila------\n");
            ImprimirElementos(pila);
            Console.WriteLine("\n------Elementos cola------\n");
            ImprimirElementos(cola);
            Console.WriteLine("\n------Elementos conjunto------\n");
            ImprimirElementos(con);
            Console.WriteLine("\n------Elementos Diccionario------\n");
            ImprimirElementos(dic);
        }

        public static void Ejercicio10() {

            Coleccionable pila = new Pila();
            LlenarAlumnos(ref pila);

            Console.WriteLine("\nEstrategia por promedio");
            CambiarEstrategia(pila, new Promedio());
            InformarAlumno(pila);

            Console.WriteLine("\nEstrategia por nombre");
            CambiarEstrategia(pila, new Nombre());
            InformarAlumno(pila);

            Console.WriteLine("\nEstrategia por legajo");
            CambiarEstrategia(pila, new Legajo());
            InformarAlumno(pila);

            Console.WriteLine("\nEstrategia por dni");
            CambiarEstrategia(pila, new Dni());
            InformarAlumno(pila);
        }
    }
}
