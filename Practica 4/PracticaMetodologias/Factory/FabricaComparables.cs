using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public abstract class FabricaComparables : FabricaDeComparables {
        public abstract Comparable CrearAleatorio();

        public abstract Comparable CrearPorTeclado();// 1 solution delete interface

        public static Comparable CrearAleatorio(int opc) {

            FabricaDeComparables fabrica;
  
            switch (opc) {

                case 1:
                    fabrica = new FabricaNumero();// al crear nuevas fabricas se me crean nuevos generadores, por eso tira el mismo random
                    return fabrica.CrearAleatorio();
 
                case 2:
                    fabrica = new FabricaAlumno();
                    return fabrica.CrearAleatorio();
                case 3:
                    fabrica = new FabricaVendedor();
                    return fabrica.CrearAleatorio();
                case 4:
                    fabrica = new FabricaAlumnoMuyEstudioso();
                    return fabrica.CrearAleatorio();

                default:
                    break;
            }

            return null;
        }

        public static Comparable CrearPorTeclado(int opc) {
            FabricaDeComparables fabrica;

            switch (opc) {

                case 1:
                    fabrica = new FabricaNumero();
                    return fabrica.CrearPorTeclado();
                case 2:
                    fabrica = new FabricaAlumno();
                    return fabrica.CrearPorTeclado();

                case 3:
                    fabrica = new FabricaVendedor();
                    return fabrica.CrearPorTeclado();
                case 4:
                    fabrica = new FabricaAlumnoMuyEstudioso();
                    return fabrica.CrearPorTeclado();
                default:
                    break;
            }

            return null;
        }



    }
}
