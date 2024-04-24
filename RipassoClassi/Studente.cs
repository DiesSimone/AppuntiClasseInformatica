using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoClassi
{
    //una classe può avere una sola base class
    //una classe può implementare tutte le interfacce che vuole
    public class Studente : Persona, IStudentable, ISocial
    {
        double mediaVoti;
        string classe;

        public Studente(string nome, string cognome, DateTime dataNascita, 
            string classe, double mediaVoti) :
            base(nome, cognome, dataNascita)
        {
            this.classe = classe;
            this.mediaVoti = mediaVoti;
        }

        public double MediaVoti { get => mediaVoti; set => mediaVoti = value; }
        public string Classe { get => classe; set => classe = value; }

        public string EscoConBrothers(Persona[] p)
        {
            string messaggio = "Oggi esco con";
            foreach (Persona persona in p)
            {
                messaggio += " "+ persona.Nome+ " ,"; 
            }
            return messaggio;
        }

        public override string MiPresento()
        {
            return $"Sono uno studente e mi chiamo {Nome} {Cognome}";
        }

        public void SeguoLezioni()
        {
            Console.WriteLine("Seguo le lezioni con attenzione!");
        }

        public void Studio()
        {
            Console.WriteLine("Studio almeno 3 ore al giorno, senza distrazioni");
        }

        public void SvolgoVerifiche()
        {
            Console.WriteLine("Svolgo le verifiche in modo soddisfacente");
        }
    }
}
