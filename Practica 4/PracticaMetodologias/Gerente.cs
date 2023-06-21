using PracticaMetodologias.iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Gerente : IObservador {

        // conjunto para no agregar repetido
        private Conjunto mejoresVendedores = new Conjunto();

        public void Actualizar(IObservado observado) {

            Vendedor vendedor = (Vendedor)observado;

            //cree una nuevo atributo para consevar la venta, y mandarla por parametro. 
            //pero al Notificar y mandar el observado ya la tendria
            // deberia sacar el parametro monto de la funcion
            this.Venta(vendedor.UltimaVenta, vendedor);
        }

        public void Cerrar() {

            Iterador ite = mejoresVendedores.GetIterador();

            while (!ite.fin()) {

                Console.WriteLine(ite.actual());
                ite.siguiente();
            }
        }

        public void Venta(int monto,Vendedor vendedor) {

            if (monto > 5000) {
                vendedor.AumetarBonus();
                mejoresVendedores.Agregar(vendedor);
            }
        }
    }
}
