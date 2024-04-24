using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPlayground
{
    public class Punto : IEquatable<Punto>
    {
        private double x, y;
        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //copy constructor che fa la deep copy
        public Punto(Punto p)
        {
            x = p.x;
            y = p.y;
        }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public override bool Equals(object obj)
        {
            var punto = obj as Punto;
            return punto != null &&
            x == punto.x &&
            y == punto.y;
        }
        public bool Equals(Punto other)
        {
            return (other != null) && X.Equals(other.X) && Y.Equals(other.Y);

        }
        public override int GetHashCode()
        {
            var hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return $"P[x = {X}, y = {Y}]";
        }
        public Punto ShallowCopy()
        {
            return (Punto)this.MemberwiseClone();
        }
        /// <summary>
        /// Lo metto solo per far vedere che si può fare, ma non serve quando i campi
        /// sono tutti di tipo primitivo oppure immutabili (come ad esempio le stringhe)
        /// </summary>
        /// <returns></returns>
        public Punto DeepCopy()
        {
        return (Punto)this.MemberwiseClone();
        }
    }

}
