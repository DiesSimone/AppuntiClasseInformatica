using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaContattiDemo
{
    public class Contatto : IEquatable<Contatto?>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Contatto);
        }

        public bool Equals(Contatto? other)
        {
            return other is not null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(Contatto? left, Contatto? right)
        {
            return EqualityComparer<Contatto>.Default.Equals(left, right);
        }

        public static bool operator !=(Contatto? left, Contatto? right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{{Id = {Id}, Nome = {Nome}, Cognome = {Cognome}, Telefono = {Telefono}, Email = {EMail}}}";
        }
    }
}
