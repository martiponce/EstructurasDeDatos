using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPOO
{
    class clsCliente
    {
        //Declaraciòn de tres campos
        private Int32 cod=0;
        private String nom;
        private Decimal deu=0;

        //Declaraciòn de propiedades
        public Int32 Codigo
        {
            get { return cod; }
            set { cod=value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom= value; }
        }

        public Decimal Deuda
        {
            get { return deu; }
            set { deu=value; }
        }

        //Declaraciòn de Mètodos (Accciones)
        //polimorfismo (un metodo puede tomar varias formas segun el parametro q se le pase)
        public void comprar (Decimal importe)
        {
            deu += importe;
        }
        public void comprar(Int32 importe)
        {
            deu += importe;
        }

        public void comprar(Decimal importe, Decimal interes)
        {
            deu += importe;
        }

        public void pagar (Decimal importe)
        {
            deu -= importe;
        }
    }
}
