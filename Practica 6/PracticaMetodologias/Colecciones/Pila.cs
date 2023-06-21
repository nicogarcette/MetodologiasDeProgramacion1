using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaMetodologias {
    public class Pila : Coleccionable, Iterable, Ordenable {

        private List<Comparable> _pila;
        OrdenEnAula1 _ordenInicio = null;
        OrdenEnAula1 _ordenAulaLLena = null;
        OrdenEnAula2 _ordenLLegadaAlumno = null;

        public Pila() {

            _pila = new List<Comparable>();
        }

        public void Agregar(Comparable c) {
            if (_pila.Count() == 0)
                if (_ordenInicio != null)
                    _ordenInicio.Ejecutar();

            if (_ordenLLegadaAlumno != null)
                _ordenLLegadaAlumno.Ejecutar(c);


            if (_pila.Count() == 39)
                if (_ordenAulaLLena != null)
                    _ordenAulaLLena.Ejecutar();

            _pila.Add(c);
        }
        public int Cuantos() {
            return _pila.Count;
        }

        public bool Contiene(Comparable c) {

            foreach (var item in _pila) {

                if (item.SosIgual(c))
                    return true;

            }
            return false;
        }

        public Comparable Maximo() {

            Comparable c = _pila[0];

            for (int i = 1; i < _pila.Count; i++) {

                if (!c.SosMayor(_pila[i]))
                    c = _pila[i];
            }
            return c;
        }

        public Comparable Minimo() {

            Comparable c = _pila[0];

            for (int i = 1; i < _pila.Count; i++) {

                if (!c.SosMenor(_pila[i]))
                    c = _pila[i];
            }
            return c;
        }

        public Iterador GetIterador() {
            return new Lista(this._pila);
        }

        public void SetOrdenInicio(OrdenEnAula1 orden) {
            _ordenInicio = orden;
        }

        public void SetOrdenLlegaAlumno(OrdenEnAula2 orden) {
            _ordenLLegadaAlumno = orden;

        }

        public void SetOrdenAulaLlena(OrdenEnAula1 orden) {
            _ordenAulaLLena = orden;
        }
    }
}
