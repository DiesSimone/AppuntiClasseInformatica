using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompableDemo
{
    //IComparable<Temperatura> definisce l'ordinamento predefinito

    public class Temperatura : IComparable<Temperatura>, IEquatable<Temperatura>
    {
        public Temperatura(double temp, DateTime date, string posizione)
        {
            Temp = temp;
            Date = date;
            Posizione = posizione;
        }

        //auto-properties
        public double Temp { get; set; }
        public DateTime Date { get; set; }
        public string Posizione { get; set; } = null!;

        public int CompareTo(Temperatura? other)
        {
            //return Temp.CompareTo(other?.Temp);
            //definire un criterio di confronto
            //il metodo deve restituire - 1 se this è minore di other
            //0 se this e other nell'ordinamento sono uguali (nello stesso punto)
            //+1 se this è maggiore di other
            return Temp.CompareTo(other?.Temp); //btw non è ricorsivo è un altro compare to sai?
        }

        public bool Equals(Temperatura? other)
        {
            //restituisce true se l'oggetto this è uguale a other
            //false altrimenti
            return Temp == other?.Temp && Date == other?.Date && Posizione == other?.Posizione;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Temp);
        }

        public override string ToString()
        {
            return $"{nameof(Temperatura)}[{nameof(Temp)}: {Temp}, " +
                $"{nameof(Date)}: {Date}, " +
                $"{nameof(Posizione)}: {Posizione}]";
        }

        public static bool operator <(Temperatura left, Temperatura right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Temperatura left, Temperatura right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Temperatura left, Temperatura right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Temperatura left, Temperatura right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool operator ==(Temperatura left, Temperatura right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Temperatura left, Temperatura right)
        {
            return !(left == right);
        }

        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(this, obj))
        //    {
        //        return true;
        //    }

        //    if (ReferenceEquals(obj, null))
        //    {
        //        return false;
        //    }

        //    throw new NotImplementedException();
        //}
    }
}
