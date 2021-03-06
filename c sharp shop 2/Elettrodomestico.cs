
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        private string tipoElettrodomestico;
        private string classeEnergetica;

        public Elettrodomestico(string nome, string descrizione, string tipoElettrodomestico,
            string classeEnergetica) : base(nome, descrizione)
        {
            this.tipoElettrodomestico = tipoElettrodomestico;
            this.classeEnergetica = classeEnergetica;
        }

        public Elettrodomestico(string nome, string descrizione,
            double prezzo, double iva, string tipoElettrodomestico,
            string classeEnergetica) : base(nome, descrizione, prezzo, iva)
        {
            this.tipoElettrodomestico = tipoElettrodomestico;
            this.classeEnergetica = classeEnergetica;
        }
    }
}