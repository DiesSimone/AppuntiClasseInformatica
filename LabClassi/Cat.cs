namespace LabClassi
{
    public class Cat
    {
        // Instance variables
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
       
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public override string ToString()
        {
            return $"{{{nameof(name)}:{name}, {nameof(age)}:{age}}}";
        }
    }
}