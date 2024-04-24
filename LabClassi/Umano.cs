using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    namespace FaunaGreppi
    {
        public class Umano:Mammifero,ISocial, IHumanNeeds
        {
            private int qi;

            public Umano(double peso, DateTime dataDiNascita, Color coloreOcchi, 
                TipoPelle tipoPelle, bool vivo, double kCalAllaNascita, 
                Cervello cervello, int numeroMammelle, int qi, Genere genere = Genere.Femmina) 
                : base(peso, dataDiNascita, coloreOcchi, tipoPelle, vivo, kCalAllaNascita, cervello, numeroMammelle, genere)
            {
                this.qi = qi;
            }
            override public string ToString()
            {
                return nameof(Umano) + "[" + base.ToString()
                    + " " + nameof(qi) + ": " + Qi + "]";
            }
            public int Qi { get => qi; set => qi = value; }

            public override sealed string Comunica()
            {
                return $"Sono un umano con un qi di {qi}";
            }

            //il metodo Allatta non è un override ma un new
            //non ridefinisce il metodo della classe base ma ne dichiara uno nuovo
            //che nasconde il metodo della classe base
            //Con new si può ridefinire un metodo che non è virtual
            //in questo caso sarà possibile chiamare il metodo Allatta della classe base facendo un cast
            public new void Allatta()
            {
                Console.WriteLine("Sono un Umano e allatto.... (sus)");
            }
            public void Dorme()
            {
                Console.WriteLine("Dormo....Zzzzzz");
            }

            public void Mangia()
            {
                Console.WriteLine("Mangio....gnam gnam");
            }

            public void Parla(string parole)
            {
                Console.WriteLine(parole);
            }

            public void Saluta()
            {
                Console.WriteLine("Ciao!");
            }

            public void Sorride()
            {
                Console.WriteLine("IIIIIIIIIIIIIIIIIIII");
            }
        }
    }
}
