using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Persona : Comparable {

        protected string _nombre;
        protected int _dni;

        public Persona(string n, int d) {

            _nombre = n;
            _dni = d;
        }
        public string GetNombre() {
            return _nombre;
        }
        public int GetDni() {
            return _dni;
        }

        public virtual bool SosIgual(Comparable c) {
            Persona p = (Persona)c;
            return _nombre == p.GetNombre();
        }

        public virtual bool SosMayor(Comparable c) {
            Persona p = (Persona)c;
            return _dni > p.GetDni();

        }

        public virtual bool SosMenor(Comparable c) {
            Persona p = (Persona)c;
            return _dni < p.GetDni();
        }

        public override string ToString() {
            return $"Nombre: {_nombre} dni: {_dni}";
        }
    }
}
