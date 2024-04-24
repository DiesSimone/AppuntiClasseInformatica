using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    public class Triangolo
    {
        private double lato1;
        private double lato2;
        private double lato3;
        public Triangolo(double lato1, double lato2, double lato3)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
            this.lato3 = lato3;
        }

        public double Lato1 { get => lato1; set => lato1 = value; }
        public double Lato2 { get => lato2; set => lato2 = value; }
        public double Lato3 { get => lato3; set => lato3 = value; }

        public double Perimetro()
        {
            return lato1+lato2+lato3;
        }
    }
}
