using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Cola : Coleccionable, Iterable, Ordenable {

        private List<Comparable> _cola;
        OrdenEnAula1 _ordenInicio = null;
        OrdenEnAula1 _ordenAulaLLena = null;
        OrdenEnAula2 _ordenLLegadaAlumno = null;

        public Cola() {

            _cola = new List<Comparable>();

        }

        public void Agregar(Comparable c) {

            if (_cola.Count() == 0)
                if (_ordenInicio != null)
                    _ordenInicio.Ejecutar();

            if (_ordenLLegadaAlumno != null) 
                _ordenLLegadaAlumno.Ejecutar(c);


            if (_cola.Count() == 40 )
                if (_ordenAulaLLena != null) 
                    _ordenAulaLLena.Ejecutar();

            _cola.Add(c);
        }

        public int Cuantos() {
            return _cola.Count;
        }

        public bool Contiene(Comparable c) {

            foreach (var item in _cola) {

                if (item.SosIgual(c))
                    return true;

            }
            return false;
        }

        public Comparable Maximo() {

            Comparable c = _cola[0];

            for (int i = 1; i < _cola.Count; i++) {

                if (!c.SosMayor(_cola[i]))
                    c = _cola[i];
            }
            return c;
        }

        public Comparable Minimo() {

            Comparable c = _cola[0];

            for (int i = 1; i < _cola.Count; i++) {

                if (!c.SosMenor(_cola[i]))
                    c = _cola[i];
            }
            return c;
        }

        public Iterador GetIterador() {
            return new Lista(this._cola);
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
