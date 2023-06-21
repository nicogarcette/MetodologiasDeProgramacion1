using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMetodologias {
    public class Vendedor : Persona {

        private int sueldoBasico;
        private double bonus = 1;
        private int ultimaVenta = 0;// le agrego este parametro para conservar la venta.
        public Vendedor(string n, int d, int sueldoBasico) : base(n, d) {
            this.sueldoBasico = sueldoBasico;
        }

        public int UltimaVenta{
            get{ 
                return ultimaVenta; 
            }
        }
        public double Bonus {
            get {
                return bonus;
            }
        }

        public void Venta(int monto) {

            Console.WriteLine(monto);
            ultimaVenta = monto;
            this.Notificar();
        }

        public void AumetarBonus() {

            this.bonus += 0.1;
        }

        public override bool SosMayor(Comparable c) {
            Vendedor a = (Vendedor)c;
            return this.bonus > a.Bonus;
        }

        public override bool SosMenor(Comparable c) {
            Vendedor a = (Vendedor)c;
            return this.bonus < a.Bonus;
        }

        public override string ToString() {
            return $"[ Nombre: {_nombre} dni: {_dni} sueldoBasico: {sueldoBasico}, bonus:{bonus}]";
        }
    }
}
