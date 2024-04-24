using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPlayground
{
    public class Segmento : IEquatable<Segmento>
    {
        Punto p1, p2;
        public Segmento(Punto p1, Punto p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        //copy constructor che fa la deep copy
        public Segmento(Segmento s)
        {
            p1 = new Punto(s.p1);
            p2 = new Punto(s.p2);
        }
        internal Punto P1 { get => p1; set => p1 = value; }
        internal Punto P2 { get => p2; set => p2 = value; }
        public override bool Equals(object obj)
        {
            var segmento = obj as Segmento;
            return segmento != null &&
            EqualityComparer<Punto>.Default.Equals(p1, segmento.p1) &&
            EqualityComparer<Punto>.Default.Equals(p2, segmento.p2);
        }
        public bool Equals(Segmento other)
        {
            return other != null &&
            p1.Equals(other.p1) &&
           p2.Equals(other.p2);
        }
        public override int GetHashCode()
        {
            var hashCode = 1369944177;
            hashCode = hashCode * -1521134295 +
           EqualityComparer<Punto>.Default.GetHashCode(p1);
            hashCode = hashCode * -1521134295 +
           EqualityComparer<Punto>.Default.GetHashCode(p2);
            return hashCode;
        }
        public Segmento ShallowCopy()
        {
            return (Segmento)MemberwiseClone();
        }
        public Segmento DeepCopy()
        {
            Segmento altro = (Segmento)MemberwiseClone();
            //altro.P1 = new Punto(P1.X, P1.Y);
            //altro.P2 = new Punto(P2.X, P2.Y);
            altro.P1 = P1.DeepCopy();
            altro.P2 = P2.DeepCopy();
            return altro;
        }
        public override string ToString()
        {
            return $"Segmento[P1 = {P1}, P2 = {P2}]";
        }
    }
}
