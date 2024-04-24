using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RipassoClassi
{
    //internal è l'access modificator che restringe la visibilità solo all'interno del progetto (RipassoClassi)
    //assembly = progetto compilato --> risultato dll (librerie dinamiche)
    //public rende la classe accessibile anche all'esterno del progetto
    public class Persona
    {
        //abbiamo i cambi --> definiscono lo stato d un oggetto (tipicamente private)
        //le properties --> ciò che rendiamo visibile (parte visibile) dello stato (tipicamente public)ù
        //costruttori --> particolari metodi che hanno lo stesso nome della classe e servono
        //a creare le istanze (inizializzano gli oggetti)
        //metodi --> rappresentano il comportamento degli oggetti e sono la versione ad oggetti 
        //delle funzioni

        string nome;
        string cognome;
        DateTime dataNascita;

        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = dataNascita;
        }
        public Persona(string nome, string cognome):this(nome, cognome, DateTime.Now)
        {

        }
        public Persona():this(string.Empty, string.Empty)
        {

        }

        public string Nome 
        { 
            get 
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Cognome { get => cognome; set => cognome = value; }
        public DateTime DataNascita { get => dataNascita; set => dataNascita = value; }

        //i metodi
        public virtual string MiPresento()
        {
            return $"Ciao, sono {Nome} {Cognome} e sono un oggetto di tipo {nameof(Persona)}";
        }

        public override string ToString()
        {
            return $"{nameof(Persona)}[{nameof(Nome)}={Nome}" +
                $", {nameof(Cognome)}={Cognome}," +
                $" {nameof(DataNascita)}={DataNascita.ToShortDateString()}]";
        }
    }
}
