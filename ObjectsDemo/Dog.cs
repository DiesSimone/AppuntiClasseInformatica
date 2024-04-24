using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDemo
{
    // Class declaration
    public class Dog
    { // Opening bracket of the class body
      // Field declaration
        private string name;
        private int age;
        private double length;
        private Collar collar;
        //un esempio di campo statico
        public static int numberOfLegs = 4;
        // Constructor declaration (peremeterless empty constructor)
        //public Dog()
        //{
        //   name = "Sharo";
        //   age = 3;
        //   length = 0.5;
        //   collar = new Collar();
        //}
        // Another constructor declaration
        //public Dog(string name)
        //{
        //    this.name = name;
        //    collar = new Collar();
        //}
        //costruttore senza parametri
        public Dog():this("Fido")
        {
            //this.name = name;
            //age = 3;
            //length = 0.5;
            //collar = new Collar();
        }

        //costruttore a un parametro
        public Dog(string name):this(name,3)
        {
            //this.name = name;
            //age = 3;
            //length = 0.5;
            //collar = new Collar();
        }
        //public Dog(string dogName, int dogAge, double dogLength)
        //{
        //    name = dogName;
        //    age = dogAge;
        //    length = dogLength;
        //    collar = new Collar();
        //}

        //costruttore a due parametri
        public Dog(string name, int age):this(name,age,0.5)
        {
           
        }

        //this con le parentesi tonde richiama un altro costruttore della stessa classe
        public Dog(string name, int age, double length):this(name,age,length, new Collar())
        {
            //this.name = name;
            //this.age = age;
            //this.length = length;
            //collar = new Collar();

        }
        //costruttore che prende in input tutti i parametri
        public Dog(string name, int age, double length, Collar collar)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.collar = collar;
        }
        // Property declaration
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get => age; set => age = value; }

        // Method declaration (non-static)
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",
            name ?? "[unnamed dog]");
            //posso accedere ad un campo statico anche all'interno di un metodo non statico
            Console.WriteLine("I have {0} legs", numberOfLegs);
        }
        //un esempio di metodo statico
        public static void Abbaia()
        {
            Console.WriteLine("bau bau");
            Console.WriteLine("I have {0} legs", numberOfLegs);
            //non posso accedere ai campi non statici
            //Console.WriteLine($"La mia età è {age}");
        }
        public int GetAge()
        {
            //questo è un esempio di un metodo non statico che accede ad un campo non statico
            return age;
        }
    }
}
