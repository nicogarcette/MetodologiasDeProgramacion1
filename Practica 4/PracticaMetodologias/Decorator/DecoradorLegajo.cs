using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public class DecoradorLegajo : DecoradorAlumno {
        public DecoradorLegajo(IAlumno alumno) : base(alumno) {
        }

        public override string MostrarResultado() {

            string cadena = base.MostrarResultado();

            int indiceEspacio = cadena.IndexOf(" ");
            if (indiceEspacio != -1) {
                string part1 = cadena.Substring(0, indiceEspacio);
                string part2 = cadena.Substring(indiceEspacio + 1);

                cadena = $"{part1} legajo({this.GetLegajo()}) {part2}";
            }

            return cadena;
        }
    }
}
