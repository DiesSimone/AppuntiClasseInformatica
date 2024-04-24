using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    namespace FaunaGreppi
    {
        //le classi astratte vengono utilizzate per definire delle classi base da cui derivano altre classi
        public abstract class EssereVivente
        {
            // Fields
            protected string nomeSpecie;
          

            protected EssereVivente():this("Sconosciuta")
            {
            }

            protected EssereVivente(string nomeSpecie)
            {
                this.nomeSpecie = nomeSpecie;
               
            }

            // Properties
            public string NomeSpecie
            {
                get { return nomeSpecie; }
                set { nomeSpecie = value; }
            }
            
            //tutti gli esseri viventi respirano, ma lo fanno in modo diverso
            //quindi il metodo respira è astratto, perché non si hanno abbastanza informazioni per implementarlo
            //saranno le classi derivate a implementare il metodo
            // Abstract methods
            public abstract void Respira();

            //le classi astratte possono avere metodi non astratti, quando si vuole fornire una implementazione di default e 
            //si vuole dare la possibilità di ridefinire il metodo
            // Non-abstract methods
            public virtual void Riposa()
            {
                Console.WriteLine("L'essere vivente riposa");
            }

            //il metodo digerisci è un metodo concreto, quindi non può essere ridefinito dalle classi derivate
            protected void Digerisci()
            {
                Console.WriteLine("L'essere vivente digerisce");
            }
          
        }
    }
    
}
