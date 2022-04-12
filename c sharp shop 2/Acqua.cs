using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_shop_2
{


    internal class Acqua : Prodotto
    {
        private double litri;
        private double ph;
        private string sorgente;
        public const double massimoLitri = 1.5;



        public Acqua(double litri, double ph, string sorgente, string nome, string descrizione) : base(nome, descrizione)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }

        public double getLitri()
        {
            return litri;
        }

        public double getPh()
        {
            return ph;
        }
        public string getSorgente()
        {
            return sorgente;
        }

        //metodo bevi

        public void Bevi(double litriDaBere)
        {
            this.litri -= litriDaBere; // this.litri=this.litri- litrdabere

        }

        public void Riempi(double litri)
        {
            this.litri += litri;  //this.litri = this.litri + litri
        }

        public void Svuota()
        {
            this.litri = 0;
        }





    }
}
