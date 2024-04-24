using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi3IA.LibClassi
{
    internal class Animale
    {
        private double peso;
        private string tipologia;

        public Animale()
        {
            //i campi vengono inizializzati ai valori di default
            //this.peso = 0;
            this.tipologia = "mammifero";
        }
        public Animale(double peso, string tipologia)
        {
            this.peso = peso;
            this.tipologia = tipologia;
        }

        public double Peso { get => peso; set => peso = value; }
        public string Tipologia { get => tipologia; set => tipologia = value; }

        public override string ToString()
        {
            return $"{{{nameof(Peso)}: {Peso}, {nameof(Tipologia)}: {Tipologia}";
        }
    }
}
