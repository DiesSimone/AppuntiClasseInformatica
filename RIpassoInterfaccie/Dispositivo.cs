using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RIpassoInterfaccie
{
    public enum TipoDispositivo
    {
        Cellulare,
        PC,
        TV
    }
    public class Dispositivo : IEquatable<Dispositivo>, IComparable<Dispositivo>, IUsb
    {
        string nome;
        string marca;
        TipoDispositivo tipo;
        double prezzo;

        public Dispositivo(string nome, string marca, TipoDispositivo tipo, double prezzo)
        {
            this.nome = nome;
            this.marca = marca;
            this.tipo = tipo;
            this.prezzo = prezzo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Marca { get => marca; set => marca = value; }
        public TipoDispositivo Tipo { get => tipo; set => tipo = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }

        //ordinamento naturale o predefinito
        public int CompareTo(Dispositivo? other)
        {
            if(other is null) //check per controllare se è null
            {
                return 1;
            }
            return prezzo.CompareTo(other.prezzo);
            //return prezzo.CompareTo(other?.prezzo); --> se usi questo; tutto il pezzo sopra E' L'ALTERNATIVA!
        }

        public bool Equals(Dispositivo? other)
        {
            //criterio di uguaglianza tra 
            //if (other == null)
            //{
            //    return false;
            //}
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            else
            {
                return nome.Equals(other.nome) && marca.Equals(other.marca);
                //return nome == other.nome && marca == other.marca;
            }
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }
            return Equals(obj as Dispositivo);
            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nome, marca);
        }

        public override string? ToString()
        {
            return $"{nameof(Dispositivo)} [{nameof(Nome)}: {Nome}, " +
                $"{nameof(Marca)}: {Marca}, {nameof(Tipo)}: {Tipo}, " +
                $"{nameof(Prezzo)}: {Prezzo}] ";
        }

        public void Trasmetti(string messaggio)
        {
            Console.WriteLine(messaggio);
        }

        public string Ricevi()
        {
            return "Messaggio da interfaccia";
        }

        public static bool operator == (Dispositivo left, Dispositivo right)
        {
            return left.Equals(right);
        }
        public static bool operator != (Dispositivo left, Dispositivo right)
        {
            return !left.Equals(right);
        }

        public static bool operator <(Dispositivo left, Dispositivo right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Dispositivo left, Dispositivo right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(Dispositivo left, Dispositivo right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(Dispositivo left, Dispositivo right)
        {
            return left.CompareTo(right) >= 0;
        }

        //ROBE A CASO

    }
}
