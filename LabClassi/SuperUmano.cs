using LabClassi.FaunaGreppi;
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
        public class SuperUmano : Umano
        {
            public SuperUmano(double peso, DateTime dataDiNascita, Color coloreOcchi, 
                TipoPelle tipoPelle, bool vivo, double kCalAllaNascita, Cervello cervello, int numeroMammelle, int qi, Genere genere = Genere.Femmina)
                : base(peso, dataDiNascita, coloreOcchi, tipoPelle, vivo, kCalAllaNascita, cervello, numeroMammelle, qi, genere)
            {
            }
            public void Vola()
            {
                Console.WriteLine("Volo....");
            }

            public void UsaSuperPotere()
            {
                Console.WriteLine("Usa super potere....");
            }

            public override void Respira()
            {
                //base.Respira();
                Console.WriteLine("Sono un SuperUmano e respiro dalla pelle");
            }

            public override string ToString()
            {
                return nameof(SuperUmano) + "[" + base.ToString() + "]";
            }
            // non è possibile ridefinire un metodo che è stato dichiarato come sealed nella classe base
            //public override string Comunica()
            //{
            //    return "Sono un super umano!";
            //}
        }
    }
    
    
}
