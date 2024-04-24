using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public class Lion : Felidae, IReproducible<Lion>
    {
        private Paw frontLeft;
        private Paw frontRight;
        private Paw bottomLeft;
        private Paw bottomRight;

        private int weight;
        // Keyword "base" will be explained in the next paragraph
        public Lion(bool male, int weight) : base(male)
        {
            this.weight = weight;
            frontLeft = new Paw("frontLeft");
            frontRight = new Paw("frontRight");
            bottomLeft = new Paw("bottomLeft");
            bottomRight = new Paw("bottomRight");
        }
        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
        private void MovePaw(Paw paw)
        {
            Console.WriteLine($"moved {paw.PawName}");
        }
        public override void Walk()
        {
            MovePaw(frontLeft);
            MovePaw(frontRight);
            MovePaw(bottomLeft);
            MovePaw(bottomRight);
        }
        public Lion[] Reproduce(Lion mate)
        {
            //dall'unione di due leoni nascono dei leoncini
            Lion[] leoncini = new Lion[2];
            leoncini[0] = new Lion(true, 4);
            leoncini[1] = new Lion(false, 4);
            return leoncini;
        }

        public override string ToString()
        {
            //la property è pubblica ed è usabile nelle classi derivate
            //il campo male è privato e  non è accessibile nelle classi derivate
            string genere = Male ? "maschio" : "femmina";
            return $"Sono un Lion e sono {genere}";
        }

        private class Paw
        {
            private string pawName;
            public Paw(string pawName)
            {
                this.pawName = pawName;
            }

            public string PawName { get => pawName; set => pawName = value; }
        }
    }
}
