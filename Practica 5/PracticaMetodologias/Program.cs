using PracticaMetodologias.iterator;
using System;
using System.Xml.Linq;

namespace PracticaMetodologias {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Metodologias de programacion 1 : Practica 5\n");

            // Se realizo el ejercicio 2 el cual reutiliza el ejercicio de la practica 4. Aplicando proxy
            Ejercicio2();

            Console.ReadKey();
            Console.Clear();

            // ejercicio 10- patron command
            Ejercicio10();

            Console.ReadKey();
        }

        //Unica funcion llenar y unica funcion informar
        public static void Llenar(Coleccionable coleccion, int opcion, int cantidad = 20) {

            Comparable comparable;

            for (int i = 0; i < cantidad; i++) {

                comparable = FabricaComparables.CrearAleatorio(opcion);

                coleccion.Agregar(comparable);
            }
        }

        public static void Ejercicio4() {

            Teacher teacher = new Teacher();
            Coleccionable pila = new Pila();
            int cantidad = 10;
            int alumno = 2;
            int alumnoEstudioso = 4;

            Llenar(pila, alumno, cantidad);
            Llenar(pila, alumnoEstudioso, cantidad);

            Iterador ite = ((Iterable)pila).GetIterador();

            while (!ite.fin()) {

                IAlumno alum = (IAlumno)ite.actual();
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

        // Ejercicio 2 - 
        public static void Ejercicio2() {

            Teacher teacher = new Teacher();
            int alumno = 2;
            int alumnoEstudioso = 4;

            // se crean proxys
            for (int i = 0; i < 20; i++) {

                if (i < 10) {
                    Student student = CrearProxyAdaptado(alumno);
                    teacher.goToClass(student);

                } else {
                    Student student = CrearProxyAdaptado(alumnoEstudioso);
                    teacher.goToClass(student);
                }

            }
            teacher.teachingAClass();
        }

        public static Student CrearProxyAdaptado(int tipoAlumno) {

            GeneradorDeDatosAleatorios g = GeneradorDeDatosAleatorios.GetInstance();
            string name = g.StringAleatorio(4);
            int num = g.NumeroAleatorio(4);

            IAlumno alum = new AlumnoProxy(name, num, num, num, num, tipoAlumno);
            alum.SetCalificacion(10);
            IAlumno decorado1 = new DecoradorLegajo(alum);
            IAlumno decorado2 = new DecoradorNotaEnLetras(decorado1);
            IAlumno decorado3 = new DecoradorPromocion(decorado2);
            IAlumno decorado4 = new DecoradorAsterisco(decorado3);

            Student student = new AdaptadorAlumno(decorado4);

            return student;
        }


        // Ejercicio 10
        public static void Ejercicio10() {

            Aula aula34 = new Aula();

            Pila pila = new Pila();

            pila.SetOrdenInicio(new OrdenInicio(aula34));
            pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula34));
            pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula34));

            Llenar(pila, 2);
            Llenar(pila, 4);
        }
    }
}
