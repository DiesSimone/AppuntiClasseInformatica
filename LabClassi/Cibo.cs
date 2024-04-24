using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    namespace FaunaGreppi
    {
        public class Cibo
        {
            private string nome;
            private double peso;//in Kg
            private double kcalPerKg;
            public const double KCAL_PER_KG_DEFAULT = 1000.0;

            public string Nome { get => nome; set => nome = value; }
            public double Peso
            {
                get
                {
                    return peso;
                }

                set
                {
                    if (value >= 0)
                    {
                        peso = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(nameof(Peso), nameof(Peso) + " cannot be negative");
                    }
                }
            }
            public double KcalPerKg { get => kcalPerKg; set => kcalPerKg = value; }

            public Cibo(string nome, double peso, double kcalPerKg)
            {
                this.nome = nome;
                this.peso = peso;
                this.kcalPerKg = kcalPerKg;
            }
            public Cibo(double peso) : this("cibo generico", peso, KCAL_PER_KG_DEFAULT) { }
        }
    }
    
}

