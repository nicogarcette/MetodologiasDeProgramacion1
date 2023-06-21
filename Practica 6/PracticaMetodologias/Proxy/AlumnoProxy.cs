using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class AlumnoProxy : IAlumno {

        private IAlumno _alumno = null;
        private string _nombre;
        private int _dni;
        private int _legajo;
        private int _promedio;
        private int _calificacion;
        private int _opc;
        public AlumnoProxy(string name, int dni, int legajo,int promedio, int calificacion, int opc) {

            _nombre = name;
            _dni = dni;
            _legajo = legajo;
            _promedio = promedio;
            _calificacion = calificacion;
            _opc = opc;
        }

        public int GetCalicacion() {
            return _calificacion;
        }

        public int GetDni() {
            return _dni;
        }

        public int GetLegajo() {
            return _legajo;
        }

        public string GetNombre() {
            return _nombre;
        }

        public int GetPromedio() {
            return _promedio;
        }

        public string MostrarResultado() {

            if (_alumno == null)
                _alumno = this.CreateAlumnoReal();

            return _alumno.MostrarResultado();
        }

        public int ResponderPregunta(int pregunta) {

            if (_alumno == null) 
               _alumno = this.CreateAlumnoReal();
            

            return _alumno.ResponderPregunta(pregunta);
        }

        public void SetCalificacion(int c) {
            _calificacion = c;
        }

        public bool SosIgual(Comparable c) {
            if (_alumno == null)
                _alumno = this.CreateAlumnoReal();

            return _alumno.SosIgual(c);
        }

        public bool SosMayor(Comparable c) {
            if (_alumno == null)
                _alumno = this.CreateAlumnoReal();

            return _alumno.SosMayor(c);
        }

        public bool SosMenor(Comparable c) {

            if (_alumno == null)
                _alumno = this.CreateAlumnoReal();

            return _alumno.SosMenor(c);
        }
        public IAlumno GetAlumno() {

            if (_alumno == null)
                _alumno = this.CreateAlumnoReal();

            return _alumno;
        }


        private IAlumno CreateAlumnoReal() {

            IAlumno alum = null;

            if (_opc == 2) {
                Console.Write("\nInstanciando a un Alumno: ");
                alum = (IAlumno)FabricaComparables.CrearAleatorio(_opc);
            }

            if (_opc == 4) {
                Console.Write("\nInstanciando a un Alumno muy estudioso: ");
                alum = (IAlumno)FabricaComparables.CrearAleatorio(_opc);
            }

            return alum;
        }
    }
}
