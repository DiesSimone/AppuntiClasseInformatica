using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPlayground
{
    //voglio fare i confronti tra scatole
    //per l'uguaglianza ci sono alcune cose da fare:
    //dichiarare l'interfaccia IEquatable
    //si implementa l'interfaccia IEquatable
    //si implementano anche Equals e GetHashCode ereditati da Object
    public class Box: IComparable<Box>, IEquatable<Box>
    {
        double larghezza;
        double altezza;
        double profondità;

        public Box(double larghezza, double altezza, double profondità)
        {
            this.larghezza = larghezza;
            this.altezza = altezza;
            this.profondità = profondità;
        }
        public Box():this(1,1,1) { }

        //copy constructor - costruttore di copia
        public Box(Box box)
        {
            larghezza=box.larghezza;
            altezza = box.altezza;
            profondità = box.profondità;


        }

        public double Larghezza { get => larghezza; set => larghezza = value; }
        public double Altezza { get => altezza; set => altezza = value; }
        public double Profondità { get => profondità; set => profondità = value; }
        public double Volume { get 
            {
                return larghezza * altezza * profondità;    
            }
        }
        public double TotalArea 
        { 
            get
            {
                return 2 * (larghezza * altezza + larghezza * profondità + altezza * profondità);
            }
        }

        public Box ShallowCopy()
        {
            return this.MemberwiseClone() as Box;//as fa il cast se possibile,
                                                 //altrimenti returna null
            //la shallow copy funziona bene solo se nel campo ci sono tipi valore, tipo questo
            //se però nel nostro oggetto abbiam odei cambi che sono dei reference, la shallow copy
            //copia la reference 
        }

        public override string ToString()
        {
            return $"{nameof(Box)}[{nameof(Altezza)} = {altezza}, " +
                $"{nameof(Larghezza)} = {Larghezza}, " +
                $"{nameof(Profondità)} = {Profondità}]";
        }
        public int CompareTo(Box? other)
        {
            return Volume.CompareTo(other?.Volume);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            return Equals(obj as Box);
            //if (box != null)
            //{
            //    return Altezza == box.altezza && Profondità == box.Profondità && Larghezza == box.Larghezza;
            //}
            //else
            //{
            //    return false;
            //}
        }
        
        public override int GetHashCode()
        {
            //i parametri usati per l'uguaglianza devono essere gli stessi usati per il GetHashCode
            return HashCode.Combine(Altezza, Larghezza, Profondità);
        }

        //uguaglianza dentro IQuitable --> è usata quando facciamo l'uguale tipizzato
        public bool Equals(Box? other)
        {
            if (other is null)
            {
                return false;
            }
            else
            {
                return Altezza == other.altezza && Profondità == other.Profondità && Larghezza == other.Larghezza;
            }
        }
        public static bool operator ==(Box left, Box right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Box left, Box right)
        {
            return !(left == right);
        }

        public static bool operator <(Box left, Box right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Box left, Box right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Box left, Box right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Box left, Box right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
}
