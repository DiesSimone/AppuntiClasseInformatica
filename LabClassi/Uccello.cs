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
        public class Uccello:Animale, IRiproducibile<Uccello>
        {
            private string verso;
            private string razza;
            Genere genere;

            public Uccello(double peso, DateTime dataDiNascita, Color coloreOcchi,
                TipoPelle tipoPelle, bool vivo, double kCalAllaNascita, Cervello cervello, string verso, string razza, Genere genere =Genere.Femmina) :
                    base(peso, dataDiNascita, coloreOcchi, tipoPelle, vivo, kCalAllaNascita, cervello)
            {
                this.verso = verso;
                this.razza = razza;
                this.genere = genere;
            }

            public string Verso { get => verso; set => verso = value; }
            public string Razza { get => razza; set => razza = value; }
            public Genere Genere { get => genere; set => genere = value; }

            public void Vola()
            {
                Console.WriteLine("Sto volando....");
            }
            public void Canta()
            {
                Console.WriteLine(verso);
            }

            public Uccello[]? Riproduci(Uccello mate)
            {
                Uccello[]? pulcini = null;
                if (mate.genere != this.genere)
                {
                    pulcini = new Uccello[2];
                    pulcini[0] = new Uccello((Peso + mate.Peso) / 20.0, DateTime.Now, ColoreOcchi, Pelle, true, 1000, new Cervello(0.01,10000), verso, razza, Genere.Femmina);
                    pulcini[1] = new Uccello((Peso + mate.Peso) / 20.0, DateTime.Now, mate.ColoreOcchi, Pelle, true, 1000, new Cervello(0.01, 10000), mate.verso, mate.razza, Genere.Maschio);
                    
                }
                return pulcini;
            }
        }
    }
    
}
