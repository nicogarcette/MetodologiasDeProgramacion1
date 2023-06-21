using PracticaMetodologias.iterator;
using System;

namespace PracticaMetodologias {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Metodologias de programacion 1 : Practica 4\n");

            // Se realizo el ejercicio 4 el cual implementaba el patron adapter y luego se implento
            // el patron decorator para realizar el ejercicio8
            Ejercicio4();

            Console.ReadKey();
        }
       
        //Unica funcion llenar y unica funcion informar
        public static void Llenar(ref Coleccionable coleccion,int opcion, int cantidad = 20) {

            Comparable comparable;

            for (int i = 0; i < cantidad; i++) {

                comparable = FabricaComparables.CrearAleatorio(opcion);
                coleccion.Agregar(comparable);
            }
        }
        // Ejercicio 4 - 
        public static void Ejercicio4() {

            Teacher teacher = new Teacher();
            Coleccionable pila = new Pila();
            int cantidad = 10;
            int alumno = 2;
            int alumnoEstudioso = 4;

            Llenar(ref pila,alumno,cantidad);
            Llenar(ref pila,alumnoEstudioso, cantidad);

            Iterador ite = ((Iterable)pila).GetIterador();

            while (!ite.fin()) {

                Alumno alum = (Alumno)ite.actual();
                alum.SetCalificacion(10);

                IAlumno decorado1 = new DecoradorLegajo(alum);
                IAlumno decorado2 = new DecoradorNotaEnLetras(decorado1);
                IAlumno decorado3 = new DecoradorPromocion(decorado2);
                IAlumno decorado4 = new DecoradorAsterisco(decorado3);

                Student student = new AdaptadorAlumno(decorado4);

                teacher.goToClass(student);

                ite.siguiente();
            }
            teacher.teachingAClass();
        }
    }
}
