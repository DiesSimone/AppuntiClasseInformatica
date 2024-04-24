using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public class Felidae
    {
        private bool male;
        // This constructor calls another constructor
        public Felidae() : this(true)
        { }
        // This is the constructor that is inherited
        public Felidae(bool male)
        {
            this.male = male;
        }
        public bool Male
        {
            get { return male; }
            set { this.male = value; }
        }
        public virtual void Walk()
        {
            // …
        }
        public override string? ToString()
        {
            string genere = male ? "maschio" : "femmina";
            return $"Felidae: genere --> {genere}";
        }
    }
}
