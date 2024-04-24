using System.Drawing;

namespace LabClassi
{
    namespace FaunaGreppi
    {
        public class Mammifero : Animale, IRiproducibile<Mammifero>
        {
            public const string VERSO_MAMMIFERO_DEFAULT = "Comunica mammifero";
            private readonly int numeroMammelle;
            private Genere genere;
            public Mammifero(double peso, DateTime dataDiNascita,
               Color coloreOcchi, TipoPelle tipoPelle, bool vivo,
               double kCalAllaNascita, Cervello cervello, int numeroMammelle, Genere genere=Genere.Femmina) :
            base(peso, dataDiNascita, coloreOcchi, tipoPelle, vivo, kCalAllaNascita, cervello)
            {
                this.numeroMammelle = numeroMammelle;
                this.genere = genere;
            }

            public int NumeroMammelle
            {
                get
                {
                    return numeroMammelle;
                }

            }

            public Genere Genere { get => genere; set => genere = value; }

            public override string Comunica()
            {
                return (this.Vivo ? VERSO_MAMMIFERO_DEFAULT : "");
            }

            public void Allatta()
            {
                Console.WriteLine("Sono un Mammifero e allatto....");
            }

            public override string ToString()
            {
                return nameof(Mammifero) + "[" + base.ToString()
                    + " " + nameof(numeroMammelle) + ": " + NumeroMammelle+ " " + nameof(Genere) + ": " + Genere +"]";
            }

            public Mammifero[]? Riproduci(Mammifero mate)
            {
                Mammifero[]? cuccioli = null;
                if (mate.genere!=genere && mate.GetType()==GetType())
                {
                    cuccioli = new Mammifero[2];
                    cuccioli[0] = new Mammifero((Peso+mate.Peso)/40.0, DateTime.Now, ColoreOcchi, Pelle, true, 10000, new Cervello(), numeroMammelle, Genere.Femmina);
                    cuccioli[1] = new Mammifero((Peso + mate.Peso)/35.0, DateTime.Now, mate.ColoreOcchi, Pelle, true, 10000, new Cervello(), numeroMammelle, Genere.Maschio);
                    
                }
                return cuccioli;
            }
        }
    }

}
