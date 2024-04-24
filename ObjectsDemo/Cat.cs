using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDemo
{
    public class Cat
    {
        //i campi statici sono unici per classe: tutti gli oggetti di una classe condividono la stessa variabile statica
        private static  int numeroGattiCreati = 0;
        //definizione dello stato di un gatto
        //nome e colore
        //lo stato è definito attraverso i fields (campi) --> variabili definite all'interno della classe
        //i parametri - fields sono tipicamente privati
        private string name;
        private string color;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public static int NumeroGattiCreati { get => numeroGattiCreati;  }

        //properties --> rappresentano cosa si vuole mostrare esternamente dello stato di un oggetto
        //le properties di solito sono pubbliche 
        //i costruttori servono per inizializzare un oggetto alla creazione

        // Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
            numeroGattiCreati++;
        }
        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
            numeroGattiCreati++;
        }

        //i metodi -- servono a descrivere il comportamento di un oggetto
        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} of {1} color said: Miauuuuuu! ", name, color);
            
        }
        public static void NumeroFratelli()
        {

            Console.WriteLine($"Siamo gatti e siamo in {numeroGattiCreati}");
            //in un metodo statico non posso usare variabili non statiche, perché le variabili non statiche
            //assumono valori diversi da istanza (oggetto) ad istanza (oggetto)
            //Console.WriteLine($"Siamo di colore {this.color}");
        }

    }
}
