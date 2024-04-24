using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassi
{
    public class Dog
    {
        // Static variable
        static int dogCount;
        // Instance variables
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            dogCount += 1;
        }
        public void Bark()
        {
            Console.WriteLine("wow-wow");
        }
        // Non-static (instance) method
        public void PrintInfo()
        {
            // Accessing instance variables – name and age
            Console.Write("Dog's name: " + this.name + "; age: "
            + this.age + "; often says: ");
            // Calling instance method
            this.Bark();
        }
        //esempio di metodo statico che prova ad accedere a un campo di istanza
        // non si può fare
        public static void PrintName()
        {
            // Trying to access non-static variable from static method
            //Console.WriteLine(name); // INVALID
        }
        public override string ToString()
        {
            return $"{{{nameof(name)}:{name}, {nameof(age)}:{age}}}";
        }
    }
}
