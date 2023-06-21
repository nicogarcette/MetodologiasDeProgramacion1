using System;
using System.Collections.Generic;

namespace PracticaMetodologias {
    public interface IAlumno : Comparable {
        string MostrarResultado();
        int GetCalicacion();
        int GetLegajo();
        string GetNombre();
        void SetCalificacion(int c);
        int ResponderPregunta(int pregunta);
        IAlumno GetAlumno();
    }
}
