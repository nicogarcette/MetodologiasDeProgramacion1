using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Metodologias de programacion 1 : Practica 1\n");

            Console.WriteLine("Ejercicio 7\n");
            Ejercicio7();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 9\n");
            Ejercicio9();
            Console.ReadKey();
            Console.Clear();

            // 10--Con los primeros 6 ejercicios y al agregar la coleccionMultiple no se debio modificar nada,
            //ya que coleccionMultiple es Coleccionable

            Console.WriteLine("Ejercicio 13\n");
            Ejercicio13();
            Console.ReadKey();
            Console.Clear();

            // 14 - En un principio se debio modificar el Informar, ya que al hacer la consulta se debia
            // consultar por una Persona no por Numero. Por eso mismo se creo el metodo InformarPersona.

            //17- No fue necesario implementar la Interface Comparable en Alumno,
            // Alumno es una Persona(herencia), por lo cual tambien es comparable.
            // El criterio por el que se comparo Alumno fue por Dni, como esta en la superClase

            //18-
            Console.WriteLine("Ejercicio 18\n");
            Ejercicio18();

            // 19- Si se podria hacer todo lo trabajo sin interfaces.Pero se perderia la abstraccion
            //que nos brindan la interfaces teniendo que codear todas las comparaciones 
            // y realizar cada funcionalidad que se quiera aplicar para cada clase.
            Console.ReadKey();
        }
        public static void Llenar(ref Coleccionable coleccion) {

            Random random = new Random();

            for (int i = 0; i < 20; i++) {
                Comparable value = new Numero(random.Next(1, 100));

                coleccion.Agregar(value);
            }
        }
        public static void LlenarPersonas(ref Coleccionable coleccion) {

            string[] nombres = { "pepe", "juan", "nico", "mario", "alan", "lu", "mar", "pedro", "pablo", "sofi", "tomas", "anto", "maria", "kari", "kevin", "gabi", "jose", "ana", "pau", "antonioo" };

            Random random = new Random();

            for (int i = 0; i < 20; i++) {
                Comparable value = new Persona(nombres[i], random.Next(100, 150));

                coleccion.Agregar(value);
            }
        }

        public static void LlenarAlumnos(ref Coleccionable coleccion) {

            string[] nombres = { "pepe", "juan", "nico", "mario", "alan", "clau", "mar", "pedro", "pablo", "sofi", "tomas", "anto", "maria", "kari", "kevin", "gabi", "jose", "ana", "pau", "facu" };

            Random random = new Random();

            for (int i = 0; i < 20; i++) {
                Comparable value = new Alumno(nombres[i], random.Next(100, 200), i, random.Next(1, 30));

                coleccion.Agregar(value);
            }
        }

        public static void Informar(Coleccionable coleccionable) {

            Console.WriteLine($"Cantidad: {coleccionable.Cuantos()}");
            Console.WriteLine($"Maximo: {coleccionable.Maximo()}");
            Console.WriteLine($"Minimo: {coleccionable.Minimo()}");

            int value = AskNumber();


            if (coleccionable.Contiene(new Numero(value))) {
                Console.WriteLine("El elemento pertenece a la coleccion!");
            } else { 
            
                Console.WriteLine("El elemento no pertenece a la coleccion!");
            }
        }

        public static void InformarPersona(Coleccionable coleccionable) {

            Console.WriteLine($"Cantidad: {coleccionable.Cuantos()}");
            Console.WriteLine($"Maximo: {coleccionable.Maximo()}");
            Console.WriteLine($"Minimo: {coleccionable.Minimo()}");

            int value = AskNumber();


            if (coleccionable.Contiene(new Persona("", value))) {
                Console.WriteLine("El elemento pertenece a la coleccion!");
            } else {

                Console.WriteLine("El elemento no pertenece a la coleccion!");
            }
        }

        public static void InformarAlumno(Coleccionable coleccionable) {

            Console.WriteLine($"Cantidad: {coleccionable.Cuantos()}");
            Console.WriteLine($"Maximo: {coleccionable.Maximo()}");
            Console.WriteLine($"Minimo: {coleccionable.Minimo()}");

            int value = AskNumber();

            if (coleccionable.Contiene(new Alumno("", 10, value, 10))) {
                Console.WriteLine("El elemento pertenece a la coleccion!");
            } else {

                Console.WriteLine("El elemento no pertenece a la coleccion!");
            }
        }

        public static int AskNumber() {
            int value;
            bool esNum;
            Console.Write("Verificar si pertenece a la coleccion\n");

            do {
                Console.Write("Ingrese valor: ");
                esNum = int.TryParse(Console.ReadLine(), out value);
            }
            while (!esNum);

            return value;
        }

        public static void Ejercicio7() {

            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();

            Llenar(ref cola);
            Llenar(ref pila);
            Console.WriteLine("Informar Cola\n");
            Informar(cola);
            Console.WriteLine("\nInformar Pila\n");
            Informar(pila);
        }
        public static void Ejercicio9() {

            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();
            Coleccionable multiple = new ColeccionMultiple(pila, cola);


            Llenar(ref cola);
            Llenar(ref pila);
            Console.WriteLine("Informar Cola\n");
            Informar(cola);
            Console.WriteLine("\nInformar Pila\n");
            Informar(pila);
            Console.WriteLine("\nInformar multiple\n");
            Informar(multiple);
        }

        public static void Ejercicio13() {

            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();
            Coleccionable multiple = new ColeccionMultiple(pila, cola);

            LlenarPersonas(ref cola);
            LlenarPersonas(ref pila);

            Console.WriteLine("\nInformar multiple\n");
            InformarPersona(multiple);
        }

        public static void Ejercicio18() {

            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();
            Coleccionable multiple = new ColeccionMultiple(pila, cola);

            LlenarAlumnos(ref cola);
            LlenarAlumnos(ref pila);

            Console.WriteLine("\nInformar multiple\n");
            InformarAlumno(multiple);
        }
    }
}
